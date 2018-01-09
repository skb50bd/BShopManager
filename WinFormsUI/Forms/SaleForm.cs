using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MongoDB.Bson;
using ShopLibrary.Models;
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
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MakeDraggable(object sender, MouseEventArgs e) {
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

        private Customer _customer = new Customer();
        private List<Category> _categories;
        private List<Product> _products;
        private List<Product> _shopProducts;
        private List<Sale> _drafts;
        private Product _product = new Product();
        private Sale _sale = new Sale();

        #endregion

        public SaleForm() {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e) {
            if (CurrentUser.AccessLevel > AppUser) {
                MessageBox.Show("Permission denied", "Error");
                Close();
            }

            ShopSelectorCombo.DataSource     = null;
            ShopSelectorCombo.DataSource     = Shops;
            NewDueText.Enabled               = false;
            PayableTextBox.Enabled           = false;
            UnitPriceText.Enabled            = false;
            AvailableQuantityText.Enabled    = false;
            CartDataGrid.AutoGenerateColumns = false;

            WireUp();

            CategoryResetButton_Click(sender, e);
            CustomerResetButton_Click(sender, e);
            ShopSelectorCombo.SelectedIndex = -1;
            RetailSaleRadio.Checked = false;
            WholeSaleRadio.Checked = false;
        }

        private void ResetForm() {
            CustomerCombo.SelectedIndex        = -1;
            CompanyText.Text                   = "";
            AddressText.Text                   = "";
            NotesText.Text                     = "";
            ProductSelectorCombo.SelectedIndex = -1;
            DiscountPercentageText.Text        = "0";
            LessAmountText.Text                = "0";
            PaidAmountText.Text                = "0";
            PayableTextBox.Text                = "0";
            NewDueText.Text                    = "0";
            TotalText.Text                     = "0 BDT";
            QuantityText.Text                  = "";
            SaleUnitPriceText.Text             = "";
            SaleNetPriceText.Text              = "";
            CartDataGrid.DataSource            = null;
            RetailSaleRadio.Enabled            = true;
            WholeSaleRadio.Enabled             = true;
        }

        private void WireUp() {
            RefreshCustomers();
            RefreshProducts();
            RefreshSavedMemoList();
            CategorySelectorCombo_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void ShopSelectorCombo_SelectedIndexChanged(object sender, EventArgs e) {
            if (ShopSelectorCombo.SelectedIndex > -1) {
                _shopProducts = Products.Where(p =>
                    p.ShopId == Shops[ShopSelectorCombo.SelectedIndex].ObjectId &&
                    p.ShopStock + p.GodownStock > 0).ToList();
                _categories = _shopProducts.Count > 0
                    ? Categories.Where(c => _shopProducts.Exists(p => p.Category == c.CategoryName))
                        .ToList()
                    : null;

            } else {
                _shopProducts = null;
                _categories = null;
            }
            CategorySelectorCombo.DataSource = _categories;
            CategorySelectorCombo.SelectedIndex = -1;
            CategorySelectorCombo_SelectedIndexChanged(sender, e);

            _sale.ShopId = ShopSelectorCombo.SelectedIndex > -1
                ? Shops[ShopSelectorCombo.SelectedIndex].ObjectId
                : ObjectId.Empty;
            _sale.Cart.Clear();
        }

        private bool ValidateForm() {
            string error = string.Empty;
            string warning = string.Empty;

            if (!RetailSaleRadio.Checked && !WholeSaleRadio.Checked) error += "Must select retail or whole sale\n";
            if (CustomerNameText.Text.Length == 0) error += "Customer name is empty\n";
            if (DiscountPercentageText.Text.Length == 0 ||
                LessAmountText.Text.Length == 0 ||
                PaidAmountText.Text.Length == 0)
                error += "Must input Cash Amounts\n";
            if (_sale.Cart.Count == 0)
                error += "No Items in the Cart\n";

            if (ShopSelectorCombo.SelectedIndex < 0)
                error += "Shop not selected\n";

            if (error.Length > 0) {
                MessageBox.Show("These errors occurred during validation:\n" + error, "Error");
                return false;
            }
            return true;
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            if (!ValidateForm())
                return;

            if (CustomerCombo.SelectedIndex > -1) {
                _sale.CustomerId = _customer.ObjectId;
            } else {
                if (_sale.Due > 0) {
                    DialogResult result = MessageBox.Show("Non-documented customers should not enjoy late payments\n" +
                                                          "Do you want to continue anyway?",
                        "Confirm",
                        MessageBoxButtons.YesNo);
                    if (result != DialogResult.Yes)
                        return;
                }
                _sale.CustomerId = ObjectId.Empty;
            }
            _sale.CustomerName = CustomerNameText.Text;
            _sale.CustomerCompany = CompanyText.Text;
            _sale.CustomerAddress = AddressText.Text;

            _sale.Note = NotesText.Text;

            _sale.SaleType = WholeSaleRadio.Checked
                ? SaleType.WholeSale
                : SaleType.RetailSale;

            _sale.DealTime = SaleDateTime.Value;

            if (sender as Button == SubmitButton) {
                DialogResult confirm = MessageBox.Show("Are you sure want to register this sale?\n" +
                                                       $"Customer Name\t\t: {_sale.CustomerName}\n" +
                                                       $"Customer Company\t: {_sale.CustomerCompany}\n" +
                                                       $"Products\t\t\t: {_sale.Cart.Count}\n" +
                                                       $"Payable\t\t\t: {_sale.Payable.ToString("0.##")}\n" +
                                                       $"Paid\t\t\t: {_sale.Paid.ToString("0.##")}\n" +
                                                       $"Due\t\t\t: {_sale.Due.ToString("0.##")}\n",
                    "Confirm",
                    MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes)
                    return;

                try {
                    _sale = Connection[0].InsertSale(_sale);
                    ReloadButton_Click(sender, e);
                    SaleForm_Load(sender, e);
                } catch (Exception ex) {
                    MessageBox.Show($"Error occurred\n{ex.Message}", "Error");
                    return;
                }
            } else {
                DialogResult confirm = MessageBox.Show("Are you sure want to save this sale?\n" +
                                                       $"Customer Name\t\t: {_sale.CustomerName}\n" +
                                                       $"Customer Company\t: {_sale.CustomerCompany}\n" +
                                                       $"Products\t\t\t: {_sale.Cart.Count}\n" +
                                                       $"Payable\t\t\t: {_sale.Payable.ToString("0.##")}\n" +
                                                       $"Paid\t\t\t: {_sale.Paid.ToString("0.##")}\n" +
                                                       $"Due\t\t\t: {_sale.Due.ToString("0.##")}\n",
                    "Confirm",
                    MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes)
                    return;
                try {
                    _sale = Connection[0].SaveSale(_sale);
                    SaleForm_Load(sender, e);
                } catch (Exception ex) {
                    MessageBox.Show($"Error occurred\n{ex.Message}", "Error");
                    return;
                }
            }
            ResetForm();
        }

        #region Sale Type

        private void RetailSaleRadio_CheckedChanged(object sender, EventArgs e) {
            WholeSaleRadio.Enabled = false;
            RetailSaleRadio.Enabled = false;
            //_sale.Cart.Clear();
        }

        private void WholeSaleRadio_CheckedChanged(object sender, EventArgs e) {
            RetailSaleRadio.Enabled = false;
            WholeSaleRadio.Enabled = false;
            //_sale.Cart.Clear();
        }

        #endregion

        #region Customer

        private void RefreshCustomers() {
            CustomerCombo.DataSource = null;
            CustomerCombo.DataSource = Customers;
        }

        private void CustomerCombo_SelectedIndexChanged(object sender, EventArgs e) {
            if (CustomerCombo.SelectedIndex > -1) {
                _customer = Customers[CustomerCombo.SelectedIndex];
                CustomerNameText.Text = _customer.FullName;
                CompanyText.Text = _customer.CompanyName;
                AddressText.Text = _customer.Address;
                CurrentDueText.Text = _customer.GetDebt + " Tk";
            } else {
                _customer = new Customer();
                CustomerNameText.Text = "";
                CompanyText.Text = "";
                AddressText.Text = "";
                CurrentDueText.Text = "0 Tk";
            }
        }

        private void CustomerResetButton_Click(object sender, EventArgs e) {
            CustomerCombo.SelectedIndex = -1;
            CustomerCombo_SelectedIndexChanged(sender, e);
        }

        private void AddCustomerButton_Click(object sender, EventArgs e) {
            Form form = new CustomerInformationForm();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK) {
                RefreshCustomers();
            }
        }


        private void ViewCustomerButton_Click(object sender, EventArgs e) {
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

        private void CustomerCombo_MouseDoubleClick(object sender, MouseEventArgs e) {
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

        private void RefreshProducts() {
            ProductSelectorCombo.DataSource = null;
            Products = Connection[0].GetProductsAll();
        }

        private void ProductSelectorCombo_SelectedIndexChanged(object sender, EventArgs e) {
            if (ProductSelectorCombo.SelectedIndex > -1) {
                _product = _products[ProductSelectorCombo.SelectedIndex];
                AvailableQuantityText.Text = "S- " + _product.GetShopStock + " G- " + _product.GetGodownStock;
                SaleUnitPriceText.Text =
                    UnitPriceText.Text = WholeSaleRadio.Checked
                        ? _product.GetWholeSalePrice + $" Tk/{_product.Units[0].UnitName}"
                        : _product.GetRetailPrice + $" Tk/{_product.Units[0].UnitName}";
                QuantityText.Text = "";
                UnitSelectorCombo.DataSource = null;
                UnitSelectorCombo.DataSource = _product.Units;
                SaleNetPriceText.Text = "";
            } else {
                AvailableQuantityText.Text = "";
                UnitPriceText.Text = "";
                SaleUnitPriceText.Text = "";
                SaleNetPriceText.Text = "";
                QuantityText.Text = "";
                UnitSelectorCombo.DataSource = null;
            }
        }


        private void UnitSelectorCombo_SelectedIndexChanged(object sender, EventArgs e) {
            int index = UnitSelectorCombo.SelectedIndex;
            if (index > -1) {
                SaleUnitPriceText.Text = WholeSaleRadio.Checked
                    ? (_product.WholeSalePrice / (decimal)_product.Units[index].Weight).ToString("0.##")
                    : (_product.RetailPrice / (decimal)_product.Units[index].Weight).ToString("0.##");
                if (float.TryParse(QuantityText.Text, out float q) && q > 0)
                    SaleNetPriceText.Text = (decimal.Parse(SaleUnitPriceText.Text) * (decimal)q).ToString("0.##");
                else
                    SaleNetPriceText.Text = "";
            } else {
                SaleUnitPriceText.Text = "";
                SaleNetPriceText.Text = "";
            }
        }


        #region Category and Specification

        private void CategoryResetButton_Click(object sender, EventArgs e) {
            CategorySelectorCombo.SelectedIndex = -1;
            CategorySelectorCombo_SelectedIndexChanged(sender, e);
        }

        private void CategorySelectorCombo_SelectedIndexChanged(object sender, EventArgs e) {
            SpecificationSelectorCombo.DataSource = null;
            if (CategorySelectorCombo.SelectedIndex > -1) {
                _products = _shopProducts.Where(p => p.Category == CategorySelectorCombo.Text).ToList();
                SpecificationSelectorCombo.DataSource = Categories
                    .FirstOrDefault(c => c.CategoryName == CategorySelectorCombo.Text).Specifications;
            } else {
                _products = _shopProducts;
            }
            SpecificationResetButton_Click(sender, e);
        }

        private void SpecificationResetButton_Click(object sender, EventArgs e) {
            SpecificationSelectorCombo.SelectedIndex = -1;
            SpecificationSelectorCombo_SelectedIndexChanged(sender, e);

        }

        private void SpecificationSelectorCombo_SelectedIndexChanged(object sender, EventArgs e) {
            if (SpecificationSelectorCombo.SelectedIndex > -1)
                _products = _shopProducts.Where(p => p.Category == CategorySelectorCombo.Text
                                                     && p.Specification == SpecificationSelectorCombo.Text).ToList();
            ProductSelectorCombo.DataSource = null;
            ProductSelectorCombo.DataSource = _products;
        }

        #endregion

        #endregion

        #region Cart

        private bool ProductValidation() {
            string error = String.Empty;

            if (ProductSelectorCombo.SelectedIndex < 0)
                error += "No product is selected. Please select a product properly.\n";
            if (UnitSelectorCombo.SelectedIndex < 0)
                error += "Unit is invalid. Please select a corresponding unit for the product\n";
            if (!float.TryParse(QuantityText.Text, out float q) || q < 0 ||
                _product.TotalStock < q * _product.Units[UnitSelectorCombo.SelectedIndex].Weight)
                error += "QuantityColumn is more than available or invalid\n";
            if (!decimal.TryParse(SaleUnitPriceText.Text, out decimal up) || up < 0)
                error += "Selling unit price is invalid\n";
            if (!decimal.TryParse(SaleNetPriceText.Text, out decimal np) || np < 0)
                error += "Selling net price is invalid\n";
            if (_sale.Cart.Exists(sc => sc.ProductId == _product.ObjectId))
                error += "\nThis product already exists in the cart.\n" +
                         "Remove the previous to add again\n";

            if (error.Length > 0) {
                MessageBox.Show("Following errors occurred adding the product to sell cart:\n" + error, "Information");
                return false;
            }
            return true;
        }

        private void AddToCartButton_Click(object sender, EventArgs e) {
            if (!ProductValidation())
                return;
            if (!RetailSaleRadio.Checked && !WholeSaleRadio.Checked) {
                MessageBox.Show("Select retail or whole sale", "Info");
                return;
            }

            ShoppingCart sc = new ShoppingCart {
                ProductId = _product.ObjectId,
                ProductName = _product.ProductName,
                UnitPrice = decimal.Parse(SaleUnitPriceText.Text),
                Unit = _product.Units[UnitSelectorCombo.SelectedIndex],
                UnitPurchasePrice = _product.PurchasePrice / (decimal)_product.Units[UnitSelectorCombo.SelectedIndex].Weight,
                Quantity = float.Parse(QuantityText.Text)
            };
            _sale.Cart.Add(sc);
            _sale.TotalAmount = _sale.Cart.Sum(c => c.NetPrice);
            ProductSelectorCombo.SelectedIndex = -1;
            UpdateFields();
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e) {
            if (CartDataGrid.CurrentCell.RowIndex > -1)
                _sale.Cart.RemoveAt(CartDataGrid.CurrentCell.RowIndex);
            UpdateFields();
        }

        #endregion

        #region Amount Calculations

        private void UpdateFields() {
            CartDataGrid.DataSource     = null;
            CartDataGrid.DataSource     = _sale.Cart;
            TotalText.Text              = _sale.GetTotalAmount;
            DiscountPercentageText.Text = _sale.GetDiscount;
            LessAmountText.Text         = _sale.GetLess;
            PayableTextBox.Text         = _sale.GetPayable;
            PaidAmountText.Text         = _sale.GetPaid;
            NewDueText.Text             = _sale.GetDue;
        }

        private void UpdateFields(object sender, EventArgs e)
        {
            if ((sender as TextBox) == DiscountPercentageText
                && float.TryParse(DiscountPercentageText.Text, out float dp) && dp >= 0 && dp <= 100
                && !decimal.TryParse(LessAmountText.Text, out decimal l))
                _sale.Less = _sale.TotalAmount * (decimal) dp / 100;
            UpdateFields();
        }

        #endregion

        #region Drafts

        private void LoadSale() {
            try {
                RetailSaleRadio.Checked = _sale.SaleType == SaleType.RetailSale;
                WholeSaleRadio.Checked = _sale.SaleType == SaleType.WholeSale;
                ShopSelectorCombo.SelectedIndex = Shops.FindIndex(s => s.ObjectId == _sale.ShopId);
                if (_sale.CustomerId != ObjectId.Empty)
                    CustomerCombo.SelectedIndex = Customers.FindIndex(c => c.ObjectId == _sale.CustomerId);
                CustomerNameText.Text = _sale.CustomerName;
                CompanyText.Text = _sale.CustomerCompany;
                AddressText.Text = _sale.CustomerAddress;
                NotesText.Text = _sale.Note;
                UpdateFields();
            } catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        private void RefreshSavedMemoList() {
            SavedMemoList.DataSource = null;
            _drafts = Connection[0].GetSavedSaleAll();
            SavedMemoList.DataSource = _drafts;
        }

        private void LoadSavedMemoButton_Click(object sender, EventArgs e) {
            if (SavedMemoList.SelectedIndex > -1) {
                _sale = _drafts[SavedMemoList.SelectedIndex];
                LoadSale();
            } else
                MessageBox.Show("Invalid selection", "Error");
        }

        private void RemoveSavedMemoButton_Click(object sender, EventArgs e) {
            if (SavedMemoList.SelectedIndex > -1) {
                Connection[0].DeleteSavedSale(_drafts[SavedMemoList.SelectedIndex]);

                _drafts.RemoveAt(SavedMemoList.SelectedIndex);
                SavedMemoList.DataSource = null;
                SavedMemoList.DataSource = _drafts;
            }
        }

        #endregion

        private void ReloadButton_Click(object sender, EventArgs e) {
            Customers = Connection[0].GetCustomersAll();
            Shops = Connection[0].GetShopsAll();
            Products = Connection[0].GetProductsAll();
            WireUp();
        }

        private void QuantityText_TextChanged(object sender, EventArgs e) {
            if (float.TryParse(QuantityText.Text, out float q)) {
                if (q > 0) {
                    if (decimal.TryParse(SaleUnitPriceText.Text, out decimal up) && up > 0)
                        SaleNetPriceText.Text = ((decimal)q * up).ToString("0.##");
                    else if (decimal.TryParse(SaleNetPriceText.Text, out decimal np) && np > 0)
                        SaleUnitPriceText.Text = (np / (decimal)q).ToString("0.##");
                } else if (q < 0)
                    QuantityText.Text = "0";
            } else
                QuantityText.Text = "";
        }

        private void SaleUnitPriceText_TextChanged(object sender, EventArgs e) {
            if (decimal.TryParse(SaleUnitPriceText.Text, out decimal up) && up > 0)
                if (float.TryParse(QuantityText.Text, out float q) && q > 0)
                    SaleNetPriceText.Text = (up * (decimal)q).ToString("0.##");
        }

        private void SaleNetPriceText_TextChanged(object sender, EventArgs e) {
            if (decimal.TryParse(SaleNetPriceText.Text, out decimal np) && np > 0)
                if (float.TryParse(QuantityText.Text, out float q) && q > 0)
                    SaleUnitPriceText.Text = (np / (decimal)q).ToString("0.##");
        }

        private void LessAmountText_TextChanged(object sender, EventArgs e) {
            if (decimal.TryParse(LessAmountText.Text, out decimal l) && l >= 0 && l <= _sale.TotalAmount) {
                _sale.Less = l;
            }
        }

        private void PaidAmountText_TextChanged(object sender, EventArgs e) {
            if (decimal.TryParse(PaidAmountText.Text, out decimal p) && p >= 0 && p <= _sale.Payable) {
                _sale.Paid = p;
                NewDueText.Text = _sale.GetDue;
            }
        }
    }
}