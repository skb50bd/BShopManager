using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MongoDB.Bson;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;


namespace WinFormsUI.Forms {
    public partial class PurchaseForm : Form {
        #region MakeDraggable

        /// <summary>
        ///     This Part Makes the Form Draggable, as the Form Has No Border
        /// </summary>
        public const int WmNclbuttondown = 0xA1;

        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MakeDraggable(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
            }
        }

        #endregion
        #region NumericValidation

        /// <summary>
        ///     This Function Checks if The Field has valid Numeric value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericValueValidation(object sender, KeyPressEventArgs e) {
            // allows 0-9, backspace, and decimal
            if ((e.KeyChar < 0x30 || e.KeyChar > 0x39) && e.KeyChar != 0x8 && e.KeyChar != 0x2E && e.KeyChar != 0x2D) {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
        }

        #endregion

        #region Global Variables

        private Purchase _purchase;
        private List<Purchase> _drafts;
        private Supplier _supplier;
        private Product _product;
        private ShoppingCart _sCart;

        #endregion


        public PurchaseForm() {
            InitializeComponent();
        }
        private void PurchaseForm_Load(object sender, EventArgs e) {
            CartDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CartDataGrid.AutoGenerateColumns = false;

            _purchase = new Purchase();
            _sCart = new ShoppingCart();
            RefreshSuppliers();
            RefreshProducts();
            RefreshSavedVoucharList();
            ResetProductButton_Click(sender, e);
            ResetSupplierButton_Click(sender, e);
        }

        #region Supplier

        private void RefreshSuppliersFields() {
            RefreshAmounts();
            SupplierNameText.Text = _supplier.FullName;
            CompanyText.Text      = _supplier.CompanyName;
            AddressText.Text      = _supplier.Address;
        }

        private void RefreshSuppliers() {
            SupplierCombo.DataSource = null;
            SupplierCombo.DataSource = Suppliers;
        }

        private void SupplierCombo_SelectedIndexChanged(object sender, EventArgs e) {
            if (SupplierCombo.SelectedIndex > -1)
                _supplier = Suppliers[SupplierCombo.SelectedIndex];
            else
                _supplier = new Supplier();
            RefreshSuppliersFields();
        }

        private void ResetSupplierButton_Click(object sender, EventArgs e) => SupplierCombo.SelectedIndex = -1;

        private void AddSupplierButton_Click(object sender, EventArgs e) {
            Form ac = new SupplierInformationForm();
            DialogResult result = ac.ShowDialog();
            if (result != DialogResult.OK)
                RefreshSuppliers();
        }

        private void ViewSupplierButton_Click(object sender, EventArgs e) {
            if (SupplierCombo.SelectedIndex < 0)
                return;

            try {
                Form ci = new SupplierInformationForm(Suppliers[SupplierCombo.SelectedIndex]);
                DialogResult result = ci.ShowDialog();
                if (result == DialogResult.OK)
                    RefreshSuppliers();
            } catch (Exception exception) {
                Debug.WriteLine(exception);
            }
        }

        #endregion

        #region Product

        private void RefreshProductFields() {
            ShopStockText.Text = _product.GetShopStock;
            GodownStockText.Text = _product.GetGodownStock;
            RetailPriceText.Text = _product.GetRetailPrice;
            WholeSalePriceText.Text = _product.GetWholeSalePrice;
            UnitPriceText.Text = _product.GetPurchasePrice;
            UnitSelectorCombo.DataSource = _product.Units;
            QuantityText.Text = "";
            NetPriceText.Text = "";
        }

        private void RefreshProducts() {
            ProductSelectorCombo.DataSource = null;
            ProductSelectorCombo.DataSource = Products;
        }

        private void ProductSelectorCombo_SelectedIndexChanged(object sender, EventArgs e) {
            if (ProductSelectorCombo.SelectedIndex > -1)
                _product = Products[ProductSelectorCombo.SelectedIndex];
            else
                _product = new Product();
            RefreshProductFields();
        }

        private void ResetProductButton_Click(object sender, EventArgs e) => ProductSelectorCombo.SelectedIndex = -1;

        private void ViewProductButton_Click(object sender, EventArgs e) {
            if (ProductSelectorCombo.SelectedIndex < 0)
                return;
            Form form = new ProductInformationForm(_product);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
                RefreshProducts();
        }

        private void AddProductButton_Click(object sender, EventArgs e) {
            Form form = new ProductInformationForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
                RefreshProducts();
        }

        #endregion

        #region Cart

        private void RefreshCart() {
            CartDataGrid.DataSource = null;
            CartDataGrid.DataSource = _purchase.Cart;
        }

