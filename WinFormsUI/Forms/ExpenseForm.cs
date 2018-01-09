using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MongoDB.Bson;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;


namespace WinFormsUI.Forms {
    public partial class ExpenseForm : Form {
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

        private Expense _expense;

        #endregion
        public ExpenseForm() {
            InitializeComponent();
            _expense = new Expense();
        }

        public ExpenseForm(Expense expense) {
            InitializeComponent();
            _expense = expense;

            ProductInfoGroupBox.Enabled = false;
            SubmissionGroupBox.Enabled  = false;
        }

        private void ExpenseForm_Load(object sender, EventArgs e) {
            CartDataGrid.DataSource = null;
            CartDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CartDataGrid.AutoGenerateColumns = false;
            ResetForm();
        }

        private void ResetEntry()
        {
            ProductText.Text = "";
            UnitPriceText.Text = "";
            NetPriceText.Text = "";
            QuantityText.Text = "";
        }

        private void ResetForm() {
            ResetEntry();
            _expense = new Expense();
            LoadExpense();
            CartDataGrid.Refresh();
        }

        private void LoadExpense()
        {
            TotalText.Text = _expense.Cart.Sum(c => c.NetPurchasePrice).ToString("0.##") + " Tk";
            NotesText.Text = _expense.Note;
            CartDataGrid.DataSource = _expense.Cart;
        }

        private bool ValidateEntry()
        {
            string error = string.Empty;
            if (ProductText.Text.Length == 0)
                error += "Empty entry name\n";
            else if (_expense.Cart.Exists(sc => sc.ProductName == ProductText.Text))
                error += "Entry already exists in cart\n";
            if (!decimal.TryParse(UnitPriceText.Text, out decimal p) || p < 0)
                error += "Invalid unit price\n";
            if (!float.TryParse(QuantityText.Text, out float q) || p < 0)
                error += "Invalid quantity\n";
            if (!decimal.TryParse(NetPriceText.Text, out decimal n) || n < 0)
                error += "Invalid net price\n";

            if (error.Length > 0)
                MessageBox.Show("Following errors occured trying to add the entry to cart:\n" + error, "Error");
            else
                return true;
            return false;
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            if (!ValidateEntry())
                return;
            ShoppingCart sc = new ShoppingCart
            {
                ProductId = ObjectId.Empty,
                ProductName = ProductText.Text,
                UnitPurchasePrice = decimal.Parse(UnitPriceText.Text),
                Quantity = float.Parse(QuantityText.Text),
                Unit = new Unit("pcs", 1)
            };
            _expense.Cart.Add(sc);
            CartDataGrid.DataSource = null;
            CartDataGrid.DataSource = _expense.Cart;

            TotalText.Text = _expense.Cart.Sum(c => c.NetPurchasePrice).ToString("0.##") + " Tk";

            ResetEntry();
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            if (CartDataGrid.SelectedRows.Count > 0)
            {
                int index = CartDataGrid.SelectedRows[0].Index;
                _expense.Cart.RemoveAt(index);
                CartDataGrid.DataSource = null;
                CartDataGrid.DataSource = _expense.Cart;
                TotalText.Text          = _expense.Cart.Sum(c => c.NetPurchasePrice).ToString("0.##") + " Tk";
            }
        }

        private bool ValidateForm()
        {
            string error = string.Empty;
            string warning = string.Empty;

            if (NotesText.Text.Length == 0)
                warning += "Note not added\n";
            if (_expense.Cart.Count == 0)
                error += "Cart is empty\n";
            if (ExpenseDateTime.Value > DateTime.Now)
                error += "Invalid time\n";

            if (warning.Length > 0 || error.Length > 0)
            {
                DialogResult result = MessageBox.Show("The following errors occurred during validation:\n" + error +
                    "\nThe following warnings should be considered:\n" + warning +
                    "\nDo you want to ignore any warnings?", 
                    "Validation Error", 
                    MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes || error.Length > 0)
                    return false;
            }
            return true;
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            if (!ValidateForm())
                return;

            _expense.TotalAmount  = _expense.Cart.Sum(sc => sc.UnitPurchasePrice * (decimal)sc.Quantity);
            _expense.Note         = NotesText.Text;
            _expense.Meta.Created = ExpenseDateTime.Value;

            DialogResult result = MessageBox.Show("Are you sure want to save this expense record?",
                "Confirm",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _expense.Meta.Created = ExpenseDateTime.Value;
                _expense.Note = NotesText.Text;

                Connection[0].InsertExpense(_expense);
            }
            else
                return;
            ResetForm();
        }

        private void UnitPriceText_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(UnitPriceText.Text, out decimal p))
                UnitPriceText.Text = "";
        }

        private void QuantityText_Leave(object sender, EventArgs e) {
            if (float.TryParse(QuantityText.Text, out float q) && q > 0)
            {
                if (decimal.TryParse(UnitPriceText.Text, out decimal u) && u > 0)
                    NetPriceText.Text = (u * (decimal) q).ToString("0.##");
                else if (decimal.TryParse(NetPriceText.Text, out decimal n) && n > 0)
                    UnitPriceText.Text = (n / (decimal) q).ToString("0.##");
            }
            else
                QuantityText.Text = "";
        }

        private void NetPriceText_Leave(object sender, EventArgs e) {
            if (decimal.TryParse(NetPriceText.Text, out decimal n) && n > 0)
            {
                if (QuantityText.Text.Length == 0 && decimal.TryParse(UnitPriceText.Text, out decimal u) && u > 0)
                    QuantityText.Text = (n / u).ToString("0.##");
                else if (UnitPriceText.Text.Length == 0 && float.TryParse(QuantityText.Text, out float q) && q > 0)
                    UnitPriceText.Text = (n / (decimal) q).ToString("0.##");
                else if (QuantityText.Text.Length == 0 && UnitPriceText.Text.Length == 0)
                {
                    QuantityText.Text = "1";
                    UnitPriceText.Text = QuantityText.Text;
                }
            }
        }
    }
}