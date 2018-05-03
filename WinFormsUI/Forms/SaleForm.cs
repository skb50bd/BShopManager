using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MongoDB.Bson;
using ShopLibrary.Models;
using ShopLibrary.Output;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class SaleForm : Form {
    #region MakeDraggable
        /// <summary>
        ///     This Part Makes the Form Draggable, as the Form Has No Border
        /// </summary>
        public const int WmNclbuttondown = 0xA1;

        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage (IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture ();

        private void MakeDraggable (object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
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
        private void NumericValueValidation (object sender, KeyPressEventArgs e) {
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
        private Customer      _customer = new Customer();
        private List<Product> _products;
        private List<Product> _shopProducts;
        private List<Sale>    _drafts;
        private Product       _product = new Product();
        private Sale          _sale    = new Sale();
        private ShoppingCart  _sCart;
        private Memo          _memo;
    #endregion

        public SaleForm () => InitializeComponent();

        public SaleForm (Memo memo) {
            InitializeComponent();
            _memo = memo;
            _sale                  = _memo;
            ShopSelectorCombo.Text = _memo.ShopName;
            PreviousDueText.Text   = _memo.GetDue;
            FullDueText.Text       = _memo.CurrentDue.ToString("0.##");
            RefreshForm();

            foreach (Control control in Controls)
                if (!(control is Label))
                    control.Enabled = false;

            SaveButton.Enabled = true;
            SaveButton.Text = "Print";
        }

        private void SaleForm_Load (object sender, EventArgs e) {
            if (_memo != null)
                return;

            if (CurrentUser.AccessLevel > AppUser) {
                MessageBox.Show("Permission denied", "Error");
                Close();
            }

            CartDataGrid.AutoGenerateColumns = false;
            CartDataGrid.SelectionMode       = DataGridViewSelectionMode.FullRowSelect;
            DealDateTime.Value               = DateTime.Now.ToLocalTime();

            ShopSelectorCombo.DataSource = null;
            ShopSelectorCombo.DataSource = Shops;

            _sale  = new Sale();
            _sCart = new ShoppingCart();

            WireUp();

            CustomerCombo.SelectedIndex        = -1;
            ShopSelectorCombo.SelectedIndex    = -1;
            ProductSelectorCombo.SelectedIndex = -1;
            RefreshForm();
        }

        private void RefreshForm () {
            try {
                RetailSaleRadio.Checked         = _sale.SaleType == SaleType.RetailSale;
                WholeSaleRadio.Checked          = _sale.SaleType == SaleType.WholeSale;
                DealDateTime.Value              = _sale.DealTime;
                ShopSelectorCombo.SelectedIndex = Shops.FindIndex(s => s.ObjectId == _sale.ShopId);

                if (_sale.ShopId != ObjectId.Empty && ShopSelectorCombo.SelectedIndex == -1)
                    MessageBox.Show("Shop match not found");

                if (_sale.CustomerId != ObjectId.Empty)
                    CustomerCombo.SelectedIndex = Customers.FindIndex(c => c.ObjectId == _sale.CustomerId);

                if (_sale.CustomerId != ObjectId.Empty && CustomerCombo.SelectedIndex == -1)
                    MessageBox.Show("Customer match not found");

                NotesText.Text = _sale.Note;
                RefreshCustomerFields();
                RefreshProductFields();
                RefreshAmounts();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);

                throw;
            }
        }

        private void WireUp () {
            RefreshCustomers();
            RefreshProducts();
            RefreshSavedMemoList();
        }

        private void ShopSelectorCombo_SelectedIndexChanged (object sender, EventArgs e) {
            if (ShopSelectorCombo.SelectedIndex > -1) {
                _shopProducts = Products.Where(p =>
                                                   p.ShopId == Shops[ShopSelectorCombo.SelectedIndex].ObjectId
                                                && p.ShopStock + p.GodownStock > 0)
                                        .ToList();

                _sale.ShopId = Shops[ShopSelectorCombo.SelectedIndex].ObjectId;
            }
            else {
                _shopProducts = null;
                _sale.ShopId  = ObjectId.Empty;
            }

            _sale.Cart.Clear();
            SearchProductText.Text = "";
            SearchProductText_TextChanged(sender, e);
            RefreshAmounts();
        }

        private bool ValidateForm () {
            string error = string.Empty;

            if (ShopSelectorCombo.SelectedIndex < 0)
                error += "Shop not selected\n";
            if (!RetailSaleRadio.Checked && !WholeSaleRadio.Checked) error += "Must select retail or whole sale\n";
            if (CustomerNameText.Text.Length == 0) error                   += "Customer name is empty\n";
            if (LessAmountText.Text.Length == 0 || PaidAmountText.Text.Length == 0)
                error += "Must input Cash Amounts\n";
            if (_customer.Debt <= 0 && _sale.Cart.Count == 0)
                error += "No Items in the Cart\n";

            if (error.Length > 0) {
                MessageBox.Show("These errors occurred during validation:\n" + error, "Error");

                return false;
            }

            return true;
        }

        private void SubmitButton_Click (object sender, EventArgs e) {
            if (!ValidateForm())
                return;

            _sale.CustomerName    = CustomerNameText.Text;
            _sale.CustomerCompany = CompanyText.Text;
            _sale.CustomerAddress = AddressText.Text;
            _sale.Note            = NotesText.Text;
            _sale.SaleType = WholeSaleRadio.Checked
                                 ? SaleType.WholeSale
                                 : SaleType.RetailSale;
            _sale.DealTime = DealDateTime.Value;

            if (CustomerCombo.SelectedIndex > -1) {
                _sale.CustomerId = _customer.ObjectId;
            }
            else {
                if (_sale.Due > 0) {
                    DialogResult result =
                        MessageBox.Show("Non-documented customers should not enjoy late payments\n"
                                      + "Do you want to continue anyway?",
                                        "Confirm",
                                        MessageBoxButtons.YesNo);

                    if (result != DialogResult.Yes)
                        return;
                }

                _sale.CustomerId = ObjectId.Empty;
            }

            if (sender as Button == SubmitButton) {
                DialogResult confirm = MessageBox.Show("Are you sure want to register this sale?\n"
                                                     + $"Customer Name\t\t: {_sale.CustomerName}\n"
                                                     + $"Customer Company\t: {_sale.CustomerCompany}\n"
                                                     + $"Products\t\t\t: {_sale.Cart.Count}\n"
                                                     + $"Payable\t\t\t: {_sale.Payable.ToString("0.##")}\n"
                                                     + $"Paid\t\t\t: {_sale.Paid.ToString("0.##")}\n"
                                                     + $"Due\t\t\t: {_sale.Due.ToString("0.##")}\n",
                                                       "Confirm",
                                                       MessageBoxButtons.YesNo);

                if (confirm != DialogResult.Yes)
                    return;

                try {
                    _sale = Connection[0].InsertSale(_sale);
                    Memo memo = new Memo(_sale, _customer, Shops[ShopSelectorCombo.SelectedIndex]);
                    PrintSaleMemo.ToPdf(memo);
                    ReloadButton_Click(sender, e);
                    SaleForm_Load(sender, e);
                }
                catch (Exception ex) {
                    MessageBox.Show($"Error occurred\n{ex.Message}", "Error");

                    return;
                }
            }
            else if (sender as Button == SaveButton) {
                DialogResult confirm = MessageBox.Show("Are you sure want to save this sale?\n"
                                                     + $"Customer Name\t\t: {_sale.CustomerName}\n"
                                                     + $"Customer Company\t: {_sale.CustomerCompany}\n"
                                                     + $"Products\t\t\t: {_sale.Cart.Count}\n"
                                                     + $"Payable\t\t\t: {_sale.Payable.ToString("0.##")}\n"
                                                     + $"Paid\t\t\t: {_sale.Paid.ToString("0.##")}\n"
                                                     + $"Due\t\t\t: {_sale.Due.ToString("0.##")}\n",
                                                       "Confirm",
                                                       MessageBoxButtons.YesNo);

                if (confirm != DialogResult.Yes)
                    return;

                try {
                    _sale = Connection[0].SaveSale(_sale);
                    SaleForm_Load(sender, e);
                }
                catch (Exception ex) {
                    MessageBox.Show($"Error occurred\n{ex.Message}", "Error");

                    return;
                }
            }

            _sale     = new Sale();
            _product  = new Product();
            _customer = new Customer();
            RefreshForm();
        }

    #region Sale Type
        private void RetailSaleRadio_CheckedChanged (object sender, EventArgs e) {
            _sale.Cart.Clear();
            RefreshAmounts();
        }

        private void WholeSaleRadio_CheckedChanged (object sender, EventArgs e) {
            _sale.Cart.Clear();
            RefreshAmounts();
        }
    #endregion

    #region Customer
        private void RefreshCustomers () {
            CustomerCombo.DataSource = null;
            CustomerCombo.DataSource = Customers;
        }

        private void CustomerCombo_SelectedIndexChanged (object sender, EventArgs e) {
            _customer = CustomerCombo.SelectedIndex > -1
                            ? Customers[CustomerCombo.SelectedIndex]
                            : new Customer();
            RefreshCustomerFields();
            RefreshAmounts();
        }

        private void RefreshCustomerFields () {
            CustomerNameText.Text = _customer.FullName;
            CompanyText.Text      = _customer.CompanyName;
            AddressText.Text      = _customer.Address;
            PreviousDueText.Text  = _customer.GetDebt;
        }

        private void CustomerResetButton_Click (object sender, EventArgs e) {
            CustomerCombo.SelectedIndex = -1;
            RefreshCustomerFields();
        }

        private void AddCustomerButton_Click (object sender, EventArgs e) {
            Form         form   = new CustomerInformationForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
                RefreshCustomers();
        }

        private void ViewCustomerButton_Click (object sender, EventArgs e) {
            if (CustomerCombo.SelectedIndex > -1) {
                foreach (Form form in Application.OpenForms)
                    if (form is CustomerForm) {
                        form.Show();
                        if (form.WindowState == FormWindowState.Minimized)
                            form.WindowState = FormWindowState.Normal;

                        return;
                    }

                Form s = new CustomerForm(Customers[CustomerCombo.SelectedIndex]);
                s.Show();
            }
        }
    #endregion

    #region Product
        private void RefreshProducts () {
            ProductSelectorCombo.DataSource = null;
            Products                        = Connection[0].GetProductsAll();
        }

        private void ProductSelectorCombo_SelectedIndexChanged (object sender, EventArgs e) {
            _product = ProductSelectorCombo.SelectedIndex > -1
                           ? _products[ProductSelectorCombo.SelectedIndex]
                           : new Product();
            RefreshProductFields();
        }

        private void RefreshProductFields () {
            AvailableQuantityText.Text = "S- " + _product.GetShopStock + " G- " + _product.GetGodownStock;
            SaleUnitPriceText.Text =
                UnitPriceText.Text = WholeSaleRadio.Checked
                                         ? _product.GetWholeSalePrice + $" Tk/{_product.DefaultUnitName}"
                                         : _product.GetRetailPrice + $" Tk/{_product.DefaultUnitName}";
            QuantityText.Text            = "";
            UnitSelectorCombo.DataSource = null;
            UnitSelectorCombo.DataSource = _product.Units;
            SaleNetPriceText.Text        = "";
        }

        private void UnitSelectorCombo_SelectedIndexChanged (object sender, EventArgs e) {
            int index = UnitSelectorCombo.SelectedIndex;

            if (index > -1) {
                SaleUnitPriceText.Text = WholeSaleRadio.Checked
                                             ? (_product.WholeSalePrice / (decimal) _product.Units[index].Weight)
                                             .ToString("0.##")
                                             : (_product.RetailPrice / (decimal) _product.Units[index].Weight)
                                             .ToString("0.##");
                if (float.TryParse(QuantityText.Text, out float q) && q > 0)
                    SaleNetPriceText.Text = (decimal.Parse(SaleUnitPriceText.Text) * (decimal) q).ToString("0.##");
                else
                    SaleNetPriceText.Text = "";
            }
            else {
                SaleUnitPriceText.Text = "";
                SaleNetPriceText.Text  = "";
            }
        }
    #endregion

    #region Cart
        private bool ProductValidation () {
            string error = String.Empty;

            if (ProductSelectorCombo.SelectedIndex < 0)
                error += "No product is selected. Please select a product properly.\n";
            if (UnitSelectorCombo.SelectedIndex < 0)
                error += "Unit is invalid. Please select a corresponding unit for the product\n";
            if (!float.TryParse(QuantityText.Text, out float q)
             || q < 0
             || _product.TotalStock < q * _product.Units[UnitSelectorCombo.SelectedIndex].Weight)
                error += "Quantity is more than available or invalid\n";
            if (!decimal.TryParse(SaleUnitPriceText.Text, out decimal up) || up < 0)
                error += "Selling unit price is invalid\n";
            if (!decimal.TryParse(SaleNetPriceText.Text, out decimal np) || np < 0)
                error += "Selling net price is invalid\n";
            if (_sale.Cart.Exists(sc => sc.ProductId == _product.ObjectId))
                error += "\nThis product already exists in the cart.\n" + "Remove the previous to add again\n";

            if (error.Length > 0) {
                MessageBox.Show("Following errors occurred adding the product to sell cart:\n" + error, "Information");

                return false;
            }

            return true;
        }

        private void AddToCartButton_Click (object sender, EventArgs e) {
            if (!RetailSaleRadio.Checked && !WholeSaleRadio.Checked) {
                MessageBox.Show("Select retail or whole sale", "Info");

                return;
            }

            if (!ProductValidation())
                return;

            ShoppingCart sc = new ShoppingCart {
                                                   ProductId   = _product.ObjectId,
                                                   ProductName = _product.ProductName,
                                                   UnitPrice   = decimal.Parse(SaleUnitPriceText.Text),
                                                   Unit        = _product.Units[UnitSelectorCombo.SelectedIndex],
                                                   UnitPurchasePrice =
                                                       _product.PurchasePriceByUnit(_product.Units[UnitSelectorCombo
                                                                                                       .SelectedIndex]),
                                                   Quantity = float.Parse(QuantityText.Text)
                                               };
            _sale.Cart.Add(sc);

            RefreshAmounts();
            _product = new Product();
            RefreshProductFields();
            SearchProductText.Focus();
        }

        private void RemoveSelectedButton_Click (object sender, EventArgs e) {
            foreach (DataGridViewRow row in CartDataGrid.SelectedRows)
                _sale.Cart.RemoveAt(row.Index);
            RefreshAmounts();
        }
    #endregion

    #region Amount Calculations
        private void RefreshAmounts () {
            CartDataGrid.DataSource          = null;
            CartDataGrid.AutoGenerateColumns = false;
            CartDataGrid.DataSource          = _sale.Cart;
            CartDataGrid.ClearSelection();

            _sale.TotalAmount = _sale.Cart.Sum(sc => sc.NetPrice);
            TotalText.Text    = _sale.GetTotalAmount;

            if (!LessAmountText.Focused)
                LessAmountText.Text = _sale.GetLess;
            if (!DiscountPercentageText.Focused)
                DiscountPercentageText.Text = _sale.GetDiscount;
            PreviousDueText.Text = _customer.GetDebt;
            PayableText.Text     = _sale.GetPayable;
            FullPayableText.Text = (_sale.Payable + _customer.Debt).ToString("0.##");
            if (!PaidAmountText.Focused)
                PaidAmountText.Text = _sale.GetPaid;
            DueText.Text = _sale.Due < 0
                               ? "0"
                               : _sale.GetDue;
            FullDueText.Text = (_sale.Payable + _customer.Debt - _sale.Paid).ToString("0.##");
        }

        private void QuantityText_TextChanged (object sender, EventArgs e) {
            if (float.TryParse(QuantityText.Text, out float q) && q > 0) {
                if (decimal.TryParse(SaleUnitPriceText.Text, out decimal up) && up > 0)
                    SaleNetPriceText.Text = ((decimal) q * up).ToString("0.##");
                else if (decimal.TryParse(SaleNetPriceText.Text, out decimal np) && np > 0)
                    SaleUnitPriceText.Text = (np / (decimal) q).ToString("0.##");
            }
        }

        private void SaleUnitPriceText_TextChanged (object sender, EventArgs e) {
            if (decimal.TryParse(SaleUnitPriceText.Text, out decimal up)
             && up > 0
             && float.TryParse(QuantityText.Text, out float q)
             && q > 0)
                SaleNetPriceText.Text = (up * (decimal) q).ToString("0.##");
        }

        private void SaleNetPriceText_TextChanged (object sender, EventArgs e) {
            if (decimal.TryParse(SaleNetPriceText.Text, out decimal np)
             && np >= 0
             && float.TryParse(QuantityText.Text, out float q)
             && q > 0
             && np % (decimal) q == 0)
                SaleUnitPriceText.Text = (np / (decimal) q).ToString("0.##");
        }

        private void SaleNetPriceText_Leave (object sender, EventArgs e) {
            if (decimal.TryParse(SaleNetPriceText.Text, out decimal np)
             && np >= 0
             && float.TryParse(QuantityText.Text, out float q)
             && q > 0)
                SaleUnitPriceText.Text = (np / (decimal) q).ToString("0.##");
        }

        private void DiscountPercentageText_TextChanged (object sender, EventArgs e) {
            if (!float.TryParse(DiscountPercentageText.Text, out float dp) || !(dp >= 0) || !(dp <= 100)) return;

            _sale.Discount = dp;
            RefreshAmounts();
        }

        private void LessAmountText_TextChanged (object sender, EventArgs e) {
            if (!decimal.TryParse(LessAmountText.Text, out decimal l) || l < 0 || l > _sale.TotalAmount) return;

            _sale.Less = l;
            RefreshAmounts();
        }

        private void PaidAmountText_TextChanged (object sender, EventArgs e) {
            if (decimal.TryParse(PaidAmountText.Text, out decimal p) && p >= 0) {
                _sale.Paid = p;
                DueText.Text = _sale.Due < 0
                                   ? "0"
                                   : _sale.GetDue;
                FullDueText.Text = (_customer.Debt + _sale.Payable - p).ToString("0.##");
            }
        }
    #endregion

    #region Drafts
        private void RefreshSavedMemoList () {
            SavedMemoList.DataSource = null;
            _drafts                  = Connection[0].GetSavedSaleAll();
            SavedMemoList.DataSource = _drafts;
        }

        private void LoadSavedMemoButton_Click (object sender, EventArgs e) {
            if (SavedMemoList.SelectedIndex > -1) {
                _sale = _drafts[SavedMemoList.SelectedIndex];
                RefreshForm();
            }
            else
                MessageBox.Show("Invalid selection", "Error");
        }

        private void RemoveSavedMemoButton_Click (object sender, EventArgs e) {
            if (SavedMemoList.SelectedIndex > -1) {
                Connection[0].DeleteSavedSale(_drafts[SavedMemoList.SelectedIndex]);

                _drafts.RemoveAt(SavedMemoList.SelectedIndex);
                SavedMemoList.DataSource = null;
                SavedMemoList.DataSource = _drafts;
            }
        }
    #endregion

        private void ReloadButton_Click (object sender, EventArgs e) {
            Customers = Connection[0].GetCustomersAll();
            Shops     = Connection[0].GetShopsAll();
            WireUp();
        }

        private void SearchProductText_TextChanged (object sender, EventArgs e) {
            string text = SearchProductText.Text;

            ProductSelectorCombo.DataSource = null;

            if (text.Length == 0)
                _products = _shopProducts;
            else {
                text = text.ToLowerInvariant();

                if (text.Length > 0) {
                    string[] tokens = text.Split();
                    if (tokens.Length == 1 && text.Substring(0, 1).ToLowerInvariant() == "p")
                        _products = _shopProducts
                                    .Where(p => p.ProductId.ToLowerInvariant().Contains(text))
                                    .ToList();
                    else
                        _products = _shopProducts
                                    .Where(p =>
                                               p.ProductName.ToLowerInvariant().Contains(text)
                                            || p.Category.ToLowerInvariant().Contains(text)
                                            || p.Specification.ToLowerInvariant().Contains(text))
                                    .ToList();
                }
            }

            ProductSelectorCombo.DataSource = _products;
        }

    #region Key Downs
        private void CustomerCombo_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                CustomerNameText.Focus();
        }

        private void CustomerNameText_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                CompanyText.Focus();
        }

        private void CompanyText_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                AddressText.Focus();
        }

        private void AddressText_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                NotesText.Focus();
        }

        private void SearchProductText_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                ProductSelectorCombo.Focus();
        }

        private void RetailSaleRadio_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                SearchProductText.Focus();
        }

        private void ProductSelectorCombo_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                QuantityText.Focus();
        }

        private void QuantityText_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                SaleUnitPriceText.Focus();
        }

        private void SaleUnitPriceText_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                SaleNetPriceText.Focus();
        }

        private void SaleNetPriceText_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                AddToCartButton.Focus();
        }

        private void DiscountPercentageText_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                LessAmountText.Focus();
        }

        private void LessAmountText_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                PaidAmountText.Focus();
        }

        private void PaidAmountText_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                SubmitButton.Focus();
        }
    #endregion
    }
}
