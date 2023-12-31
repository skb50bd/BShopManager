﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShopLibrary.Models;
using System.Data;
using System.Diagnostics;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;
using ShopLibrary.Prints;

namespace WinFormsUI.Forms {
    public partial class CustomerForm : Form {
    #region MakeDraggable
        /// <summary>
        ///     This Part Makes the Form Draggable, as the Form Has No Border
        /// </summary>
        public const int WmNclbuttondown = 0xA1;

        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage (IntPtr hWnd,
            int                                      msg,
            int                                      wParam,
            int                                      lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture ();

        private void MakeDraggable (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
            }
        }
    #endregion

        private List<Customer>       _groupedCustomers;
        private List<Sale>           _sales;
        private List<DebtCollection> _debtCollections;
        private List<Refund>         _refunds;

        private List<ICustomerReportable> _records =
            new List<ICustomerReportable>();

        private          Customer _customer;
        private readonly bool     _called;

        public CustomerForm ()
        {
            InitializeComponent();
            _called = false;
        }

        public CustomerForm (Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            _called   = true;
        }

        private void CustomersForm_Load (object sender, EventArgs e)
        {
            CustomersDataGrid.AutoGenerateColumns       = false;
            CustomerHistoryDataGrid.AutoGenerateColumns = false;

            var role = CurrentUser.AccessLevel;

            if (role <= Admin)
            {
                DeleteCustomerButton.Enabled = true;
                DeleteEntryButton.Enabled    = true;
            }
            else
            {
                DeleteCustomerButton.Enabled = false;
                DeleteEntryButton.Enabled    = false;

                if (role > AppUser)
                {
                    AddCustomerButton.Enabled      = false;
                    ViewEditCustomerButton.Enabled = false;
                }
            }

            if (_called)
            {
                _groupedCustomers =
                    new List<Customer>() {_customer};
                CustomersDataGrid.DataSource       = _groupedCustomers;
                CustomersDataGrid.Rows[0].Selected = true;
            }
            else
                WireUp();
        }

        private void WireUp ()
        {
            CustomersDataGrid.DataSource = null;
            _groupedCustomers            = Customers;
            CustomersDataGrid.DataSource = _groupedCustomers;
        }

        private void AddCustomerButton_Click (object sender, EventArgs e)
        {
            Form ac     = new CustomerInformationForm();
            var  result = ac.ShowDialog();
            if (result == DialogResult.OK)
                WireUp();
        }

        private void SearchCustomerText_TextChanged (object sender, EventArgs e)
        {
            var text = SearchCustomerText.Text.ToLowerInvariant();

            if (text.Length == 0)
            {
                _groupedCustomers = Customers;
            }
            else
            {
                var tokens = text.Split();

                switch (tokens.Length)
                {
                    case 1:
                        if (decimal.TryParse(text, out var min))
                            _groupedCustomers = Customers
                                                .Where(sp => sp.Debt >= min)
                                                .ToList();

                        else if (text.Length > 1)
                            if (text.Substring(0, 1).ToLowerInvariant()
                             == "C".ToLowerInvariant())
                                _groupedCustomers = Customers
                                                    .Where(sp =>
                                                        sp.CustomerId
                                                          .ToLowerInvariant()
                                                          .Contains(text))
                                                    .ToList();
                            else
                                _groupedCustomers = Customers
                                                    .Where(sp =>
                                                        sp.FullName
                                                          .ToLowerInvariant()
                                                          .Contains(text)
                                                     || sp.NickName
                                                          .ToLowerInvariant()
                                                          .Contains(text)
                                                     || sp.CompanyName
                                                          .ToLowerInvariant()
                                                          .Contains(text))
                                                    .ToList();

                        break;
                    case 2:
                        if (decimal.TryParse(tokens[0], out min)
                         && decimal.TryParse(tokens[1], out var max))
                            _groupedCustomers = Customers
                                                .Where(c =>
                                                    c.Debt >= min
                                                 && c.Debt <= max)
                                                .ToList();
                        else
                            _groupedCustomers = Customers
                                                .Where(c =>
                                                    c.FullName
                                                     .ToLowerInvariant()
                                                     .Contains(text)
                                                 || c.NickName
                                                     .ToLowerInvariant()
                                                     .Contains(text)
                                                 || c.CompanyName
                                                     .ToLowerInvariant()
                                                     .Contains(text))
                                                .ToList();

                        break;
                    default:
                        _groupedCustomers = Customers
                                            .Where(c =>
                                                c.FullName.ToLowerInvariant()
                                                 .Contains(text)
                                             || c.NickName.ToLowerInvariant()
                                                 .Contains(text)
                                             || c.CompanyName.ToLowerInvariant()
                                                 .Contains(text))
                                            .ToList();

                        break;
                }
            }

            CustomersDataGrid.ClearSelection();
            CustomersDataGrid.DataSource = null;
            CustomersDataGrid.DataSource = _groupedCustomers;
        }

