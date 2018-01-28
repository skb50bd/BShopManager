using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MongoDB.Bson;
using ShopLibrary.Models;
using ShopLibrary.Searcher;
using static ShopLibrary.Searcher.Search;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class ProductsForm : Form {
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

        private List<Product> _products = new List<Product>();
        public ProductsForm() {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e) {
            ProductsDataGrid.AutoGenerateColumns = false;
            UserRole role = CurrentUser.AccessLevel;
            if (role <= Admin) {
                DeleteProductButton.Enabled = true;
                AddProductButton.Enabled = true;
                EditUpdateButton.Enabled = true;
            } else if (role == AppUser) {
                DeleteProductButton.Enabled = false;
                EditUpdateButton.Enabled = true;
                AddProductButton.Enabled = true;
            } else {
                DeleteProductButton.Enabled = false;
                EditUpdateButton.Enabled = false;
                AddProductButton.Enabled = false;
            }
            PrintButton.Enabled = true;

            WireUp();
        }

        // REFRESHes the Form Data
        private void WireUp() {
            ShopSelectorCombo.DataSource = Shops;
            ProductsDataGrid.DataSource = _products;
            ShopSelectorCombo_SelectedIndexChanged(this, new EventArgs());
        }

        private void LowStockCheck_CheckedChanged(object sender, EventArgs e) => SearchProduct();

        private void SearchProduct() {
            ProductsDataGrid.DataSource = null;

            if (Shops.Count > 0) {
                _products = SearchProductsByShop(Shops[ShopSelectorCombo.SelectedIndex]);
                ProductsDataGrid.DataSource = null;
                ProductsDataGrid.DataSource = _products;
            }

            if (LowStockCheck.Checked)
                _products = _products.Where(p => p.StockIsLow).ToList();
            
            _products = SearchProductsByText(SearchProductText.Text, _products);
            ProductsDataGrid.DataSource = _products;
            ProductsDataGrid.ClearSelection();
        }

        private void DeleteProductButton_Click(object sender, EventArgs e) {
            DialogResult confirm = MessageBox.Show("Are you sure want to delete " +
                                                   $"{ ProductsDataGrid.SelectedRows.Count } " +
                                                   "products?\n" +
                                                   "The deletion is permanent",
                "Warning",
                MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in ProductsDataGrid.SelectedRows)
                Connection[0].DeleteProduct(_products[row.Index]);

            MessageBox.Show("Products deleted successfully", "Success");
            ShopSelectorCombo_SelectedIndexChanged(sender, e);
        }

        private void AddProductButton_Click(object sender, EventArgs e) {
            Form form = new ProductInformationForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
                ShopSelectorCombo_SelectedIndexChanged(sender, e);
        }

        private void EditUpdateButton_Click(object sender, EventArgs e) {
            if (_products.Count > 0) {
                Form form = new ProductInformationForm(_products[ProductsDataGrid.SelectedRows[0].Index]);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                    ShopSelectorCombo_SelectedIndexChanged(sender, e);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e) {
            // Todo - Handle the printing
        }

        private void ShopSelectorCombo_SelectedIndexChanged(object sender, EventArgs e) => SearchProduct();

        private void ReloadProducts_Click(object sender, EventArgs e) {
            Products = Connection[0].GetProductsAll();
            WireUp();
        }

        private void SearchProductText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchProduct();
        }
    }
}