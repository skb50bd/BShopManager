using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class ProductInformationForm : Form {
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

        private string _mode;
        private Product _product;
        public ProductInformationForm() {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            _product = new Product();
            _mode = "new";
        }

        public ProductInformationForm(Product product) {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            _product = product;
            _mode = "update";
        }

        private void ProductInformation_Load(object sender, EventArgs e) {
            UnitsDataGrid.AutoGenerateColumns = false;
            ProductIdText.Enabled = false;
            TotalStockText.Enabled = false;

            UserRole role = CurrentUser.AccessLevel;
            if (role <= Admin) {
                ProductInformationGroupBox.Enabled = true;
                MoveProductsGroupBox.Enabled = _mode == "update";
                UnitsGroupBox.Enabled = true;
            } else if (role == AppUser) {
                ProductInformationGroupBox.Enabled = UnitsGroupBox.Enabled = (_mode == "new");
                MoveProductsGroupBox.Enabled = _mode == "update";
                UnitsGroupBox.Enabled = true;
            } else {
                ProductInformationGroupBox.Enabled = false;
                MoveProductsGroupBox.Enabled = false;
                UnitsGroupBox.Enabled = false;
            }

            WireUp();

            if (_mode                                      == "update") {
                TitleLabel.Text                            = _product.ProductName;
                ShopSelectorCombo.SelectedIndex            =
                    Shops.FindIndex(s => s.ObjectId == _product.ShopId);
                ProductIdText.Text                         = _product.ProductId;
                ProductNameText.Text                       = _product.ProductName;
                ManufacturerText.Text                      = _product.Manufacturer;
                StockInShopText.Text                       = _product.GetShopStock;
                StockInGodownText.Text                     = _product.GetGodownStock;
                TotalStockText.Text                        = _product.GetTotalStock;
                AlertAtText.Text                           = _product.GetAlertStock;
                PurchasePriceText.Text                     = _product.GetPurchasePrice;
                RetailPriceText.Text                       = _product.GetRetailPrice;
                WholeSalePriceText.Text                    = _product.GetWholeSalePrice;
                MrpText.Text                               = _product.GetMrp;
                AddedOnDateTime.Value                      = _product.Meta.Created;
                CategorySelectorCombo.SelectedIndex        =
                    Categories.FindIndex(c    => c.CategoryName == _product.Category);
                CategorySelectorCombo_SelectedIndexChanged(sender, e);
                int index = CategorySelectorCombo.SelectedIndex;
                SpecificationSelectorCombo.SelectedIndex   = Categories[index].Specifications
                        .FindIndex(s => s == _product.Specification);

                NotesText.Text = _product.Notes;
                UnitsDataGrid.DataSource = _product.Units;
            }
        }

        private void WireUp() {
            Categories = Connection[0].GetCategoryAll();

            ShopSelectorCombo.DataSource = null;
            ShopSelectorCombo.DataSource = Shops;
            CategorySelectorCombo.DataSource = null;
            CategorySelectorCombo.DataSource = Categories;
            UnitsDataGrid.DataSource = null;
            UnitsDataGrid.DataSource = _product.Units;
        }

        private void TotalStockUpdate(object sender, EventArgs e) {
            if (float.TryParse(StockInShopText.Text, out float s) && float.TryParse(StockInGodownText.Text, out float g))
                TotalStockText.Text = (s + g).ToString("0.##");
        }

        private bool ValidateForm() {
            string error = string.Empty;
            string warning = string.Empty;

            if (ShopSelectorCombo.SelectedIndex < 0)
                error += "Shop not selected\n";
            if (ProductNameText.Text.Length == 0)
                error += "Invalid product name\n";
            if ((_mode == "new" && Products.Exists(p => p.ProductName == ProductNameText.Text))
                || (_mode == "update" && Products.Exists(p => p.ProductName == ProductNameText.Text
                && p.ObjectId != _product.ObjectId)))
                error += "Duplicate product name\n";
            if (ManufacturerText.Text.Length == 0)
                warning += "Manufactuer name is empty\n";
            if (double.TryParse(StockInShopText.Text, out double sShop) && sShop < 0)
                error += "Invalid stock in shop\n";
            if (double.TryParse(StockInGodownText.Text, out double sGodown) && sGodown < 0)
                error += "Invalid stock in godown\n";
            if (double.TryParse(AlertAtText.Text, out double alertAt) && alertAt < 0)
                error += "Invalid alert stock\n";
            if (decimal.TryParse(PurchasePriceText.Text, out decimal pPrice) && pPrice < 0)
                error += "Invalid purchase price\n";
            if (decimal.TryParse(RetailPriceText.Text, out decimal rPrice) && rPrice < 0)
                error += "Invalid retail price\n";
            if (decimal.TryParse(WholeSalePriceText.Text, out decimal wsPrice) && wsPrice < 0)
                error += "Invalid whole sale price\n";
            if (decimal.TryParse(MrpText.Text, out decimal mrp) && mrp < 0)
                warning += "Invalid maximum retail price\n";
            if (CategorySelectorCombo.Text.Length == 0)
                warning += "No category selected\n";
            if (SpecificationSelectorCombo.Text.Length == 0)
                warning += "No specification selected\n";
            if (NotesText.Text.Length == 0)
                warning += "No notes entered\n";
            if (_product.Units.Count == 0)
                warning += "No units added\n";
            if (_product.Units.Count > 0 && _product.Units[0].Weight != 1.0)
                error += "First unit must have the weight of 1\n";

            //Insert Categories and Specifications if needed
            Category category;
            if (!Categories.Exists(c => c.CategoryName == CategorySelectorCombo.Text)) {
                category = new Category {
                    CategoryName = CategorySelectorCombo.Text,
                    Specifications = new List<string>() { SpecificationSelectorCombo.Text }
                };
                Connection[0].InsertCategory(category);
            } else if (!Categories[CategorySelectorCombo.SelectedIndex].Specifications
                .Exists(s => s == SpecificationSelectorCombo.Text)) {
                category = Categories[CategorySelectorCombo.SelectedIndex];
                category.Specifications.Add(SpecificationSelectorCombo.Text);
                Connection[0].UpdateCategory(category);
            }

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

        private void AddUnitButton_Click(object sender, EventArgs e) {
            if (UnitNameText.Text.Length == 0
                || (float.TryParse(WeightText.Text, out float w) && w <= 0)) {
                MessageBox.Show("Invalid unit name or weightage\n" +
                                "Weightage must be greater than 0.\n", "Information");
                return;
            }
            if (_product.Units.Count == 0)
                if (w != 1) {
                    MessageBox.Show("First unit's weightage has to be 1\n" +
                        "You can add other units with weightage > 0\n\n" +
                        "Example: \n" +
                        "Unit Name\tWeightage\n" +
                        "Box\t\t1\n" +
                        "Piece\t\t20\n" +
                        "Dozen\t\t1.67\n", "Information");
                    return;
                } else
                if (_product.Units.Exists(u => u.UnitName == UnitNameText.Text)) {
                    MessageBox.Show("Another unit with same name already exists", "Error");
                    return;
                }
            _product.Units.Add(new Unit(UnitNameText.Text, w));
            UnitsDataGrid.DataSource = null;
            UnitsDataGrid.DataSource = _product.Units;
        }

        private void MoveFromShopText_TextChanged(object sender, EventArgs e) => MoveFromGodownText.Text = "";

        private void MoveFromGodownText_TextChanged(object sender, EventArgs e) => MoveFromShopText.Text = "";

        private void MoveButton_Click(object sender, EventArgs e) {
            if (MoveFromGodownText.Text.Length != 0
                && float.TryParse(MoveFromGodownText.Text, out float s)) {
                if (_product.GodownStock >= s) {
                    _product.GodownStock -= s;
                    _product.ShopStock += s;
                } else {
                    MessageBox.Show("Moving more than available\n" +
                                    $"Available: {_product.GetGodownStock}\n" +
                                    $"Moving: {s}", "Error");
                    return;
                }
            } else if (MoveFromShopText.Text.Length != 0
                       && float.TryParse(MoveFromShopText.Text, out float g)) {
                if (_product.ShopStock >= g) {
                    _product.ShopStock -= g;
                    _product.GodownStock += g;
                } else {
                    MessageBox.Show("Moving more than available\n" +
                                    $"Available: {_product.GetShopStock}\n" +
                                    $"Moving: {g}", "Error");
                    return;
                }
            } else
                return;

            MoveFromGodownText.Text =
                MoveFromShopText.Text = "";
            Connection[0].UpdateProduct(_product);
            ProductInformation_Load(sender, e);
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateForm())
                return;

            _product.ShopId = Shops[ShopSelectorCombo.SelectedIndex].ObjectId;
            _product.ProductName = ProductNameText.Text;
            _product.Manufacturer = ManufacturerText.Text;
            _product.ShopStock = float.Parse(StockInShopText.Text);
            _product.GodownStock = float.Parse(StockInGodownText.Text);
            _product.AlertStock = float.Parse(AlertAtText.Text);
            _product.PurchasePrice = decimal.Parse(PurchasePriceText.Text);
            _product.RetailPrice = decimal.Parse(RetailPriceText.Text);
            _product.WholeSalePrice = decimal.Parse(WholeSalePriceText.Text);
            _product.Mrp = decimal.Parse(MrpText.Text);
            _product.Category = CategorySelectorCombo.Text;
            _product.Specification = SpecificationSelectorCombo.Text;
            _product.Notes = NotesText.Text;
            if (_product.Units.Count == 0)
                _product.Units.Add(new Unit("pcs", 1));
            if (_mode == "new") {
                _product.Meta.Created = AddedOnDateTime.Value;
                _product.Meta.Creator = CurrentUser.UserName;
                Connection[0].InsertProduct(_product);
            } else
                Connection[0].UpdateProduct(_product);

            DialogResult = DialogResult.OK;
        }

        private void DeleteUnitButton_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in UnitsDataGrid.SelectedRows)
                _product.Units.Remove(_product.Units[row.Index]);

            UnitsDataGrid.DataSource = null;
            UnitsDataGrid.DataSource = _product.Units;
        }

        private void CategorySelectorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecificationSelectorCombo.DataSource = null;
            if (CategorySelectorCombo.SelectedIndex > -1 && CategorySelectorCombo.SelectedIndex < Categories.Count)
                SpecificationSelectorCombo.DataSource =
                    Categories[CategorySelectorCombo.SelectedIndex].Specifications;
        }
    }
}