        private bool ValidateProduct() {
            string error = string.Empty;
            if (!float.TryParse(QuantityText.Text, out float q) || q < 0)
                error += "Invalid quantity\n";
            if (!decimal.TryParse(UnitPriceText.Text, out decimal u) || u < 0)
                error += "Invalid unit price\n";

            if (error.Length > 0) {
                MessageBox.Show("Following errors occured:\n" + error, "Error");
                return false;
            }
            return true;
        }

        private void AddToCartButton_Click(object sender, EventArgs e) {
            if (!ValidateProduct())
                return;

            if (ProductSelectorCombo.SelectedIndex > -1) {
                if (_purchase.Cart.Exists(c => c.ProductId == _product.ObjectId))
                    _purchase.Cart.Remove(_purchase.Cart.Single(c => c.ProductId == _product.ObjectId));

                ShoppingCart sc = new ShoppingCart {
                    ProductId = _product.ObjectId,
                    ProductName = _product.ProductName,
                    UnitPurchasePrice = decimal.Parse(UnitPriceText.Text),
                    Quantity = float.Parse(QuantityText.Text),
                    Unit = _product.Units[UnitSelectorCombo.SelectedIndex]
                };
                _purchase.Cart.Add(sc);
                RefreshCart();
            } else {
                MessageBox.Show("Product is not saved in the database.\n" +
                                "Purchased product has to be documented in the database.\n" +
                                "For regular expenses, use the \"Expense\" option in the main menu.\n\n" +
                                "You can use the add product (+) button to document this product\n", "Error");
            }
            _purchase.TotalAmount = _purchase.Cart.Sum(sc => sc.NetPurchasePrice);
            RefreshAmounts();
            ProductSelectorCombo.SelectedIndex = -1;
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e) {
            if (CartDataGrid.SelectedRows[0].Index > -1)
                _purchase.Cart.RemoveAt(CartDataGrid.SelectedRows[0].Index);
            RefreshCart();
        }

