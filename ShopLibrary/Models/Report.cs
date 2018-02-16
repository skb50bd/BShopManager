using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson.Serialization.Attributes;
using static ShopLibrary.GlobalConfig;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Report: 
        IBankAccountReport,
        ICustomerReport,
        IDebtCollectionReport,
        IEmployeeReport,
        IExpenseReport,
        IPaymentReport,
        IPurchaseReport,
        IPurchaseReturnReport,
        IRefundReport,
        IRepaymentReport,
        ISaleReport,
        ISupplierReport,
        ITransactionReport
    {
        public Report()
        {
            FromDate            = DateTime.Today.AddYears(-1);
            ToDate              = DateTime.Now;
            CustomerReportables = new List<ICustomerReportable>();
            DebtCollections     = new List<DebtCollection>();
            Expenses            = new List<Expense>();
            Payments            = new List<Payment>();
            PurchaseReturns     = new List<PurchaseReturn>();
            Purchases           = new List<Purchase>();
            Refunds             = new List<Refund>();
            Repayments          = new List<Repayment>();
            Sales               = new List<Sale>();
            SupplierReportables = new List<ISupplierReportable>();
            Transactions        = new List<Transaction>();
            BankAccount         = new BankAccount();
            Customer            = new Customer();
            Employee            = new Employee();
            Shop                = new Shop();
            Supplier            = new Supplier();
            CashFlows           = new List<ICashFlow>();
        }

        #region Global Variables

        #region Essential
        public ReportType ReportType { get; set; }
        public int NumberOfEntries { get; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        #endregion

        #region Lists
        public List<ICashFlow> CashFlows { get; set;}
        public List<DebtCollection> DebtCollections { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<ICustomerReportable> CustomerReportables { get; set; }
        public List<ISupplierReportable> SupplierReportables { get; set; }
        public List<Payment> Payments { get; set; }
        public List<Purchase> Purchases { get; set; }
        public List<PurchaseReturn> PurchaseReturns { get; set; }
        public List<Refund> Refunds { get; set; }
        public List<Repayment> Repayments { get; set; }
        public List<Sale> Sales { get; set; }
        public List<Transaction> Transactions { get; set; }
        #endregion

        #region Objects
        public BankAccount BankAccount { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public Shop Shop { get; set; }
        public Supplier Supplier { get; set; }
        #endregion

        #region Stats
        public int NumberOfRefunds { get; }
        public int NumberOfDebtCollections { get; }
        public decimal TotalPaid { get; }
        public decimal TotalProfit { get; }

        public int NumberOfPurchaseReturns { get; }
        public int NumberOfRepayments { get; }
        public decimal TotalRepayable { get; }
        public int NumberOfPayments { get; }
        public decimal PurchasePriceTotal { get; }
        public decimal PriceAmountTotal { get; }
        public decimal RefundAmountTotal { get; }
        public decimal CutAmountTotal { get; }
        #endregion

        #endregion

        #region Customer Report

        int ICustomerReport.NumberOfSales           => Sales.Count;
        int ICustomerReport.NumberOfDebtCollections => DebtCollections.Count;
        int ICustomerReport.NumberOfRefunds         => Refunds.Count;
        decimal ICustomerReport.SalesPriceTotal     => Sales.Sum(s => s.Payable);
        decimal ICustomerReport.TotalPaid           => Sales.Sum(s => s.Paid);
        decimal ICustomerReport.TotalDue            => Sales.Sum(s => s.Due);
        decimal ICustomerReport.TotalDebtCollection => DebtCollections.Sum(dc => dc.Amount);
        decimal ICustomerReport.CurrentDue          => Customer.Debt;
        decimal ICustomerReport.TotalRefund         => Refunds.Sum(s => s.RefundAmount);
        decimal ICustomerReport.TotalProfit         => Sales.Sum(s => s.Profit);
        List<Sale> ICustomerReport.GetCustomerSales(Customer customer) 
            => Connection[0].GetSaleByCustomer(customer, FromDate, ToDate);
        List<DebtCollection> ICustomerReport.GetCustomerDebtCollections(Customer customer)
            => Connection[0].GetDebtCollectionByCustomer(customer, FromDate, ToDate);
        List<Refund> ICustomerReport.GetCustomerRefunds(Customer customer)
            => Connection[0].GetRefundByCustomer(customer, FromDate, ToDate);

        #endregion

        #region Debt Collection Report

        int IDebtCollectionReport.NumberOfDebtCollections => DebtCollections.Count;
        decimal IDebtCollectionReport.DebtCollectionTotal => DebtCollections.Sum(dc => dc.Amount);
        List<DebtCollection> IDebtCollectionReport.GetDebtCollections()
            => Connection[0].GetDebtCollectionByDate(FromDate, ToDate);

        #endregion

        #region Employee Report

        int IEmployeeReport.NumberOfPayments   => Payments.Count;
        int IEmployeeReport.MonthsWorked       => ((DateTime.Today.Year - Employee.JoinDate.Year) * 12) + Employee.JoinDate.Month - DateTime.Today.Month;
        decimal IEmployeeReport.CurrentBalance => Employee.Balance;
        decimal IEmployeeReport.TotalPaid      => Payments.Sum(p => p.Amount);
        DateTime IEmployeeReport.JoinDate      => Employee.JoinDate;
        List<Payment> IEmployeeReport.GetEmployeePayments(Employee employee)
            => Connection[0].GetPaymentByEmployee(employee, FromDate, ToDate);

        #endregion

        #region Expense Report

        int IExpenseReport.NumberOfExpenses => Expenses.Count;
        decimal IExpenseReport.TotalExpense => Expenses.Sum(e => e.TotalAmount);
        List<Expense> IExpenseReport.GetExpenses()
            => Connection[0].GetExpenseByDate(FromDate, ToDate);

        #endregion

        #region Payment Report

        int IPaymentReport.NumberOfPayments => Payments.Count;
        decimal IPaymentReport.TotalPaid    => Payments.Sum(p => p.Amount);
        List<Payment> IPaymentReport.GetPayments()
            => Connection[0].GetPaymentByDate(FromDate, ToDate);

        #endregion

        #region Purchase Report

        int IPurchaseReport.NumberOfPurchases      => Purchases.Count;
        decimal IPurchaseReport.PurchasePriceTotal => Purchases.Sum(p => p.Payable);
        decimal IPurchaseReport.TotalPaid          => Purchases.Sum(p => p.Paid);
        decimal IPurchaseReport.TotalRepayable     => Purchases.Sum(p => p.Due);
        List<Purchase> IPurchaseReport.GetPurchases()
            => Connection[0].GetPurchaseByDate(FromDate, ToDate);

        #endregion

        #region Purchase Return Report

        int IPurchaseReturnReport.NumberOfPurchaseReturns => PurchaseReturns.Count;
        decimal IPurchaseReturnReport.PriceAmountTotal    => PurchaseReturns.Sum(p => p.PriceAmount);
        decimal IPurchaseReturnReport.CutAmountTotal      => PurchaseReturns.Sum(p => p.PurchaseReturnCut);
        decimal IPurchaseReturnReport.RefundAmountTotal   => PurchaseReturns.Sum(p => p.PurchaseReturnAmount);
        List<PurchaseReturn> IPurchaseReturnReport.GetPurchaseReturns()
            => Connection[0].GetPurchaseReturnByDate(FromDate, ToDate);

        #endregion

        #region Refund Report

        int IRefundReport.NumberOfRefunds       => Refunds.Count;
        decimal IRefundReport.PriceAmountTotal  => Refunds.Sum(r => r.PriceAmount);
        decimal IRefundReport.RefundAmountTotal => Refunds.Sum(r => r.RefundAmount);
        decimal IRefundReport.CutAmountTotal    => Refunds.Sum(r => r.RefundCut);
        List<Refund> IRefundReport.GetRefunds()
            => Connection[0].GetRefundByDate(FromDate, ToDate);

        #endregion

        #region Repayment Report

        int IRepaymentReport.NumberOfRepayments => Repayments.Count;
        decimal IRepaymentReport.TotalRepaid    => Repayments.Sum(r => r.Amount);
        List<Repayment> IRepaymentReport.GetRepayments()
            => Connection[0].GetRepaymentByDate(FromDate, ToDate);

        #endregion

        #region Sale Report

        int ISaleReport.NumberOfRetailSales    => Sales.Count(s => s.SaleType == SaleType.RetailSale);
        int ISaleReport.NumberOfWholeSales     => Sales.Count(s => s.SaleType == SaleType.WholeSale);
        int ISaleReport.NumberOfSales          => Sales.Count;
        decimal ISaleReport.PurchasePriceTotal => Sales.Sum(s => s.TotalPurchasePrice);
        decimal ISaleReport.SalePriceTotal     => Sales.Sum(s => s.Payable);
        decimal ISaleReport.TotalProfit        => Sales.Sum(s => s.Profit);
        decimal ISaleReport.TotalPaid          => Sales.Sum(s => s.Paid);
        decimal ISaleReport.TotalDue           => Sales.Sum(s => s.Due);
        List<Sale> ISaleReport.GetSales()
            => Connection[0].GetSaleByDate(FromDate, ToDate);

        #endregion

        #region Supplier Report

        int ISupplierReport.NumberOfPurchases            => Purchases.Count;
        int ISupplierReport.NumberOfPurchaseReturns      => PurchaseReturns.Count;
        int ISupplierReport.NumberOfRepayments           => Repayments.Count;
        decimal ISupplierReport.PurchasesPriceTotal      => Purchases.Sum(s => s.Payable);
        decimal ISupplierReport.TotalPaid                => Purchases.Sum(s => s.Paid);
        decimal ISupplierReport.TotalRepayable           => Purchases.Sum(s => s.Due);
        decimal ISupplierReport.CurrentRepayable         => Supplier.Payable;
        decimal ISupplierReport.PurchaseReturnPriceTotal => PurchaseReturns.Sum(pr => pr.PurchaseReturnAmount);

        List<Purchase> ISupplierReport.GetSupplierPurchases(Supplier supplier)
            => Connection[0].GetPurchaseBySupplier(supplier, FromDate, ToDate);
        List<PurchaseReturn> ISupplierReport.GetSupplierPurchaseReturns(Supplier supplier)
            => Connection[0].GetPurchaseReturnBySupplier(supplier, FromDate, ToDate);
        List<Repayment> ISupplierReport.GetSupplierRepayments(Supplier supplier)
            => Connection[0].GetRepaymentBySupplier(supplier, FromDate, ToDate);

        #endregion

        #region Transaction Report

        int ITransactionReport.NumberOfTransactions => Transactions.Count;
        int ITransactionReport.NumberOfWithdraws =>
            Transactions.Count(t => t.TransactionType == TransactionType.Withdrawal);
        int ITransactionReport.NumberOfDeposits =>
            Transactions.Count(t => t.TransactionType == TransactionType.Deposit);
        decimal ITransactionReport.WithdrawTotal =>
            Transactions.Where(t => t.TransactionType == TransactionType.Withdrawal).Sum(t => t.Amount);
        decimal ITransactionReport.DepositTotal =>
            Transactions.Where(t => t.TransactionType == TransactionType.Deposit).Sum(t => t.Amount);
        List<Transaction> ITransactionReport.GetTransactions()
            => Connection[0].GetTransactionsByDate(FromDate, ToDate);

        #endregion

        #region Bank Account Report

        int IBankAccountReport.NumberOfTransactions => Transactions.Count;
        int IBankAccountReport.NumberOfWithdraws =>
            Transactions.Count(t => t.TransactionType == TransactionType.Withdrawal);
        int IBankAccountReport.NumberOfDeposits =>
            Transactions.Count(t => t.TransactionType == TransactionType.Deposit);
        decimal IBankAccountReport.WithdrawTotal =>
            Transactions.Where(t => t.TransactionType == TransactionType.Withdrawal).Sum(t => t.Amount);
        decimal IBankAccountReport.DepositTotal =>
            Transactions.Where(t => t.TransactionType == TransactionType.Deposit).Sum(t => t.Amount);
        List<Transaction> IBankAccountReport.GetBankTransactions(BankAccount bankAccount)
            => Connection[0].GetTransactionsByBankAccount(bankAccount, FromDate, ToDate);
        #endregion
    }
}