        private void ViewEditCustomerButton_Click (object sender, EventArgs e)
        {
            try
            {
                Form ci =
                    new CustomerInformationForm(
                        _groupedCustomers[CustomersDataGrid
                                          .SelectedCells[0]
                                          .RowIndex]);
                var result = ci.ShowDialog();
                if (result == DialogResult.OK)
                    WireUp();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void CustomersDataGrid_SelectionChanged (object sender,
            EventArgs                                           e)
        {
            var index = CustomersDataGrid.CurrentRow.Index;

            if (_groupedCustomers.Count > 0 && index < _groupedCustomers.Count)
            {
                _customer = _groupedCustomers[index];
                _sales = Connection[0]
                    .GetSaleByCustomer(_customer,
                        DateTime.Today.AddYears(-1),
                        DateTime.Now);
                _records = _sales.ToList<ICustomerReportable>();

                _debtCollections = Connection[0]
                    .GetDebtCollectionByCustomer(
                        _customer,
                        DateTime.Today.AddYears(-1),
                        DateTime.Now);
                _records.AddRange(
                    _debtCollections.ToList<ICustomerReportable>());

                _refunds = Connection[0]
                    .GetRefundByCustomer(
                        _customer,
                        DateTime.Today.AddYears(-1),
                        DateTime.Now);
                _records.AddRange(_refunds.ToList<ICustomerReportable>());

                _records =
                    _records.OrderByDescending(r => r.TimeStamp).ToList();
            }
            else
                _records = null;

            CustomerHistoryDataGrid.DataSource = null;
            CustomerHistoryDataGrid.DataSource = _records;
        }

        private void DeleteCustomerButton_Click (object sender, EventArgs e)
        {
            var selectedIndex = CustomersDataGrid.CurrentRow.Index;

            if (selectedIndex < 0)
            {
                MessageBox.Show("Nothing selected", "Error");

                return;
            }

            var result =
                MessageBox.Show(
                    $"Do you really want to delete {CustomersDataGrid.SelectedRows.Count} customer?\n"
                  + "This process is irreversible\n",
                    "Confirm",
                    MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in CustomersDataGrid.SelectedRows)
                Connection[0].DisableCustomer(_groupedCustomers[row.Index]);
            RefreshCustomersButton_Click(sender, e);
        }

        private void DeleteEntryButton_Click (object sender, EventArgs e)
        {
            var selectedIndex = CustomersDataGrid.CurrentRow.Index;

            if (selectedIndex > -1)
            {
                var result =
                    MessageBox.Show(
                        $"Do you really want to delete {CustomerHistoryDataGrid.SelectedRows.Count} records?\n"
                      + "This action is irreversible\n",
                        "Confirm",
                        MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes)
                    return;

                foreach (DataGridViewRow row in CustomerHistoryDataGrid
                    .SelectedRows)
                {
                    if (row.Cells[0].Value.ToString().Contains("Sale"))
                        Connection[0]
                            .DeleteSale(
                                _sales.Single(s =>
                                    s.SaleId == _records[row.Index].Id));
                    else if (row.Cells[0].Value.ToString() == "DueColumn Col.")
                        Connection[0]
                            .DeleteDebtCollection(
                                _debtCollections.Single(dc =>
                                    dc.DebtCollectionId
                                 == _records[row.Index].Id));
                    else if (row.Cells[0].Value.ToString() == "Refund")
                        Connection[0]
                            .DeleteRefund(
                                _refunds.Single(r =>
                                    r.RefundId == _records[row.Index].Id));
                }
            }

            WireUp();
            CustomersDataGrid.ClearSelection();
            CustomersDataGrid.Rows[selectedIndex].Selected = true;
        }

        private void ViewRecordButton_Click (object sender, EventArgs e)
        {
            // Todo - Show Sale / Debt Collection / Refund
        }

        private void RefreshCustomersButton_Click (object sender, EventArgs e)
        {
            Customers = Connection[0].GetCustomersAll();
            WireUp();
        }

        private void PrintButton_Click (object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(
                Environment.GetFolderPath(Environment
                                          .SpecialFolder.MyDocuments)
              + @"\Brotal\");

            var filepath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
              + @"\Brotal\"
              + $"CustomerDueReport-{DateTime.Now:yyyyMMddHHmmss}"
              + ".pdf";
            DataGridViewPrint.PrintDueListToPdf(_groupedCustomers,
                filepath,
                "Customer Due Report");

            Process.Start(filepath);
        }

        private void PrintCustomerNameButton_Click (object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(
                Environment.GetFolderPath(Environment
                                          .SpecialFolder.MyDocuments)
              + @"\Brotal\");

            var filepath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
              + @"\Brotal\"
              + $"CustomerStatement-{_customer}"
              + $"-{DateTime.Now:yyyyMMddHHmmss}"
              + ".pdf";
            ICustomerReport customerReport = new Report {
                FromDate            = DateTime.MinValue,
                ToDate              = DateTime.MaxValue,
                Customer            = _customer,
                CustomerReportables = _records
            };
            customerReport.LoadCustomerReport();

            customerReport.PrintCustomerStatementToPdf(filepath);
            Process.Start(filepath);
        }
    }
}