        private void CartDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (CartDataGrid.CurrentCell.RowIndex > -1) {
                ProductSelectorCombo.SelectedIndex = Products
                    .FindIndex(p => p.ObjectId == _purchase.Cart[CartDataGrid.CurrentCell.RowIndex].ProductId);
            }
        }

        private void RefreshAmounts() {
            TotalText.Text = _purchase.TotalAmount.ToString("0.##") + " Tk";
            PreviousDueText.Text = _supplier.GetPayable;
            LessAmountText.Text = _purchase.GetLess;
            PayableText.Text = _purchase.GetPayable;
            FullPayableText.Text = (_supplier.Payable + _purchase.Due).ToString("0.##");
            DiscountPercentageText.Text = _purchase.GetDiscount;
            PaidAmountText.Text = _purchase.GetPaid;
            DueText.Text = _purchase.Due < 0
                ? "0"
                : _purchase.GetDue;
            FullDueText.Text = (_purchase.Due + _supplier.Payable).ToString("0.##");
        }

        #endregion

        #region Drafts

        private void LoadVouchar() {
            try {
                SupplierCombo.SelectedIndex = Suppliers.FindIndex(s => s.ObjectId == _purchase.SupplierId);
                PayableText.Text            = _purchase.GetPayable;
                SupplierNameText.Text       = _purchase.SupplierName;
                CompanyText.Text            = _purchase.SupplierCompany;
                AddressText.Text            = _purchase.SupplierAddress;
                NotesText.Text              = _purchase.Note;
                RefreshAmounts();
                RefreshCart();
            } catch (Exception e) {
                Debug.WriteLine(e);
                throw;
            }
        }

        private void RefreshSavedVoucharList() {
            SavedVoucharList.DataSource = null;
            _drafts = Connection[0].GetSavedPurchaseAll();
            SavedVoucharList.DataSource = _drafts;
        }

        private void LoadSavedVoucharButton_Click(object sender, EventArgs e) {
            if (SavedVoucharList.SelectedIndex > -1) {
                _purchase = _drafts[SavedVoucharList.SelectedIndex];
                LoadVouchar();
            } else
                MessageBox.Show("Invalid selection", "Error");
        }

        private void RemoveSavedVoucharButton_Click(object sender, EventArgs e) {
            if (SavedVoucharList.SelectedIndex > -1) {
                Connection[0].DeleteSavedPurchase(_drafts[SavedVoucharList.SelectedIndex]);
                RefreshSavedVoucharList();
            }
        }

        #endregion

        private void QuantityText_TextChanged(object sender, EventArgs e) {
            if (float.TryParse(QuantityText.Text, out float q) && q > 0) {
                _sCart.Quantity = q;
                _sCart.Unit = _product.Units[UnitSelectorCombo.SelectedIndex];
                if (decimal.TryParse(UnitPriceText.Text, out decimal up))
                    NetPriceText.Text = ((decimal)q * up).ToString("0.##");
                else if (decimal.TryParse(NetPriceText.Text, out decimal np))
                    UnitPriceText.Text = (np / (decimal)q).ToString("0.##");
            }
        }

        private void UnitPriceText_TextChanged(object sender, EventArgs e) {
            if (decimal.TryParse(UnitPriceText.Text, out decimal up)) {
                if (float.TryParse(QuantityText.Text, out float q))
                    NetPriceText.Text = (up * (decimal)q).ToString("0.##");
                else if (decimal.TryParse(NetPriceText.Text, out decimal np) && up > 0)
                    QuantityText.Text = (np / up).ToString("0.##");
            }
        }

        private void NetPriceText_TextChanged(object sender, EventArgs e) {
            if (decimal.TryParse(NetPriceText.Text, out decimal np)) {
                if (float.TryParse(QuantityText.Text, out float q) && q > 0)
                    UnitPriceText.Text = (np / (decimal)q).ToString("0.##"); 
                else if (decimal.TryParse(UnitPriceText.Text, out decimal up) && up > 0)
                    QuantityText.Text = (np / up).ToString("0.##");
            }
        }

        private void UnitSelectorCombo_SelectedIndexChanged(object sender, EventArgs e) {
            if (UnitSelectorCombo.SelectedIndex > -1) {
                _sCart.Unit = _product.Units[UnitSelectorCombo.SelectedIndex];
                QuantityText.Text = _sCart.GetQuantity;

                UnitPriceText.Text = (_product.PurchasePrice / (decimal)_sCart.Unit.Weight).ToString("0.##");
                if (float.TryParse(QuantityText.Text, out float q) && q > 0) {
                    _sCart.Quantity = _sCart.BaseQuantity / _product.Units[UnitSelectorCombo.SelectedIndex].Weight;
                    NetPriceText.Text =
                        (_product.PurchasePrice / (decimal)_sCart.Unit.Weight * (decimal)q).ToString("0.##");

                }
            } else {
                QuantityText.Text = "";
                UnitPriceText.Text = "";
                NetPriceText.Text = "";
            }
        }

        private void DiscountPercentageText_TextChanged(object sender, EventArgs e) {
            if (float.TryParse(DiscountPercentageText.Text, out float dp) && dp > 0 && dp <= 100)
                _purchase.Less = _purchase.TotalAmount * (decimal)dp / 100;
            RefreshAmounts();
        }

        private void LessAmountText_TextChanged(object sender, EventArgs e) {
            if (decimal.TryParse(LessAmountText.Text, out decimal l) && l >= 0 && l <= _purchase.TotalAmount)
                _purchase.Less = l;
            RefreshAmounts();
        }

        private void PaidAmountText_TextChanged(object sender, EventArgs e) {
            if (decimal.TryParse(PaidAmountText.Text, out decimal p))
                _purchase.Paid = p;
            RefreshAmounts();
        }


        private bool ValidatePurchase() {
            string error = string.Empty;
            string warning = string.Empty;

            if (SupplierCombo.SelectedIndex == -1)
                warning += "Supplier is not documented in the database\n";
            if (SupplierNameText.Text.Length == 0)
                error += "Supplier name is not provided\n";
            if (CompanyText.Text.Length == 0)
                warning += "Company name is not provided\n";
            if (AddressText.Text.Length == 0)
                warning += "Address is not provided\n";
            if (NotesText.Text.Length == 0)
                warning += "Note is empty\n";

            if (_purchase.Cart.Count == 0)
                error += "The purchase cart is empty\n";

            if (!decimal.TryParse(LessAmountText.Text, out decimal l) || l < 0 || l > _purchase.TotalAmount)
                error += "Less amount is invalid\n";
            if (!decimal.TryParse(PaidAmountText.Text, out decimal p) || p < 0 || l > _purchase.TotalAmount)
                error += "Paid amount is invalid\n";

            if (error.Length > 0 || warning.Length > 0) {
                DialogResult result = MessageBox.Show("The following error(s) occurred during validation:\n"
                                                      + error
                                                      + "The following warning(s) occurred during validation:\n"
                                                      + warning
                                                      + "\n\nDo you want to ignore the warnings?",
                    "Confirm",
                    MessageBoxButtons.YesNo);
                if (error.Length == 0 && result == DialogResult.Yes)
                    return true;
                return false;
            }
            return true;
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            if (!ValidatePurchase())
                return;

            if (SupplierCombo.SelectedIndex > -1) {
                _purchase.SupplierId = _supplier.ObjectId;
            } else {
                if (_purchase.Due > 0) {
                    DialogResult result = MessageBox.Show("Non-documented suppliers should not get late payments\n" +
                                                          "Do you want to continue anyway?",
                                                          "Confirm",
                                                          MessageBoxButtons.YesNo);
                    if (result != DialogResult.Yes)
                        return;
                }
                _purchase.SupplierId = ObjectId.Empty;
            }
            _purchase.SupplierName = SupplierNameText.Text;
            _purchase.SupplierCompany = CompanyText.Text;
            _purchase.SupplierAddress = AddressText.Text;
            _purchase.Note = NotesText.Text;
            _purchase.DealTime = DealDateTime.Value;
            _purchase.TotalAmount = _purchase.Cart.Sum(c => c.NetPurchasePrice);
            _purchase.Less = decimal.Parse(LessAmountText.Text);
            _purchase.Paid = decimal.Parse(PaidAmountText.Text);

            if (sender as Button == SubmitButton) {
                DialogResult confirm = MessageBox.Show("Are you sure want to register this purchase?\n" +
                        $"Supplier Name\t\t: {_purchase.SupplierName}\n" +
                        $"Supplier Company\t\t: {_purchase.SupplierCompany}\n" +
                        $"Products\t\t\t: {_purchase.Cart.Count}\n" +
                        $"Payable\t\t\t: {_purchase.Payable.ToString("0.##")}\n" +
                        $"Paid\t\t\t: {_purchase.Paid.ToString("0.##")}\n" +
                        $"Due\t\t\t: {_purchase.Due.ToString("0.##")}\n",
                    "Confirm",
                    MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes)
                    return;

                try {
                    _purchase = Connection[0].InsertPurchase(_purchase);
                } catch (Exception ex) {
                    MessageBox.Show($"Error occurred\n{ex.Message}", "Error");
                    return;
                }
            } else if (sender as Button == SaveButton) {
                DialogResult confirm = MessageBox.Show("Are you sure want to save this vouchar?\n" +
                        $"Supplier Name\t\t: {_purchase.SupplierName}\n" +
                        $"Supplier Company\t\t: {_purchase.SupplierCompany}\n" +
                        $"Products\t\t\t: {_purchase.Cart.Count}\n" +
                        $"Payable\t\t\t: {_purchase.Payable.ToString("0.##")}\n" +
                        $"Paid\t\t\t: {_purchase.Paid.ToString("0.##")}\n" +
                        $"Due\t\t\t: {_purchase.Due.ToString("0.##")}\n",
                    "Confirm",
                    MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes)
                    return;
                try {
                    _purchase = Connection[0].SavePurchase(_purchase);
                    RefreshSavedVoucharList();
                } catch (Exception ex) {
                    MessageBox.Show($"Error occurred\n{ex.Message}", "Error");
                    return;
                }
            }
            ReloadSuppliersProducts_Click(sender, e);
            ResetForm();
        }

        private void ResetForm() {
            _purchase = new Purchase();
            RefreshSuppliers();
            RefreshProducts();
            ResetSupplierButton_Click(this, EventArgs.Empty);
            ResetProductButton_Click(this, EventArgs.Empty);
            RefreshAmounts();
            RefreshCart();
            RefreshSavedVoucharList();
        }

        private void ReloadSuppliersProducts_Click(object sender, EventArgs e) {
            Suppliers = Connection[0].GetSupplierAll();
            RefreshSuppliers();
            Products = Connection[0].GetProductsAll();
            RefreshProducts();
            RefreshSavedVoucharList();
        }

        private void PaidAmountText_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(PaidAmountText.Text, out decimal p))
            {
                _purchase.Paid = p;
                RefreshAmounts();
            }
        }

        #region Key Downs
        private void SupplierCombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SupplierNameText.Focus();
        }

        private void SupplierNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CompanyText.Focus();
        }

        private void AddressText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NotesText.Focus();
        }

        private void CompanyText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddressText.Focus();
        }

        private void NotesText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DealDateTime.Focus();
        }

        private void ProductSelectorCombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                QuantityText.Focus();
        }

        private void QuantityText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UnitPriceText.Focus();
        }

        private void UnitPriceText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NetPriceText.Focus();
        }

        private void NetPriceText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddToCartButton.Focus();
        }

        private void DiscountPercentageText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LessAmountText.Focus();
        }

        private void LessAmountText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PaidAmountText.Focus();
        }

        private void PaidAmountText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SubmitButton.Focus();
        } 
        #endregion
    }
}
