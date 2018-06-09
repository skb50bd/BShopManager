using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class ReturnForm : Form
    {
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

        private void MakeDraggable(object sender, MouseEventArgs e)
        {
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
        private void NumericValueValidation(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if ((e.KeyChar < 0x30 || e.KeyChar > 0x39) && e.KeyChar != 0x8 && e.KeyChar != 0x2E && e.KeyChar != 0x2D)
            {
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

        private readonly ReturnType _returnType;
        private Sale _sale;
        private List<Sale> _sales;
        private Refund _refund = new Refund();
        private List<Purchase> _purchases;
        private Purchase _purchase;
        private PurchaseReturn _purchaseReturn = new PurchaseReturn();
        private ShoppingCart _cartItem;
        private List<ShoppingCart> _removedCarts;

        #endregion

        public ReturnForm()
        {
            InitializeComponent();
        }

        public ReturnForm(ReturnType returnType)
        {
            _returnType = returnType;
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            CartDataGrid.AutoGenerateColumns = false;
            if (CurrentUser.AccessLevel > AppUser)
            {
                MessageBox.Show("Access denied", "Error");
                Close();
            }
            if (_returnType == ReturnType.Refund)
            {
                ReceiptNumberLabel.Text = "Memo #";
                _refund = new Refund();
            }
            else if (_returnType == ReturnType.PurchaseReturn)
            {
                ReceiptNumberLabel.Text = "Vouchar #";
                TitleLabel.Text = "Purchase Return";
                _purchaseReturn = new PurchaseReturn();
            }
            CutAmountText.Text = "";
            CutPercentageText.Text = "";
            ReturnedAmountText.Text = "";
            NotesText.Text = "";

            LoadReceipts();
        }

        #region Receipt

        private void LoadReceipts()
        {
            switch (_returnType)
            {
                case ReturnType.Refund:
                    // Todo - make this async
                    _sales = Connection[0].GetSaleByDate(DateTime.Now.AddYears(-1), DateTime.Now);
                    ReceiptNumberCombo.DataSource =
                        _sales.Select(s => s.SaleId + " - " + s.DealTime.ToLocalTime().ToString()).ToList();
                    break;
                case ReturnType.PurchaseReturn:
                    // Todo - make this async
                    _purchases = Connection[0].GetPurchaseByDate(DateTime.Now.AddYears(-1), DateTime.Now);
                    ReceiptNumberCombo.DataSource = _purchases
                        .Select(p => p.PurchaseId + " - " + p.DealTime.ToLocalTime().ToString()).ToList();
                    break;
            }
        }

        private void ReceiptNumberCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductSelectorCombo.DataSource = null;

            var index = ReceiptNumberCombo.SelectedIndex;
            if (index > -1)
            {
                switch (_returnType)
                {
                    case ReturnType.Refund:
                        _refund = new Refund();
                        _sale = _sales[index];

                        var refunds = Connection[0].GetRefundBySale(_sale);
                        if (refunds.Count > 0)
                        {
                            MessageBox.Show("This sale already has a refund", "Information");

                            foreach (var cart in _sale.Cart)
                            {
                                cart.Quantity -= refunds.Sum(r =>
                                    r.Cart.Where(c => c.ProductId == cart.ProductId).Sum(c => c.Quantity));
                            }
                            _sale.Cart = _sale.Cart.Where(c => c.Quantity > 0).ToList();
                        }
                        ProductSelectorCombo.DataSource = _sale.Cart;
                        break;

                    case ReturnType.PurchaseReturn:
                        _purchaseReturn = new PurchaseReturn();
                        _purchase = _purchases[index];

                        var purchaseReturns = Connection[0].GetPurchaseReturnByPurchase(_purchase);
                        if (purchaseReturns.Count > 0)
                        {
                            MessageBox.Show("This purchase already has a purchase return", "Information");
                        }
                        foreach (var cart in _purchase.Cart)
                        {
                            cart.Quantity -= purchaseReturns.Sum(r =>
                                r.Cart.Where(c => c.ProductId == cart.ProductId).Sum(c => c.Quantity));
                        }
                        _purchase.Cart = _purchase.Cart.Where(c => c.Quantity > 0).ToList();
                        ProductSelectorCombo.DataSource = _purchase.Cart;
                        break;
                }
            }
            _removedCarts = new List<ShoppingCart>();
            ReloadCarts();
        }

        #endregion

        private void ProductSelectorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductSelectorCombo.SelectedIndex > -1)
            {

                if (_returnType == ReturnType.Refund)
                    _cartItem = _sale.Cart[ProductSelectorCombo.SelectedIndex];
                else
                    _cartItem = _purchase.Cart[ProductSelectorCombo.SelectedIndex];

                AvailableQuantityText.Text = $"of {_cartItem.GetQuantity} {_cartItem.GetUnitName}";
                QuantityText.Text = "";
                QuantityText.Enabled = true;
                AddButton.Enabled = true;
            }
            else
            {
                AvailableQuantityText.Text = "of QTY";
                QuantityText.Text = "";
                QuantityText.Enabled = false;
                AddButton.Enabled = false;
            }
        }

        private void ReloadCarts()
        {
            ProductSelectorCombo.DataSource = null;
            CartDataGrid.DataSource = null;
            if (_returnType == ReturnType.Refund)
            {
                _refund.PriceAmount             = _refund.Cart.Sum(sc => sc.NetPrice);
                TotalAmountTextLabel.Text       =_refund.GetPriceAmount + " Tk";
                ProductSelectorCombo.DataSource = _sale.Cart;
                CartDataGrid.DataSource         = _refund.Cart;
            }
            else if (_returnType == ReturnType.PurchaseReturn)
            {
                _purchaseReturn.PriceAmount     = _purchaseReturn.Cart.Sum(sc => sc.NetPurchasePrice);
                TotalAmountTextLabel.Text       = _purchaseReturn.GetPriceAmount + " Tk";
                ProductSelectorCombo.DataSource = _purchase.Cart;
                CartDataGrid.DataSource         = _purchaseReturn.Cart;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ReceiptNumberCombo.SelectedIndex == -1)
            {
                MessageBox.Show("No sale/purchase selected", "Error");
                return;
            }
            if (ProductSelectorCombo.SelectedIndex == -1)
            {
                MessageBox.Show("No product selected", "Error");
                return;
            }
            if (float.TryParse(QuantityText.Text, out var q) && q > 0 && q <= _cartItem.Quantity)
            {
                if (_returnType == ReturnType.Refund)
                {
                    _sale.Cart.Remove(_cartItem);
                    _removedCarts.Add(_cartItem);
                    _cartItem.Quantity = q;
                    _refund.Cart.Add(_cartItem);
                }
                else if (_returnType == ReturnType.PurchaseReturn)
                {
                    _purchase.Cart.Remove(_cartItem);
                    _removedCarts.Add(_cartItem);
                    _cartItem.Quantity = q;
                    _purchaseReturn.Cart.Add(_cartItem);
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity");
                return;
            }
            ReloadCarts();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nothing selected");
                return;
            }
            foreach (DataGridViewRow row in CartDataGrid.SelectedRows)
            {
                if (_returnType == ReturnType.Refund)
                {
                    var c = _refund.Cart[row.Index];
                    _refund.Cart.Remove(c);
                    _sale.Cart.Add(_removedCarts.Single(sc => sc.ProductId == c.ProductId));
                    _removedCarts.Remove(_removedCarts.Single(sc => sc.ProductId == c.ProductId));
                }
                else
                {
                    var c = _purchaseReturn.Cart[row.Index];
                    _purchaseReturn.Cart.Remove(c);
                    _purchase.Cart.Add(_removedCarts.Single(sc => sc.ProductId == c.ProductId));
                    _removedCarts.Remove(_removedCarts.Single(sc => sc.ProductId == c.ProductId));
                }
            }
            ReloadCarts();
        }

        private bool ValidateReturn()
        {
            var error = string.Empty;
            if (ReceiptNumberCombo.SelectedIndex < 0)
                error += "Invalid Memo/Vouchar selection\n";
            if (_refund.Cart.Count == 0 && _purchase.Cart.Count == 0)
                error += "Cart is empty\n";
            if (!(float.TryParse(CutPercentageText.Text, out var cp) || cp < 0 || cp > 100))
                error += "Invalid cut percentage\n";
            if (!(decimal.TryParse(CutAmountText.Text, out var ca) || ca < 0))
                error += "Invalid cut amount\n";
            if (error.Length == 0)
                return true;

            MessageBox.Show("Following errors occurred during validation:\n" + error, "Error");
            return false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!ValidateReturn())
                return;
            switch (_returnType) {
                case ReturnType.Refund: {
                    _refund.SaleId = _sale.ObjectId;
                    _refund.CustomerId = _sale.CustomerId;
                    _refund.PriceAmount = _refund.Cart.Sum(sc => sc.NetPrice);
                    _refund.RefundAmount = decimal.Parse(ReturnedAmountText.Text);
                    _refund.Note = NotesText.Text;

                    _refund = Connection[0].InsertRefund(_refund);
                    break;
                }

                case ReturnType.PurchaseReturn: {
                    _purchaseReturn.PurchaseId = _purchase.ObjectId;
                    _purchaseReturn.SupplierId = _purchase.SupplierId;
                    _purchaseReturn.PriceAmount =
                        _purchaseReturn.Cart.Sum(sc => sc.NetPurchasePrice);
                    _purchaseReturn.PurchaseReturnAmount = decimal.Parse(ReturnedAmountText.Text);
                    _purchaseReturn.Note = NotesText.Text;

                    _purchaseReturn = Connection[0].InsertPurchaseReturn(_purchaseReturn);
                    break;
                }
            }
            MessageBox.Show("Success");

            ReturnForm_Load(sender, e);
        }

        private void ViewReceiptButton_Click(object sender, EventArgs e)
        {
            switch (_returnType)
            {
                case ReturnType.Refund:
                    // Todo - Show Sale
                    break;
                case ReturnType.PurchaseReturn:
                    // Todo - Show Purchase
                    break;
            }
        }

        private void ResetReceiptButton_Click(object sender, EventArgs e)
        {
            ReceiptNumberCombo.SelectedIndex = -1;
        }

        private void CutPercentageText_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(CutPercentageText.Text, out var cp) || cp < 0 || cp > 100) return;
            switch (_returnType)
            {
                case ReturnType.Refund:
                    _refund.RefundAmount = _refund.PriceAmount - (_refund.PriceAmount * (decimal) cp / 100);
                    CutAmountText.Text = _refund.GetRefundCut; 
                    ReturnedAmountText.Text = _refund.GetRefundAmount;
                    break;
                case ReturnType.PurchaseReturn:
                    _purchaseReturn.PurchaseReturnAmount =
                        _purchaseReturn.PriceAmount - (_purchaseReturn.PriceAmount * (decimal) cp / 100);
                    CutAmountText.Text = _purchaseReturn.GetPurchaseReturnCut;
                    ReturnedAmountText.Text = _purchaseReturn.GetPurchasReturnAmount;
                    break;
                default:
                    break;
            }
        }

        private void CutAmountText_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(CutAmountText.Text, out var ca) || ca < 0) return;
            switch (_returnType)
            {
                case ReturnType.Refund:
                    _refund.RefundAmount = _refund.PriceAmount - ca;
                    CutPercentageText.Text = _refund.PriceAmount == 0
                        ? "0"
                        : (_refund.RefundCut * 100 / _refund.PriceAmount).ToString("0.##");
                    ReturnedAmountText.Text = _refund.GetRefundAmount;
                    break;
                case ReturnType.PurchaseReturn:
                    _purchaseReturn.PurchaseReturnAmount = _purchaseReturn.PriceAmount - ca;
                    CutPercentageText.Text = _purchaseReturn.PriceAmount == 0
                        ? "0"
                        : (_purchaseReturn.PurchaseReturnCut * 100 / _purchaseReturn.PriceAmount).ToString("0.##");
                    ReturnedAmountText.Text = _purchaseReturn.GetPurchasReturnAmount;
                    break;
            }
        }
    }
}