using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class CashForm : Form
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
        public CashForm()
        {
            InitializeComponent();
        }

        private void CashForm_Load(object sender, EventArgs e)
        {
            CurrentCash = Connection[0].GetCurrentCash();
            CashAmountLabel.Text = CurrentCash.GetCurrent + " Tk";
            AddAmountText.Text = "";
            RemoveAmountText.Text = "";
            NotesText.Text = "";
            InputGroupBox.Enabled = CurrentUser.AccessLevel <= Admin;

            decimal TotalAsset = Products.Sum(p => p.PurchasePrice * (decimal)(p.ShopStock + p.GodownStock));
            decimal TotalReceivables = Customers.Sum(c => c.Debt);
            decimal TotalPayables = Suppliers.Sum(s => s.Payable);

            CurrentStockAssetAmount.Text = TotalAsset.ToString("0.##") + " Tk";
            TotalPayablesAmount.Text = TotalPayables.ToString("0.##") + " Tk";
            TotalReceivablesAmount.Text = TotalReceivables.ToString("0.##") + " Tk";
        }

        private void AddAmountText_TextChanged(object sender, EventArgs e)
        {
            RemoveAmountText.Text = "";
        }

        private void RemoveAmountText_TextChanged(object sender, EventArgs e)
        {
            AddAmountText.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CashModification model = new CashModification
            {
                PreviousBalance = CurrentCash.Current,
                Note = NotesText.Text
            };

            if (decimal.TryParse(AddAmountText.Text, out decimal aAmount) && aAmount > 0)
                model.NewBalance = CurrentCash.Current + aAmount;
            else if (decimal.TryParse(RemoveAmountText.Text, out decimal rAmount) && rAmount > 0)
                model.NewBalance = CurrentCash.Current - rAmount;
            else
            {
                MessageBox.Show("Invalid input", "Error");
                return;
            }
            if (MessageBox.Show("Are you sure to make the following change to cash amount?\n" +
                                $"Previous balance : {CurrentCash.Current}\n" +
                                $"New balance      : {model.NewBalance}", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            model = Connection[0].InsertCashModification(model);
            CashForm_Load(sender, e);
        }
    }
}
