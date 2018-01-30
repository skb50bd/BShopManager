using ShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using MahApps.Metro.Controls;
using MongoDB.Bson;
using ShopLibrary.Output;
using WpfUI.UserControls;
using static ShopLibrary.Searcher.Search;
using static ShopLibrary.GlobalConfig;

namespace WpfUI.Forms {
    /// <summary>
    /// Interaction logic for MemoWindow.xaml
    /// </summary>
    public partial class MemoWindow : MetroWindow {
        public MemoWindow() {
            InitializeComponent();
        }

        #region Global Variables

        private List<Sale> _savedSales = new List<Sale>();
        private Customer _customer = new Customer();
        private Sale _sale = new Sale();
        private ShoppingCart _shoppingCart = new ShoppingCart();
        private Product _product = new Product();
        private List<Product> _shopProducts = new List<Product>();

        #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            WireUp();
            DealDateTime.Focus();
        }

        private void RefreshAll() {
            _sale = new Sale();
            _customer = new Customer();
            _shoppingCart = new ShoppingCart();
            _product = new Product();
            _shopProducts = new List<Product>();
            LoadSale();
        }

        private void LoadSale() {
            List<ShoppingCart> cart = _sale.Cart.ToList();
            try {
                RetailSaleRadio.IsChecked = _sale.SaleType == SaleType.RetailSale;
                WholeSaleRadio.IsChecked = _sale.SaleType == SaleType.WholeSale;
                DealDateTime.SelectedDate = _sale.DealTime;
                ShopCombo.SelectedIndex = Shops.FindIndex(s => s.ObjectId == _sale.ShopId);

                if (_sale.ShopId != ObjectId.Empty && ShopCombo.SelectedIndex == -1)
                    MessageBox.Show("Shop match not found");

                if (_sale.CustomerId != ObjectId.Empty)
                    CustomerCombo.SelectedIndex = Customers.FindIndex(c => c.ObjectId == _sale.CustomerId);

                if (_sale.CustomerId != ObjectId.Empty && CustomerCombo.SelectedIndex == -1)
                    MessageBox.Show("Customer match not found");

                NoteText.Text = _sale.Note;
                SetCustomerFields();
                SetProductFields();
                _sale.Cart = cart;
                SetAmountFields();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        private void WireDown() {
            //DealDateTime.SelectedDate = DateTime.Now;
            DealDateTime.SelectedDate = DateTime.Now;
            ShopCombo.ItemsSource = null;
            CustomerCombo.ItemsSource = null;
            ProductCombo.ItemsSource = null;
            SavedMemoList.ItemsSource = null;
        }

        private void WireUp() {
            //DealDateTime.SelectedDate = DateTime.Now;
            DealDateTime.SelectedDate = DateTime.Now;
            ShopCombo.ItemsSource = Shops;
            CustomerCombo.ItemsSource = Customers;
            ProductCombo.ItemsSource = null;
            FetchSavedSales();
            SavedMemoList.ItemsSource = _savedSales;
        }

        private void FetchSavedSales() {
            _savedSales = Connection[0].GetSavedSaleAll();
            SavedMemoList.ItemsSource = null;
            SavedMemoList.ItemsSource = _savedSales;
        }

        private void SetCustomerFields() {
            if (_customer != null && _customer.ObjectId != ObjectId.Empty) {
                if (Customers.Exists(c => c.ObjectId == _customer.ObjectId)) {
                    CustomerCombo.SelectedIndex = Customers.FindIndex(c => c.ObjectId == _customer.ObjectId);
                    CustomerNameText.Text = _customer.FullName;
                    CustomerCompanyText.Text = _customer.CompanyName;
                    CustomerAddressText.Text = _customer.Address;
                    PreviousDueText.Text = _customer.GetDebt;
                }
            }
            else {
                CustomerCombo.SelectedIndex = -1;
                CustomerNameText.Text = "";
                CustomerCompanyText.Text = "";
                CustomerAddressText.Text = "";
            }
        }

        private void SetProductFields() {
            int index = _shopProducts.FindIndex(p => p.ObjectId == _product?.ObjectId);
            if (index > -1) {
                ProductCombo.SelectedIndex = index;

                ProductStockText.Text = $"S: {_product.GetShopStock} | G: {_product.GetGodownStock}";
                QuantityText.Text = "";
                UnitCombo.ItemsSource = _product.Units;

                UnitCombo.SelectedIndex = 0;
                UnitPriceText.Text = WholeSaleRadio.IsChecked == true
                    ? _product.GetWholeSalePriceByUnit(_product.Units[UnitCombo.SelectedIndex])
                    : _product.GetRetailPriceByUnit(_product.Units[UnitCombo.SelectedIndex]);
                NetPriceText.Text = float.TryParse(QuantityText.Text, out float q)
                                    && decimal.TryParse(UnitPriceText.Text, out decimal up)
                    ? (up * (decimal)q).ToString("0.##")
                    : "";
                _shoppingCart = new ShoppingCart {
                    ProductId = _product.ObjectId,
                    ProductName = _product.ProductName,
                    Unit = _product.Units[0],
                    UnitPrice = decimal.TryParse(UnitPriceText.Text, out decimal upp) ? upp : 0
                };
            }
            else {
                ProductStockText.Text = "S: 0 | G: 0";
                QuantityText.Text = "";
                UnitCombo.ItemsSource = null;
                UnitPriceText.Text = "";
                NetPriceText.Text = "";
                _shoppingCart = new ShoppingCart();
            }
        }

        private void SetAmountFields() {
            _sale.TotalAmount = _sale.Cart.Sum(sc => sc.NetPrice);
            CartGrid.ItemsSource = null;
            CartGrid.ItemsSource = _sale.Cart;
            TotalAmountText.Text = _sale.GetTotalAmount;
            if (!LessAmountText.IsFocused)
                LessAmountText.Text = _sale.GetLess;
            if (!DiscountPercentageText.IsFocused)
                DiscountPercentageText.Text = _sale.GetDiscount;
            PreviousDueText.Text = _customer.GetDebt;
            PayableText.Text = _sale.GetPayable;
            FullPayableText.Text = (_sale.Payable + _customer.Debt).ToString("0.##");
            if (!PaidText.IsFocused)
                PaidText.Text = _sale.GetPaid;
            DueText.Text = _sale.Due < 0
                ? "0"
                : _sale.GetDue;
            FullDueText.Text = (_sale.Payable + _customer.Debt - _sale.Paid).ToString("0.##");
        }

        private bool ValidateProduct() {
            string error = string.Empty;

            if (RetailSaleRadio.IsChecked != true && WholeSaleRadio.IsChecked != true)
                error += "Must select sale-type first\n";

            if (_product == null || _product == new Product())
                error += "No product selected.\n";

            if (!float.TryParse(QuantityText.Text, out float q) || q < 0)
                error += "Invalid product quantity\n";

            if (!decimal.TryParse(UnitPriceText.Text, out decimal up) || up < 0)
                error += "Unit price is invalid\n";

            if (UnitCombo.SelectedIndex < 0)
                error += "Invalid unit selected";

            if (_sale.Cart.Exists(sc => sc.ProductId == _product.ObjectId)) {
                MessageBoxResult result = MessageBox.Show("Same product exists in the cart.\n" +
                                                          "Replace the existing product in the cart?", "Conflict",
                    MessageBoxButton.YesNo);
                if (result != MessageBoxResult.Yes)
                    error += "Same product already exists in the cart\n";
            }

            if (error.Length > 0) {
                _shoppingCart = new ShoppingCart();
                MessageBox.Show(error, "Error");
                return false;
            }

            _shoppingCart = new ShoppingCart {
                ProductName = _product.ProductName,
                ProductId = _product.ObjectId,
                Quantity = q,
                Unit = _product.Units[UnitCombo.SelectedIndex],
                UnitPrice = up,
                UnitPurchasePrice = _product.PurchasePriceByUnit(_product.Units[UnitCombo.SelectedIndex])
            };
            return true;
        }

        
        private void CustomerNameText_OnGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e) {
            if (CustomerNameText.Text == "Cash Sale")
                CustomerNameText.Text = "";
        }

        private void DealDateTime_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter)
                ShopCombo.Focus();
        }

        private void ShopCombo_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter)
                RetailSaleRadio.Focus();
        }

        private void SaleTypeRadio_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter)
                CustomerCombo.Focus();
        }

        private void CustomerNameText_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter)
                CustomerCompanyText.Focus();
        }

        private void CustomerCompanyText_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter)
                CustomerAddressText.Focus();
        }

        private void CustomerAddressText_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter)
                ProductCombo.Focus();
        }

        private void NoteText_OnKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter)
                SaleButton.Focus();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            //if (e.ChangedButton == MouseButton.Left)
            //    this.DragMove();
        }

        private void ResetCustomerButton_Click(object sender, RoutedEventArgs e) {
            _customer = new Customer();
            SetCustomerFields();
        }

        private void ShopCombo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
            ProductCombo.ItemsSource = null;
            ProductCombo.Text = "";

            int index = ShopCombo.SelectedIndex;
            if (index == -1) {
                _sale.ShopId = ObjectId.Empty;
                _shopProducts = new List<Product>();
            }
            else {
                _sale.ShopId = Shops[index].ObjectId;
                _shopProducts = Task.Factory.StartNew(() => Products.Where(p => p.ShopId == _sale.ShopId).ToList())
                    .Result;
            }
            _sale.Cart.Clear();
            SetAmountFields();
            ProductCombo.ItemsSource = _shopProducts;
        }

        private void AddCustomerButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Feature under development");
        }

        private void ViewCustomerButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Feature under development");
        }

        private void SetProductPriceFields() {
            if (_shoppingCart != null && _shoppingCart.ProductId != ObjectId.Empty && _shoppingCart.Unit != null) {
                UnitPriceText.Text = _shoppingCart.GetUnitPrice;
                NetPriceText.Text = _shoppingCart.GetNetPrice;
            }
        }

        private void UnitCombo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
            int index = UnitCombo.SelectedIndex;
            if (_product != null && _product.ObjectId != ObjectId.Empty && index > -1)
                _shoppingCart.Unit = _product.Units[index];
            SetProductPriceFields();
        }

        private void ProductCombo_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                _product = SearchSingleProductByText(ProductCombo.Text, _shopProducts);
                if (_product != null && _product.ObjectId != ObjectId.Empty)
                    QuantityText.Focus();
                SetProductFields();
            }
        }

        private void ProductCombo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
            int index = ProductCombo.SelectedIndex;
            if (index == -1) {
                _product = new Product();
            }
            else {
                _product = _shopProducts[index];
            }
            SetProductFields();
        }

        private void CustomerCombo_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                _customer = SearchSingleCustomerByText(CustomerCombo.Text);
                if (_customer != null && _customer.ObjectId != ObjectId.Empty)
                    ProductCombo.Focus();
                else
                    CustomerNameText.Focus();
                SetCustomerFields();
            }
        }

        private void CustomerCombo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
            int index = CustomerCombo.SelectedIndex;
            if (index == -1)
                _customer = new Customer();
            else
                _customer = Customers[index];
            SetCustomerFields();
            SetAmountFields();
        }

        private void QuantityText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) {
            if (QuantityText.Text.Length == 0)
                return;
            if (float.TryParse(QuantityText.Text, out float q) && q > 0)
                _shoppingCart.Quantity = q;
            SetProductPriceFields();
        }

        private void QuantityText_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                if (QuantityText.Text.Length > 0
                    && float.TryParse(QuantityText.Text, out float q) && q > 0) {
                    if (q <= _product.TotalStock)
                        UnitPriceText.Focus();
                    else
                        MessageBox.Show("Quantity more than available");
                }
                else {
                    MessageBox.Show("Invalid quantity");
                }
            }
        }

        private void UnitPriceText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) {
            if (UnitPriceText.Text.Length == 0)
                return;
            if (decimal.TryParse(UnitPriceText.Text, out decimal up) && up > 0)
                _shoppingCart.UnitPrice = up;
            SetProductPriceFields();
        }

        private void UnitPriceText_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                if (UnitPriceText.Text.Length > 0
                    && decimal.TryParse(UnitPriceText.Text, out decimal up) && up > 0) {
                    NetPriceText.Focus();
                }
                else {
                    MessageBox.Show("Invalid unit price");
                }
            }
        }

        private void NetPriceText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) {
            if (NetPriceText.Text.Length == 0)
                return;
            if (decimal.TryParse(NetPriceText.Text, out decimal np) && np > 0)
                _shoppingCart.NetPrice = np;
            if (_shoppingCart.NetPrice == np)
                SetProductPriceFields();
        }

        private void NetPriceText_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                if (NetPriceText.Text.Length > 0
                    && decimal.TryParse(NetPriceText.Text, out decimal np) && np > 0) {
                    AddToCartButton.Focus();
                }
                else {
                    MessageBox.Show("Invalid net price");
                }
            }
        }

        private void NetPriceText_LostFocus(object sender, RoutedEventArgs e) {
            if (decimal.TryParse(NetPriceText.Text, out decimal np) && np > 0)
                _shoppingCart.NetPrice = np;
            SetProductPriceFields();
        }

        private void AddToCartButton_Click(object sender, RoutedEventArgs e) {
            if (!ValidateProduct())
                return;
            ShoppingCart tempCart;
            if (_sale.Cart.Exists(sc => sc.ProductId == _product.ObjectId)) {
                tempCart = _sale.Cart.Find(sc => sc.ProductId == _product.ObjectId);
                _sale.Cart.Remove(tempCart);
            }

            _sale.Cart.Add(_shoppingCart);
            _product = new Product();
            SetProductFields();
            SetAmountFields();
            ProductCombo.Focus();
        }

        private void CartGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (CartGrid.SelectedIndex > -1 && _sale.Cart.Count > 0) {
                _sale.Cart.RemoveAt(CartGrid.SelectedIndex);
            }
            SetAmountFields();
        }

        private void RetailSaleRadio_Checked(object sender, RoutedEventArgs e) {
            _sale.Cart.Clear();
            _sale.SaleType = SaleType.RetailSale;
        }

        private void WholeSaleRadio_Checked(object sender, RoutedEventArgs e) {
            _sale.Cart.Clear();
            _sale.SaleType = SaleType.WholeSale;
        }

        private void DiscountPercentageText_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                LessAmountText.Focus();
                DiscountPercentageText_TextChanged(sender, null);
            }
        }

        private void LessAmountText_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                PaidText.Focus();
                LessAmountText_TextChanged(sender, null);
            }
        }

        private void PaidText_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                NoteText.Focus();
                PaidText_TextChanged(sender, null);
            }
        }

        private void DiscountPercentageText_TextChanged(object sender, TextChangedEventArgs e) {
            if (!float.TryParse(DiscountPercentageText.Text, out float dp) || !(dp >= 0) || !(dp <= 100)) return;
            _sale.Discount = dp;
            SetAmountFields();
        }

        private void LessAmountText_TextChanged(object sender, TextChangedEventArgs e) {
            if (!decimal.TryParse(LessAmountText.Text, out decimal l) || l < 0) return;
            _sale.Less = l;
            SetAmountFields();
        }

        private void PaidText_TextChanged(object sender, TextChangedEventArgs e) {
            if (decimal.TryParse(PaidText.Text, out decimal p) && p >= 0) {
                _sale.Paid = p;
                DueText.Text = _sale.Due < 0
                    ? "0"
                    : _sale.GetDue;
                FullDueText.Text = (_customer.Debt + _sale.Payable - p).ToString("0.##");
            }
        }

        private bool ValidateForm() {
            string error = string.Empty;

            if (ShopCombo.SelectedIndex < 0)
                error += "Shop not selected\n";
            if (RetailSaleRadio.IsChecked != true && WholeSaleRadio.IsChecked != true)
                error += "Must select retail or whole sale\n";
            if (CustomerNameText.Text.Length == 0)
                error += "Customer name is empty\n";
            if (LessAmountText.Text.Length == 0 ||
                PaidText.Text.Length == 0)
                error += "Must input Cash Amounts\n";
            if (_customer.Debt <= 0 && _sale.Cart.Count == 0)
                error += "No Items in the Cart\n";

            if (error.Length > 0) {
                MessageBox.Show("These errors occurred during validation:\n" + error, "Error");
                return false;
            }
            return true;
        }

        private void SaleButton_Click(object sender, RoutedEventArgs e) {
            if (!ValidateForm())
                return;

            _sale.CustomerName = CustomerNameText.Text;
            _sale.CustomerCompany = CustomerCompanyText.Text;
            _sale.CustomerAddress = CustomerAddressText.Text;
            _sale.Note = NoteText.Text;
            _sale.SaleType = WholeSaleRadio.IsChecked == true
                ? SaleType.WholeSale
                : SaleType.RetailSale;
            _sale.DealTime = DealDateTime.SelectedDate ?? DateTime.Now;

            if (CustomerCombo.SelectedIndex > -1) {
                _sale.CustomerId = _customer.ObjectId;
            }
            else {
                if (_sale.Due > 0) {
                    MessageBoxResult result = MessageBox.Show(
                        "Non-documented customers should not enjoy late payments\n" +
                        "Do you want to continue anyway?",
                        "Confirm",
                        MessageBoxButton.YesNo);
                    if (result != MessageBoxResult.Yes)
                        return;
                }
                _sale.CustomerId = ObjectId.Empty;
            }

            MessageBoxResult confirm = MessageBox.Show("Are you sure want to register this sale?\n" +
                                                       $"Customer Name\t\t: {_sale.CustomerName}\n" +
                                                       $"Customer Company\t: {_sale.CustomerCompany}\n" +
                                                       $"Products\t\t\t: {_sale.Cart.Count}\n" +
                                                       $"Payable\t\t\t: {_sale.Payable.ToString("0.##")}\n" +
                                                       $"Paid\t\t\t: {_sale.Paid.ToString("0.##")}\n" +
                                                       $"Due\t\t\t: {_sale.Due.ToString("0.##")}\n",
                "Confirm",
                MessageBoxButton.YesNo);
            if (confirm != MessageBoxResult.Yes)
                return;

            try {
                _sale = Connection[0].InsertSale(_sale);
                PrintSaleMemo.ToPdf(_sale, Shops[ShopCombo.SelectedIndex], _customer);

                RefreshAll();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error occurred\n{ex.Message}", "Error");
                return;
            }
        }

        private void SavedMemoList_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (SavedMemoList.SelectedIndex > -1 && _savedSales.Count > 0) {
                _sale = _savedSales[SavedMemoList.SelectedIndex];

                LoadSale();
            }
        }

        private void DeleteSavedMemoButton_Click(object sender, RoutedEventArgs e) {
            Connection[0].DeleteSavedSale(_savedSales[SavedMemoList.SelectedIndex]);
            FetchSavedSales();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (!ValidateForm())
                return;

            _sale.CustomerName = CustomerNameText.Text;
            _sale.CustomerCompany = CustomerCompanyText.Text;
            _sale.CustomerAddress = CustomerAddressText.Text;
            _sale.Note = NoteText.Text;
            _sale.SaleType = WholeSaleRadio.IsChecked == true
                ? SaleType.WholeSale
                : SaleType.RetailSale;
            _sale.DealTime = DealDateTime.SelectedDate ?? DateTime.Now;

            if (CustomerCombo.SelectedIndex > -1)
                _sale.CustomerId = _customer.ObjectId;
            else
                _sale.CustomerId = ObjectId.Empty;
            if (_sale.Due > 0 && _sale.CustomerId == ObjectId.Empty) {
                MessageBoxResult result = MessageBox.Show(
                    "Non-documented customers should not enjoy late payments\n" +
                    "Do you want to continue anyway?",
                    "Confirm",
                    MessageBoxButton.YesNo);
                if (result != MessageBoxResult.Yes)
                    return;
            }
            MessageBoxResult confirm = MessageBox.Show("Are you sure want to save this sale?\n" +
                                                   $"Customer Name\t\t: {_sale.CustomerName}\n" +
                                                   $"Customer Company\t: {_sale.CustomerCompany}\n" +
                                                   $"Products\t\t\t: {_sale.Cart.Count}\n" +
                                                   $"Payable\t\t\t: {_sale.Payable.ToString("0.##")}\n" +
                                                   $"Paid\t\t\t: {_sale.Paid.ToString("0.##")}\n" +
                                                   $"Due\t\t\t: {_sale.Due.ToString("0.##")}\n",
                "Confirm",
                MessageBoxButton.YesNo);
            if (confirm != MessageBoxResult.Yes)
                return;
            try {
                _sale = Connection[0].SaveSale(_sale);
                _sale = new Sale();
                _customer = new Customer();
                _product = new Product();
                Window_Loaded(sender, null);
            }
            catch (Exception ex) {
                MessageBox.Show($"Error occurred\n{ex.Message}", "Error");
                return;
            }
        }
    }
}
