using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.CSharp;
using ShopLibrary.Models;
using ShopLibrary.Output;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.ReportType;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class ReportsForm : Form {
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
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46) {
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

        private Report report = new Report();

        #endregion

        public ReportsForm() {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e) {
            ReportsGrid.AutoGenerateColumns = false;
            DeleteButton.Enabled            = CurrentUser.AccessLevel <= Admin;
            report.FromDate                 = DateTime.Today;
            FromDateTime.Value              = report.FromDate;
            report.ToDate                   = DateTime.Now;
            ToDateTime.Value                = report.ToDate;
        }

        private void FixColumns() {
            ReportsGrid.DataSource = null;
            ReportsGrid.Columns.Clear();

            switch (report.ReportType) {
                case Summary:
                    #region Summary Columns
                    // ID
                    DataGridViewColumn col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ICashFlow.Id),
                        Name = "Id"
                    };
                    ReportsGrid.Columns.Add(col);
                    
                    // Type
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ICashFlow.Type),
                        Name = "Type"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Amount
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ICashFlow.GetInFlow),
                        Name = "Amount (In)"
                    };
                    ReportsGrid.Columns.Add(col);
                    
                    // Created
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ICashFlow.TimeStamp),
                        Name = "Time"
                    };
                    ReportsGrid.Columns.Add(col);
                    #endregion
                    break;

                case BankAccountReport:
                case TransactionReport:
                    #region Transaction Columns
                    // Transaction ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Transaction.TransactionId),
                        Name = "Trs. Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Account ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Transaction.GetAccountId),
                        Name = "Ac. Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Account Name
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Transaction.BankAccountName),
                        Name = "Ac. Name"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Transaction Type
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Transaction.GetTransactionType),
                        Name = "Type"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Transaction Code
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Transaction.TransactionCode),
                        Name = "Trx Code"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Check Number
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Transaction.CheckNumber),
                        Name = "Check #"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Customer Id
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Transaction.GetCustomerId),
                        Name = "Customer Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Created
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Transaction.Created),
                        Name = "Time"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Creator
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Transaction.Creator),
                        Name = "Added by"
                    };
                    ReportsGrid.Columns.Add(col);
                    #endregion
                    break;

                case EmployeeReport:
                case PaymentReport:
                    #region Payment Columns
                    // Payment Id
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Payment.PaymentId),
                        Name = "Payment Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Employee Id
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Payment.GetEmployeeId),
                        Name = "Employee Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Amount
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Payment.GetAmount),
                        Name = "Amount"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Creator
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Payment.Creator),
                        Name = "Creator"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Created
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Payment.Created),
                        Name = "Created"
                    };
                    ReportsGrid.Columns.Add(col);
                    #endregion
                    break;

                case SaleReport:
                    #region Sale Columns
                    // Sale ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.SaleId),
                        Name = "Memo #"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Shop
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.GetShopId),
                        Name = "Shop Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Sale Type
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.SaleTypeInitial),
                        Name = "T"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Customer ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.GetCustomerId),
                        Name = "Cus. ID"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Customer Name
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.CustomerName),
                        Name = "Cus. Name"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Payable
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.GetPayable),
                        Name = "Payable"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Less
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.GetLess),
                        Name = "Less"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Due
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.GetPaid),
                        Name = "Paid"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Due
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.GetDue),
                        Name = "Due"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Profit
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.GetProfit),
                        Name = "Profit"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Time
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.GetDealTime),
                        Name = "Time"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Creator
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Sale.Creator),
                        Name = "Added by"
                    };
                    ReportsGrid.Columns.Add(col);
                    #endregion
                    break;

                case PurchaseReport:
                    #region Purchase Columns
                    // Purchase ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Purchase.PurchaseId),
                        Name = "Vouchar #"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Supplier ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Purchase.GetSupplierId),
                        Name = "Supplier ID"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Supplier Name
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Purchase.SupplierName),
                        Name = "Supplier Name"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Payable
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Purchase.GetPayable),
                        Name = "Payable"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Less
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Purchase.GetLess),
                        Name = "Less"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Due
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Purchase.GetDue),
                        Name = "Due"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Time
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Purchase.DealTime),
                        Name = "Time"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Creator
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Purchase.Created),
                        Name = "Added by"
                    };
                    ReportsGrid.Columns.Add(col);
                    #endregion
                    break;

                case ExpenseReport:
                    #region Expense Columns
                    // Expense ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Expense.ExpenseId),
                        Name = "ID"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Expense Title
                    col = new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = nameof(Expense.Title),
                        Name = "Subject"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Amount
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Expense.GetTotalAmount),
                        Name = "Amount"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Created
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Expense.Created),
                        Name = "Time"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Note
                    col = new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = nameof(Expense.Note),
                        Name = "Note"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Creator
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Expense.Creator),
                        Name = "Added by"
                    };
                    ReportsGrid.Columns.Add(col);
                    #endregion
                    break;

                case RefundReport:
                    #region Refund Columns
                    // Refund ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Refund.RefundId),
                        Name = "Refund Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Sale ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Refund.GetSaleId),
                        Name = "Sale Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Customer ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Refund.GetCustomerId),
                        Name = "Customer Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Amount
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Refund.GetPriceAmount),
                        Name = "Amount"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Refund Amount
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Refund.GetRefundAmount),
                        Name = "Refunded"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Cut
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Refund.GetRefundCut),
                        Name = "Cut"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Created
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ShopLibrary.Models.Refund.Created),
                        Name = "Time"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Creator
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ShopLibrary.Models.Refund.Creator),
                        Name = "Added by"
                    };
                    ReportsGrid.Columns.Add(col);
                    #endregion
                    break;

                case PurchaseReturnReport:
                    #region Purchase Return Columns
                    // Purchase Return ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(PurchaseReturn.PurchaseReturnId),
                        Name = "Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Purchase ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(PurchaseReturn.GetPurchaseId),
                        Name = "Purchase Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Supplier ID
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(PurchaseReturn.GetSupplierId),
                        Name = "Supplier Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Amount
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(PurchaseReturn.GetPriceAmount),
                        Name = "Amount"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Purchase Return Amount
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(PurchaseReturn.GetPurchasReturnAmount),
                        Name = "Refunded"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Cut
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(PurchaseReturn.GetPurchaseReturnCut),
                        Name = "Cut"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Created
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(PurchaseReturn.Created),
                        Name = "Time"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Creator
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(PurchaseReturn.Creator),
                        Name = "Added by"
                    };
                    ReportsGrid.Columns.Add(col);
                    #endregion
                    break;

                case DebtCollectionReport:
                    #region Debt Collection Columns
                    // Debt Collection Id
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(DebtCollection.DebtCollectionId),
                        Name = "D.C. Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Customer Id
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(DebtCollection.GetCustomerId),
                        Name = "Cus. Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Customer Name
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(DebtCollection.CustomerName),
                        Name = "Cus. Name"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Amount
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(DebtCollection.GetAmount),
                        Name = "Amount"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Created
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(DebtCollection.Created),
                        Name = "Created"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Creator
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(DebtCollection.Creator),
                        Name = "Creator"
                    };
                    ReportsGrid.Columns.Add(col);

                    #endregion
                    break;

                case RepaymentReport:
                    #region Repayment Columns
                    // Repayment Id
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Repayment.RepaymentId),
                        Name = "Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Supplier Id
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Repayment.GetSupplierId),
                        Name = "Sup. Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Supplier Name
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Repayment.SupplierName),
                        Name = "Supplier Name"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Amount
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Repayment.GetAmount),
                        Name = "Amount"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Creator
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Repayment.Creator),
                        Name = "Creator"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Created
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(Repayment.Created),
                        Name = "Created"
                    };
                    ReportsGrid.Columns.Add(col);

                    #endregion
                    break;

                case CustomerReport:
                    #region Customer Columns

                    // Id
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ICustomerReportable.Id),
                        Name = "Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Type
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ICustomerReportable.Type),
                        Name = "Type"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Amount
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ICustomerReportable.Amount),
                        Name = "Amount"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Profit
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ICustomerReportable.Profit),
                        Name = "Profit"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Due
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ICustomerReportable.Due),
                        Name = "Due"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Created
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ICustomerReportable.Created),
                        Name = "Added on"
                    };
                    ReportsGrid.Columns.Add(col);
                    // Creator
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ICustomerReportable.Creator),
                        Name = "Added by"
                    };
                    ReportsGrid.Columns.Add(col);

                    #endregion
                    break;

                case SupplierReport:
                    #region Supplier Columns
                    // Id
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ISupplierReportable.Id),
                        Name = "Id"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Type
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ISupplierReportable.Type),
                        Name = "Type"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Amount
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ISupplierReportable.Amount),
                        Name = "Amount"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Due
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ISupplierReportable.Due),
                        Name = "Due"
                    };
                    ReportsGrid.Columns.Add(col);

                    // Created
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ISupplierReportable.Created),
                        Name = "Added on"
                    };
                    ReportsGrid.Columns.Add(col);
                    // Creator
                    col = new DataGridViewTextBoxColumn {
                        DataPropertyName = nameof(ISupplierReportable.Creator),
                        Name = "Added by"
                    };
                    ReportsGrid.Columns.Add(col);
                    #endregion
                    break;
            }
        }

        private void RefreshForm() {
            Filter1Label.Enabled = true;
            Filter1Combo.Enabled = true;
            Filter2Label.Enabled = true;
            Filter2Combo.Enabled = true;
            ViewButton.Enabled = false;
            PrintButton.Enabled = true;

            #region Reset Filters
            Filter1Combo.DataSource = null;
            Filter1Combo.Items.Clear();
            Filter2Combo.DataSource = null;
            Filter2Combo.Items.Clear();
            ReportsGrid.DataSource = null;
            #endregion

            #region Fix The Combo-Box Label and Items
            switch (report.ReportType) {
                case Summary:
                    Filter1Label.Text       = "Shop";
                    Filter1Combo.DataSource = Shops;
                    Filter2Combo.Enabled    = false;
                    Filter2Label.Enabled    = false;
                    break;

                case BankAccountReport:
                case TransactionReport:
                    Filter1Label.Text = "Bank Account";
                    Filter1Combo.DataSource = BankAccounts;
                    Filter2Label.Text = "Transaction Type";
                    Filter2Combo.Items.AddRange(new object[] {
                        "All",
                        "Deposit",
                        "Withdrawal"});
                    break;

                case CustomerReport:
                    Filter1Label.Text = "Customer";
                    Filter1Combo.DataSource = Customers;
                    Filter2Label.Text = "Type";
                    Filter2Combo.Items.AddRange(new object[] {
                        "All",
                        "Sale",
                        "Due Collection",
                        "Refund"});
                    break;

                case DebtCollectionReport:
                    Filter1Label.Text = "Customer";
                    Filter1Combo.DataSource = Customers;
                    Filter2Label.Enabled = false;
                    Filter2Combo.Enabled = false;
                    break;

                case EmployeeReport:
                case PaymentReport:
                    Filter1Label.Text = "Employee";
                    Filter1Combo.DataSource = Employees;
                    Filter2Label.Enabled = false;
                    Filter2Combo.Enabled = false;
                    break;

                case ExpenseReport:
                    report.Expenses = (report as IExpenseReport).GetExpenses();
                    Filter1Label.Enabled = false;
                    Filter1Combo.Enabled = false;
                    Filter2Label.Enabled = false;
                    Filter2Label.Enabled = false;
                    LoadGrid();
                    return;

                case PurchaseReport:
                    Filter1Label.Text = "Supplier";
                    Filter1Combo.DataSource = Suppliers;
                    Filter2Label.Enabled = false;
                    Filter2Combo.Enabled = false;
                    break;

                case PurchaseReturnReport:
                    Filter1Label.Text = "Supplier";
                    Filter1Combo.DataSource = Suppliers;
                    Filter2Label.Enabled = false;
                    Filter2Combo.Enabled = false;
                    break;

                case RefundReport:
                    Filter1Label.Text = "Customer";
                    Filter1Combo.DataSource = Customers;
                    Filter2Label.Enabled = false;
                    Filter2Combo.Enabled = false;
                    break;

                case RepaymentReport:
                    Filter1Label.Text = "Supplier";
                    Filter1Combo.DataSource = Suppliers;
                    Filter2Label.Enabled = false;
                    Filter2Combo.Enabled = false;
                    break;

                case SaleReport:
                    Filter1Label.Text = "Shop";
                    Filter1Combo.DataSource = Shops;
                    Filter2Label.Text = "Customer";
                    Filter2Combo.DataSource = Customers;
                    break;

                case SupplierReport:
                    Filter1Label.Text = "Supplier";
                    Filter1Combo.DataSource = Suppliers;
                    Filter2Label.Text = "Type";
                    Filter2Combo.Items.AddRange(new object[] {
                        "All",
                        "Purchase",
                        "Repayment",
                        "Purchase Return"});
                    break;
            }
            #endregion

            Filter1Combo.SelectedIndex = -1;
        }

        private void ReportTypeSelectorCombo_SelectedIndexChanged(object sender, EventArgs e) {
            report.ReportType = (ReportType)ReportTypeSelectorCombo.SelectedIndex;
            RefreshForm();
        }

        private void Filter1Combo_SelectedIndexChanged(object sender, EventArgs e) {
            int index = Filter1Combo.SelectedIndex;
            bool isBlank = index < 0;

            if (index > -1) {
                switch (report.ReportType) {
                    case Summary:
                        report.Shop = Shops[index];
                        break;

                    case BankAccountReport:
                    case TransactionReport:
                        report.BankAccount = BankAccounts[index];
                        break;

                    case CustomerReport:
                        report.Customer = Customers[index];
                        break;

                    case DebtCollectionReport:
                        report.Customer = Customers[index];
                        break;

                    case EmployeeReport:
                    case PaymentReport:
                        report.Employee = Employees[index];
                        break;

                    case PurchaseReport:
                        report.Supplier = Suppliers[index];
                        break;

                    case PurchaseReturnReport:
                        report.Supplier = Suppliers[index];
                        break;

                    case RefundReport:
                        report.Customer = Customers[index];
                        break;

                    case RepaymentReport:
                        report.Supplier = Suppliers[index];
                        break;

                    case SaleReport:
                        report.Shop = Shops[index];
                        break;

                    case SupplierReport:
                        report.Supplier = Suppliers[index];
                        break;
                }
            } else if (index == -1) {
                switch (report.ReportType) {
                    case Summary:
                        report.Shop = new Shop();
                        break;

                    case BankAccountReport:
                        report.BankAccount = new BankAccount();
                        report.Transactions = new List<Transaction>();
                        break;

                    case CustomerReport:
                        report.CustomerReportables = new List<ICustomerReportable>();
                        report.Sales = new List<Sale>();
                        report.DebtCollections = new List<DebtCollection>();
                        report.Refunds = new List<Refund>();
                        break;

                    case DebtCollectionReport:
                        break;

                    case EmployeeReport:
                        report.Payments = new List<Payment>();
                        break;

                    case ExpenseReport:
                        break;

                    case PaymentReport:
                        break;

                    case PurchaseReport:
                        break;

                    case PurchaseReturnReport:
                        break;

                    case RefundReport:
                        break;

                    case RepaymentReport:
                        break;

                    case SaleReport:
                        if (index > -1)
                            report.Shop = Shops[index];
                        break;

                    case SupplierReport:
                        report.SupplierReportables = new List<ISupplierReportable>();
                        report.Purchases = new List<Purchase>();
                        report.Repayments = new List<Repayment>();
                        report.PurchaseReturns = new List<PurchaseReturn>();
                        break;

                    case TransactionReport:
                        break;
                }
            }
            Filter2Combo.SelectedIndex = -1;
            Filter2Combo.Enabled = !(isBlank
                            || report.ReportType == DebtCollectionReport
                            || report.ReportType == EmployeeReport
                            || report.ReportType == ExpenseReport
                            || report.ReportType == PaymentReport
                            || report.ReportType == PurchaseReport
                            || report.ReportType == RefundReport
                            || report.ReportType == RepaymentReport);
            LoadReport();
        }

        private void Filter2Combo_SelectedIndexChanged(object sender, EventArgs e) => LoadReport();

        private void LoadReport() {
            int index1 = Filter1Combo.SelectedIndex;
            int index2 = Filter2Combo.SelectedIndex;

            switch (report.ReportType) {
                case Summary:
                    if (index1 > -1)
                    {
                        report.Sales = (report as ISaleReport).GetSales()
                            .Where(s => s.ShopId == report.Shop.ObjectId)
                            .ToList();
                    }
                    else if (index1 == -1)
                    {
                        report.Sales = (report as ISaleReport).GetSales();
                    }
                    report.DebtCollections = (report as IDebtCollectionReport).GetDebtCollections();
                    report.Refunds         = (report as IRefundReport).GetRefunds();
                    report.Purchases       = (report as IPurchaseReport).GetPurchases();
                    report.Repayments      = (report as IRepaymentReport).GetRepayments();
                    report.PurchaseReturns = (report as IPurchaseReturnReport).GetPurchaseReturns();
                    report.Expenses        = (report as IExpenseReport).GetExpenses();
                    report.Transactions    = (report as ITransactionReport).GetTransactions();
                    report.Payments        = (report as IPaymentReport).GetPayments();
                    break;

                case BankAccountReport:
                case TransactionReport:
                    #region Bank Account & Transactions
                    if (index2 <= 0) {
                        if (index1 < 0) // All Bank Accounts
                            report.Transactions = (report as ITransactionReport)
                                .GetTransactions()
                                .ToList();
                        else // Bank Account Selected
                            report.Transactions = (report as IBankAccountReport)
                                .GetBankTransactions(report.BankAccount)
                                .ToList();
                    } else if (index2 > 0) {
                        if (index1 < 0) // All Bank Accounts
                            report.Transactions = (report as ITransactionReport)
                                .GetTransactions()
                                .Where(t => t.TransactionType == (TransactionType)index2).ToList();
                        else // Bank Account Selected
                            report.Transactions = (report as IBankAccountReport)
                                .GetBankTransactions(report.BankAccount)
                                .Where(t => t.TransactionType == (TransactionType)index2).ToList();
                    }
                    #endregion
                    break;

                case CustomerReport:
                    #region Customer 
                    if (index1 == -1)
                        break;

                    string text = Filter2Combo.Text;
                    report.Sales =
                        text == "" || text == "All" || text == "Sale"
                            ? (report as ICustomerReport).GetCustomerSales(report.Customer)
                            : new List<Sale>();
                    report.DebtCollections =
                        text == "" || text == "All" || text == "Due Collection"
                            ? (report as ICustomerReport).GetCustomerDebtCollections(report.Customer)
                            : new List<DebtCollection>();
                    report.Refunds =
                        text == "" || text == "All" || text == "Refund"
                            ? (report as ICustomerReport).GetCustomerRefunds(report.Customer)
                            : new List<Refund>();
                    #endregion
                    break;

                case DebtCollectionReport:
                    #region Debt Collection
                    if (index1 == -1) // Customer NOT selected // All Dues
                        report.DebtCollections = (report as IDebtCollectionReport).GetDebtCollections();
                    else if (index1 > -1) //Customer Selected
                        report.DebtCollections =
                            (report as ICustomerReport).GetCustomerDebtCollections(report.Customer);
                    break;
                #endregion

                case EmployeeReport:
                case PaymentReport:
                    #region Payment
                    if (index1 == -1) // Employee NOT Selected
                        report.Payments = (report as IPaymentReport).GetPayments();
                    else
                        report.Payments = (report as IEmployeeReport).GetEmployeePayments(report.Employee);
                    break;
                #endregion

                case ExpenseReport:
                    #region Expense
                    report.Expenses = (report as IExpenseReport).GetExpenses();
                    break;
                #endregion

                case PurchaseReport:
                    #region Purchase
                    if (index1 == -1) // Supplier NOT Selected
                        report.Purchases = (report as IPurchaseReport).GetPurchases();
                    else if (index1 > -1)
                        report.Purchases = (report as ISupplierReport).GetSupplierPurchases(report.Supplier);
                    break;
                #endregion

                case PurchaseReturnReport:
                    #region Purchase Return
                    if (index1 == -1) // Supplier NOT Selected
                        report.PurchaseReturns = (report as IPurchaseReturnReport).GetPurchaseReturns();
                    else if (index1 > -1) // Supplier Selected
                        report.PurchaseReturns =
                            (report as ISupplierReport).GetSupplierPurchaseReturns(report.Supplier);
                    break;
                #endregion

                case RefundReport:
                    #region Refund
                    if (index1 == -1) // Customer NOT Selected
                        report.Refunds = (report as IRefundReport).GetRefunds();
                    else if (index1 > -1) // Customer Selected
                        report.Refunds = (report as ICustomerReport).GetCustomerRefunds(report.Customer);
                    break;
                #endregion

                case RepaymentReport:
                    #region Repayment
                    if (index1 == -1) // Supplier NOT Selected
                        report.Repayments = (report as IRepaymentReport).GetRepayments();
                    else if (index1 > -1) // Supplier Selected
                        report.Repayments = (report as ISupplierReport).GetSupplierRepayments(report.Supplier);
                    break;
                #endregion

                case SaleReport:
                    #region Sale
                    if (index2 > -1) { // Customer Selected
                        report.Customer = Customers[index2];
                        if (index1 > -1) // Shop Selected
                            report.Sales = (report as ICustomerReport).GetCustomerSales(report.Customer)
                                .Where(s => s.ShopId == report.Shop.ObjectId)
                                .ToList();
                        else
                            report.Sales = (report as ICustomerReport).GetCustomerSales(report.Customer)
                                .ToList();
                    } else if (index2 == -1) { // No Customer Selected
                        if (index1 > -1) // Shop Selected
                            report.Sales = (report as ISaleReport).GetSales()
                                .Where(s => s.ShopId == report.Shop.ObjectId)
                                .ToList();
                        else
                            report.Sales = (report as ISaleReport).GetSales();
                    }
                    break;
                #endregion

                case SupplierReport:
                    #region Supplier
                    if (index1 == -1)
                        break;

                    text = Filter2Combo.Text;
                    report.Purchases =
                        text == "" || text == "All" || text == "Purchase"
                            ? (report as ISupplierReport).GetSupplierPurchases(report.Supplier)
                            : new List<Purchase>();
                    report.Repayments =
                        text == "" || text == "All" || text == "Repayment"
                            ? (report as ISupplierReport).GetSupplierRepayments(report.Supplier)
                            : new List<Repayment>();
                    report.PurchaseReturns =
                        text == "" || text == "All" || text == "Purchase Return"
                            ? (report as ISupplierReport).GetSupplierPurchaseReturns(report.Supplier)
                            : new List<PurchaseReturn>();
                    break;
                    #endregion
            }
            LoadGrid();
        }

        private void LoadGrid() {
            FixColumns();
            ReportsGrid.DataSource = null;
            switch (report.ReportType) {
                case Summary:
                    report.CashFlows.Clear();
                    report.CashFlows.AddRange(report.Sales);
                    report.CashFlows.AddRange(report.DebtCollections);
                    report.CashFlows.AddRange(report.Refunds);
                    report.CashFlows.AddRange(report.Purchases);
                    report.CashFlows.AddRange(report.Repayments);
                    report.CashFlows.AddRange(report.PurchaseReturns);
                    report.CashFlows.AddRange(report.Expenses);
                    report.CashFlows.AddRange(report.Transactions);
                    report.CashFlows.AddRange(report.Payments);

                    report.CashFlows.OrderByDescending(cf => cf.TimeStamp);

                    ReportsGrid.DataSource = report.CashFlows;
                    break;

                case BankAccountReport:
                case TransactionReport:
                    ReportsGrid.DataSource = report.Transactions;
                    break;

                case CustomerReport:
                    report.CustomerReportables.Clear();
                    report.CustomerReportables.AddRange(report.Sales);
                    report.CustomerReportables.AddRange(report.DebtCollections);
                    report.CustomerReportables.AddRange(report.Refunds);
                    report.CustomerReportables.OrderByDescending(r => r.TimeStamp);
                    ReportsGrid.DataSource = report.CustomerReportables;
                    break;

                case DebtCollectionReport:
                    ReportsGrid.DataSource = report.DebtCollections;
                    break;

                case EmployeeReport:
                case PaymentReport:
                    ReportsGrid.DataSource = report.Payments;
                    break;

                case ExpenseReport:
                    ReportsGrid.DataSource = report.Expenses;
                    break;

                case PurchaseReport:
                    ReportsGrid.DataSource = report.Purchases;
                    break;

                case PurchaseReturnReport:
                    ReportsGrid.DataSource = report.PurchaseReturns;
                    break;

                case RefundReport:
                    ReportsGrid.DataSource = report.Refunds;
                    break;

                case RepaymentReport:
                    ReportsGrid.DataSource = report.Repayments;
                    break;

                case SaleReport:
                    ReportsGrid.DataSource = report.Sales;
                    break;

                case SupplierReport:
                    report.SupplierReportables.Clear();
                    report.SupplierReportables.AddRange(report.Purchases);
                    report.SupplierReportables.AddRange(report.Repayments);
                    report.SupplierReportables.AddRange(report.PurchaseReturns);
                    report.SupplierReportables.OrderByDescending(r => r.TimeStamp);
                    ReportsGrid.DataSource = report.SupplierReportables;
                    break;
            }
            ReportsGrid.ClearSelection();
            LoadStats();
        }

        private void LoadStats() {
            #region Make The Fields Visible
            StatPropLabel1.Visible = true;
            StatPropText1.Visible = true;
            StatPropLabel2.Visible = true;
            StatPropText2.Visible = true;
            StatPropLabel3.Visible = true;
            StatPropText3.Visible = true;
            StatPropLabel4.Visible = true;
            StatPropText4.Visible = true;
            StatPropLabel5.Visible = true;
            StatPropText5.Visible = true;
            StatPropLabel6.Visible = true;
            StatPropText6.Visible = true;
            StatPropLabel7.Visible = true;
            StatPropText7.Visible = true;
            StatPropLabel8.Visible = true;
            StatPropText8.Visible = true;
            StatPropLabel9.Visible = true;
            StatPropText9.Visible = true;
            StatPropLabel10.Visible = true;
            StatPropText10.Visible = true;
            #endregion

            switch (report.ReportType) {
                case Summary:
                    #region Summary
                    StatPropLabel1.Text = "Inflow Count";
                    StatPropText1.Text = report.CashFlows.Count(c => c.InFlow > 0) + " entries";
                    StatPropLabel2.Text = "Inflow Amount";
                    StatPropText2.Text = report.CashFlows.Where(c => c.InFlow > 0).Sum(sc => sc.InFlow).ToString("0.##") + " Tk";
                    StatPropLabel3.Text = "Outflow Count";
                    StatPropText3.Text = report.CashFlows.Count(c => c.OutFlow > 0) + " entries";
                    StatPropLabel4.Text = "Outflow Amount";
                    StatPropText4.Text = report.CashFlows.Where(c => c.OutFlow > 0).Sum(sc => sc.OutFlow).ToString("0.##") + " Tk";
                    StatPropLabel5.Text = "Inflow - Outflow";
                    StatPropText5.Text = (report as ITransactionReport).WithdrawTotal.ToString("0.##") + " Tk";
                    StatPropLabel6.Text = "Deposit - Withdraw";
                    StatPropText6.Text = ((report as ITransactionReport).DepositTotal
                                          - (report as ITransactionReport).WithdrawTotal).ToString("0.##") + " Tk";

                    StatPropLabel7.Text = "Cash";
                        
                    StatPropText7.Text = (report.CashFlows.Sum(c => c.InFlow) -
                                          ((report as ITransactionReport).DepositTotal -
                                           (report as ITransactionReport).WithdrawTotal))
                                         .ToString("0.##") + " Tk";
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case BankAccountReport:
                case TransactionReport:
                    #region Bank Account & Transaction
                    StatPropLabel1.Text = "Total Transactions";
                    StatPropText1.Text = (report as ITransactionReport).NumberOfTransactions.ToString();
                    StatPropLabel2.Text = "Deposits";
                    StatPropText2.Text = (report as ITransactionReport).NumberOfDeposits.ToString();
                    StatPropLabel3.Text = "Deposit Amount";
                    StatPropText3.Text = (report as ITransactionReport).DepositTotal.ToString("0.##") + " Tk";
                    StatPropLabel4.Text = "Withdraws";
                    StatPropText4.Text = (report as ITransactionReport).NumberOfWithdraws.ToString();
                    StatPropLabel5.Text = "Withdraw Amount";
                    StatPropText5.Text = (report as ITransactionReport).WithdrawTotal.ToString("0.##") + " Tk";
                    StatPropLabel6.Text = "Deposit - Withdraw";
                    StatPropText6.Text = ((report as ITransactionReport).DepositTotal
                                          - (report as ITransactionReport).WithdrawTotal).ToString("0.##") + " Tk";
                    StatPropLabel7.Visible = false;
                    StatPropText7.Visible = false;
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case CustomerReport:
                    #region Customer
                    StatPropLabel1.Text = "Sales | Due Col. | Refund";
                    StatPropText1.Text = (report as ICustomerReport).NumberOfSales + " | " +
                                         (report as ICustomerReport).NumberOfDebtCollections + " | " +
                                         (report as ICustomerReport).NumberOfRefunds;
                    StatPropLabel2.Text = "Total Sale Amount";
                    StatPropText2.Text = (report as ICustomerReport).SalesPriceTotal.ToString("0.##") + " Tk";
                    StatPropLabel3.Text = "Total Paid";
                    StatPropText3.Text = (report as ICustomerReport).TotalPaid.ToString("0.##") + " Tk";
                    StatPropLabel4.Text = "Total Due";
                    StatPropText4.Text = (report as ICustomerReport).TotalDue.ToString("0.##") + " Tk";
                    StatPropLabel5.Text = "Profit";
                    StatPropText5.Text = (report as ICustomerReport).TotalProfit.ToString("0.##") + " Tk";
                    StatPropLabel6.Text = "Collected Due";
                    StatPropText6.Text = (report as ICustomerReport).TotalDebtCollection.ToString("0.##") + " Tk";
                    StatPropLabel7.Text = "Current Due";
                    StatPropText7.Text = (report as ICustomerReport).CurrentDue.ToString("0.##") + " Tk";
                    StatPropLabel8.Text = "Refund Amount";
                    StatPropText8.Text = (report as ICustomerReport).TotalRefund.ToString("0.##") + " Tk";
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case DebtCollectionReport:
                    #region Debt Collection
                    StatPropLabel1.Text = "Debt Collections";
                    StatPropText1.Text = (report as IDebtCollectionReport).NumberOfDebtCollections.ToString();
                    StatPropLabel2.Text = "Total Amount";
                    StatPropText2.Text = (report as IDebtCollectionReport).DebtCollectionTotal.ToString("0.##") + " Tk";
                    StatPropLabel3.Visible = false;
                    StatPropText3.Visible = false;
                    StatPropLabel4.Visible = false;
                    StatPropText4.Visible = false;
                    StatPropLabel5.Visible = false;
                    StatPropText5.Visible = false;
                    StatPropLabel6.Visible = false;
                    StatPropText6.Visible = false;
                    StatPropLabel7.Visible = false;
                    StatPropText7.Visible = false;
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case EmployeeReport:
                    #region Employee
                    StatPropLabel1.Text = "Employee";
                    StatPropText1.Text = (report as IEmployeeReport).Employee.EmployeeId + " - "
                                         + (report as IEmployeeReport).Employee.FullName;
                    StatPropLabel2.Text = "Designation";
                    StatPropText2.Text = (report as IEmployeeReport).Employee.Designation;
                    StatPropLabel3.Text = "Join Date";
                    StatPropText3.Text = (report as IEmployeeReport).JoinDate.ToLongDateString();
                    StatPropLabel4.Text = "Months Worked";
                    StatPropText4.Text = (report as IEmployeeReport).MonthsWorked + " months";
                    StatPropLabel5.Text = "Salary";
                    StatPropText5.Text = (report as IEmployeeReport).Employee.GetMonthlySalary + " Tk";
                    StatPropLabel6.Text = "Payments";
                    StatPropText6.Text = (report as IEmployeeReport).NumberOfPayments.ToString();
                    StatPropLabel7.Text = "Total Paid";
                    StatPropText7.Text = (report as IEmployeeReport).TotalPaid.ToString("0.##") + " Tk";
                    StatPropLabel8.Text = "Current Balance";
                    StatPropText8.Text = (report as IEmployeeReport).CurrentBalance.ToString("0.##") + " Tk";
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case ExpenseReport:
                    #region Expense
                    StatPropLabel1.Text = "Expenses";
                    StatPropText1.Text = (report as IExpenseReport).NumberOfExpenses.ToString();
                    StatPropLabel2.Text = "Total Expense";
                    StatPropText2.Text = (report as IExpenseReport).TotalExpense.ToString("0.##") + " Tk";
                    StatPropLabel3.Visible = false;
                    StatPropText3.Visible = false;
                    StatPropLabel4.Visible = false;
                    StatPropText4.Visible = false;
                    StatPropLabel5.Visible = false;
                    StatPropText5.Visible = false;
                    StatPropLabel6.Visible = false;
                    StatPropText6.Visible = false;
                    StatPropLabel7.Visible = false;
                    StatPropText7.Visible = false;
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case PaymentReport:
                    #region Payment
                    StatPropLabel1.Text = "Payments";
                    StatPropText1.Text = (report as IPaymentReport).NumberOfPayments.ToString();
                    StatPropLabel2.Text = "Total Salary Paid";
                    StatPropText2.Text = (report as IPaymentReport).TotalPaid.ToString("0.##") + " Tk";
                    StatPropLabel3.Visible = false;
                    StatPropText3.Visible = false;
                    StatPropLabel4.Visible = false;
                    StatPropText4.Visible = false;
                    StatPropLabel5.Visible = false;
                    StatPropText5.Visible = false;
                    StatPropLabel6.Visible = false;
                    StatPropText6.Visible = false;
                    StatPropLabel7.Visible = false;
                    StatPropText7.Visible = false;
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case PurchaseReport:
                    #region Purchase
                    StatPropLabel1.Text = "Purchases";
                    StatPropText1.Text = (report as IPurchaseReport).NumberOfPurchases.ToString();
                    StatPropLabel2.Text = "Total Amount";
                    StatPropText2.Text = (report as IPurchaseReport).PurchasePriceTotal.ToString("0.##") + " Tk";
                    StatPropLabel3.Text = "Total Paid";
                    StatPropText3.Text = (report as IPurchaseReport).TotalPaid.ToString("0.##") + " Tk";
                    StatPropLabel4.Text = "Total Due";
                    StatPropText4.Text = (report as IPurchaseReport).TotalRepayable.ToString("0.##") + " Tk";
                    StatPropLabel5.Visible = false;
                    StatPropText5.Visible = false;
                    StatPropLabel6.Visible = false;
                    StatPropText6.Visible = false;
                    StatPropLabel7.Visible = false;
                    StatPropText7.Visible = false;
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case PurchaseReturnReport:
                    #region Purchase Return
                    StatPropLabel1.Text = "Purchase Returns";
                    StatPropText1.Text = (report as IPurchaseReturnReport).NumberOfPurchaseReturns.ToString();
                    StatPropLabel2.Text = "Product Price";
                    StatPropText2.Text = (report as IPurchaseReturnReport).PriceAmountTotal.ToString("0.##") + " Tk";
                    StatPropLabel3.Text = "Deduced Amount";
                    StatPropText3.Text = (report as IPurchaseReturnReport).CutAmountTotal.ToString("0.##") + " Tk";
                    StatPropLabel4.Text = "Refund Amount";
                    StatPropText4.Text = (report as IPurchaseReturnReport).RefundAmountTotal.ToString("0.##") + " Tk";
                    StatPropLabel5.Visible = false;
                    StatPropText5.Visible = false;
                    StatPropLabel6.Visible = false;
                    StatPropText6.Visible = false;
                    StatPropLabel7.Visible = false;
                    StatPropText7.Visible = false;
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case RefundReport:
                    #region Refund
                    StatPropLabel1.Text = "Refunds";
                    StatPropText1.Text = (report as IRefundReport).NumberOfRefunds.ToString();
                    StatPropLabel2.Text = "Product Price";
                    StatPropText2.Text = (report as IRefundReport).PriceAmountTotal.ToString("0.##") + " Tk";
                    StatPropLabel3.Text = "Deduced Amount";
                    StatPropText3.Text = (report as IRefundReport).CutAmountTotal.ToString("0.##") + " Tk";
                    StatPropLabel4.Text = "Refund Amount";
                    StatPropText4.Text = (report as IRefundReport).RefundAmountTotal.ToString("0.##") + " Tk";
                    StatPropLabel5.Visible = false;
                    StatPropText5.Visible = false;
                    StatPropLabel6.Visible = false;
                    StatPropText6.Visible = false;
                    StatPropLabel7.Visible = false;
                    StatPropText7.Visible = false;
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case RepaymentReport:
                    #region Repayment
                    StatPropLabel1.Text = "Repayments";
                    StatPropText1.Text = (report as IRepaymentReport).NumberOfRepayments.ToString();
                    StatPropLabel2.Text = "Total Repaid";
                    StatPropText2.Text = (report as IRepaymentReport).TotalRepaid.ToString("0.##") + " Tk";
                    StatPropLabel3.Visible = false;
                    StatPropText3.Visible = false;
                    StatPropLabel4.Visible = false;
                    StatPropText4.Visible = false;
                    StatPropLabel5.Visible = false;
                    StatPropText5.Visible = false;
                    StatPropLabel6.Visible = false;
                    StatPropText6.Visible = false;
                    StatPropLabel7.Visible = false;
                    StatPropText7.Visible = false;
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case SaleReport:
                    #region Sale
                    StatPropLabel1.Text = "Number of sales";
                    StatPropText1.Text = $"{ (report as ISaleReport).NumberOfSales } " +
                                              $"(W: { (report as ISaleReport).NumberOfWholeSales } " +
                                              $"| R: { (report as ISaleReport).NumberOfRetailSales })";
                    StatPropLabel2.Text = "Purchase price";
                    StatPropText2.Text = (report as ISaleReport).PurchasePriceTotal.ToString("0.##") + " Tk";
                    StatPropLabel3.Text = "Selling price";
                    StatPropText3.Text = (report as ISaleReport).SalePriceTotal.ToString("0.##") + " Tk";
                    StatPropLabel4.Text = "Cash received";
                    StatPropText4.Text = (report as ISaleReport).TotalPaid.ToString("0.##") + " Tk";
                    StatPropLabel5.Text = "Total profit";
                    StatPropText5.Text = (report as ISaleReport).TotalProfit.ToString("0.##") + " Tk";
                    StatPropLabel6.Text = "Total due";
                    StatPropText6.Text = (report as ISaleReport).TotalDue.ToString("0.##") + " Tk";
                    StatPropLabel7.Visible = false;
                    StatPropText7.Visible = false;
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                case SupplierReport:
                    #region Supplier
                    StatPropLabel1.Text = "Prc. | Rep. | Prc. Rtn.";
                    StatPropText1.Text = (report as ISupplierReport).NumberOfPurchases + " | " +
                                         (report as ISupplierReport).NumberOfRepayments + " | " +
                                         (report as ISupplierReport).NumberOfPurchaseReturns;
                    StatPropLabel2.Text = "Total Purchase Amount";
                    StatPropText2.Text = (report as ISupplierReport).PurchasesPriceTotal.ToString("0.##") + " Tk";
                    StatPropLabel3.Text = "Total Paid";
                    StatPropText3.Text = (report as ISupplierReport).TotalPaid.ToString("0.##") + " Tk";
                    StatPropLabel4.Text = "Total Repayable";
                    StatPropText4.Text = (report as ISupplierReport).TotalRepayable.ToString("0.##") + " Tk";
                    StatPropLabel5.Text = "Total Repaid Amount";
                    StatPropText5.Text = (report as ISupplierReport).Repayments.Sum(r => r.Amount).ToString("0.##") + " Tk";
                    StatPropLabel6.Text = "Current Repayable";
                    StatPropText6.Text = (report as ISupplierReport).CurrentRepayable.ToString("0.##") + " Tk";
                    StatPropLabel7.Text = "Purchase Return Amount";
                    StatPropText7.Text = (report as ISupplierReport).PurchaseReturnPriceTotal.ToString("0.##") + " Tk";
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;

                default:
                    #region Hide all the Fields
                    StatPropLabel1.Visible = false;
                    StatPropText1.Visible = false;
                    StatPropLabel2.Visible = false;
                    StatPropText2.Visible = false;
                    StatPropLabel3.Visible = false;
                    StatPropText3.Visible = false;
                    StatPropLabel4.Visible = false;
                    StatPropText4.Visible = false;
                    StatPropLabel5.Visible = false;
                    StatPropText5.Visible = false;
                    StatPropLabel6.Visible = false;
                    StatPropText6.Visible = false;
                    StatPropLabel7.Visible = false;
                    StatPropText7.Visible = false;
                    StatPropLabel8.Visible = false;
                    StatPropText8.Visible = false;
                    StatPropLabel9.Visible = false;
                    StatPropText9.Visible = false;
                    StatPropLabel10.Visible = false;
                    StatPropText10.Visible = false;
                    #endregion
                    break;
            }
        }

        private void FromDateTime_ValueChanged(object sender, EventArgs e) {
            report.FromDate = FromDateTime.Value;
            ReportTypeSelectorCombo_SelectedIndexChanged(sender, e);
        }

        private void ToDateTime_ValueChanged(object sender, EventArgs e) {
            report.ToDate = ToDateTime.Value;
            ReportTypeSelectorCombo_SelectedIndexChanged(sender, e);
        }

        private void ViewButton_Click(object sender, EventArgs e) {
            int index = ReportsGrid.CurrentCell.RowIndex;
            if (index < 0) {
                MessageBox.Show("Report nothing selected", "");
                return;
            }
            switch (report.ReportType) {
                case Summary:
                    break;

                case BankAccountReport:
                case TransactionReport:
                    // Todo - Show Transaction
                    Transaction transaction = report.Transactions[index];
                    break;

                case CustomerReport:
                    // Todo - Show Sale / Debt Collection / Refund
                    ICustomerReportable customerReport = report.CustomerReportables[index];
                    string type = customerReport.Type;
                    Sale sale;
                    DebtCollection debtCollection;
                    Refund refund;
                    if (type.Contains("Sale"))
                        sale = report.Sales.Single(s => s.SaleId == customerReport.Id);
                    else if (type == "Due Col.")
                        debtCollection = report.DebtCollections.Single(dc => dc.DebtCollectionId == customerReport.Id);
                    else if (type == "Refund")
                        refund = report.Refunds.Single(r => r.RefundId == customerReport.Id);
                    break;

                case DebtCollectionReport:
                    // Todo - Show Debt Collection
                    debtCollection = report.DebtCollections[index];
                    break;

                case EmployeeReport:
                case PaymentReport:
                    // Todo - Show Payment
                    Payment payment = report.Payments[index];
                    break;

                case ExpenseReport:
                    // Todo - Show Expense
                    Expense expense = report.Expenses[index];
                    break;

                case PurchaseReport:
                    // Todo - Show Purchse
                    Purchase purchase = report.Purchases[index];
                    break;

                case PurchaseReturnReport:
                    // Todo - Show Purchse Return
                    PurchaseReturn purchaseReturn = report.PurchaseReturns[index];
                    break;

                case RefundReport:
                    // Todo - Show Refund
                    refund = report.Refunds[index];
                    break;

                case RepaymentReport:
                    // Todo - Show Repayment
                    Repayment repayment = report.Repayments[index];
                    break;

                case SaleReport:
                    sale = report.Sales[index];
                    string outfilename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                                         + @"\Brotal\" + sale.SaleId + ".pdf";
                    if (!File.Exists(outfilename))
                    {
                        Customer _customer = new Customer();
                        if (Customers.Exists(c => c.ObjectId == sale.CustomerId))
                            _customer = Customers.SingleOrDefault(c => c.ObjectId == sale.CustomerId);
                        Memo memo = Connection[0].GetMemo(sale.ObjectId);

                        if (memo == null) {
                            memo = new Memo(sale, _customer, Shops.First(s => s.ObjectId == sale.ShopId));
                            memo.PreviousDue = null;
                            memo.Note += "\n The original memo didn't have any previous due field in database."
                                       + "That record was temporary";
                        }
                        PrintSaleMemo.ToPdf(memo);
                    }
                    Process.Start(outfilename);
                    break;

                case SupplierReport:
                    // Todo - Show Purchase / Repayment / Purchase Return
                    ISupplierReportable supplierReport = report.SupplierReportables[index];
                    type = supplierReport.Type;
                    if (type == "Purchase")
                        purchase = report.Purchases.Single(p => p.PurchaseId == supplierReport.Id);
                    else if (type == "Repayment")
                        repayment = report.Repayments.Single(r => r.RepaymentId == supplierReport.Id);
                    else if (type == "Prc. Rtrn")
                        purchaseReturn = report.PurchaseReturns.Single(pr => pr.PurchaseReturnId == supplierReport.Id);
                    break;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int count = ReportsGrid.SelectedRows.Count;
            if (count == 0) {
                MessageBox.Show("No items selected", "Information");
                return;
            }

            if (MessageBox.Show($"Are you sure want to delete {count} entries?\n" +
                                "The deletion is permanent.",
                    "Caution",
                    MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            
            switch (report.ReportType) {
                case Summary:
                    break;

                case BankAccountReport:
                case TransactionReport:
                    foreach (DataGridViewRow row in ReportsGrid.SelectedRows)
                        Connection[0].DeleteTransaction(report.Transactions[row.Index]);
                    break;

                case CustomerReport:
                    foreach (DataGridViewRow row in ReportsGrid.SelectedRows)
                    {
                        ICustomerReportable customerReport = report.CustomerReportables[row.Index];
                        switch (customerReport)
                        {
                            case Sale _:
                                Connection[0].DeleteSale(report.Sales.Single(s => s.SaleId == customerReport.Id));
                                break;
                            case DebtCollection _:
                                Connection[0].DeleteDebtCollection(
                                    report.DebtCollections.Single(dc => dc.DebtCollectionId == customerReport.Id));
                                break;
                            case Refund _:
                                Connection[0].DeleteRefund(report.Refunds.Single(r => r.RefundId == customerReport.Id));
                                break;
                        }
                    }
                    break;

                case DebtCollectionReport:
                    foreach (DataGridViewRow row in ReportsGrid.SelectedRows)
                        Connection[0].DeleteDebtCollection(report.DebtCollections[row.Index]);
                    break;

                case EmployeeReport:
                case PaymentReport:
                    foreach (DataGridViewRow row in ReportsGrid.SelectedRows)
                        Connection[0].DeletePayment(report.Payments[row.Index]);
                    break;

                case ExpenseReport:
                    foreach (DataGridViewRow row in ReportsGrid.SelectedRows)
                        Connection[0].DeleteExpense(report.Expenses[row.Index]);
                    break;

                case PurchaseReport:
                    foreach (DataGridViewRow row in ReportsGrid.SelectedRows)
                        Connection[0].DeletePurchase(report.Purchases[row.Index]);
                    break;

                case PurchaseReturnReport:
                    foreach (DataGridViewRow row in ReportsGrid.SelectedRows)
                        Connection[0].DeletePurchaseReturn(report.PurchaseReturns[row.Index]);
                    break;

                case RefundReport:
                    foreach (DataGridViewRow row in ReportsGrid.SelectedRows)
                        Connection[0].DeleteRefund(report.Refunds[row.Index]);
                    break;

                case RepaymentReport:
                    foreach (DataGridViewRow row in ReportsGrid.SelectedRows)
                        Connection[0].DeleteRepayment(report.Repayments[row.Index]);
                    break;

                case SaleReport:
                    foreach (DataGridViewRow row in ReportsGrid.SelectedRows)
                        Connection[0].DeleteSale(report.Sales[row.Index]);
                    break;

                case SupplierReport:
                    foreach (DataGridViewRow row in ReportsGrid.SelectedRows)
                    {
                        ISupplierReportable suppplierReport = report.SupplierReportables[row.Index];
                        switch (suppplierReport)
                        {
                            case Purchase _:
                                Connection[0]
                                    .DeletePurchase(report.Purchases.Single(p => p.PurchaseId == suppplierReport.Id));
                                break;
                            case PurchaseReturn _:
                                Connection[0].DeletePurchaseReturn(
                                    report.PurchaseReturns.Single(pr => pr.PurchaseReturnId == suppplierReport.Id));
                                break;
                            case Repayment _:
                                Connection[0]
                                    .DeletePayment(report.Payments.Single(r => r.PaymentId == suppplierReport.Id));
                                break;
                        }
                    }
                    break;
            }
            RefreshForm();
        }

        private void ReportsGrid_SelectionChanged(object sender, EventArgs e) {
            if (ReportsGrid.CurrentRow != null)
                ViewButton.Enabled = ReportsGrid.CurrentRow.Index > -1;
        }
    }
}