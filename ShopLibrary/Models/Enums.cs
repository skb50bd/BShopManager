namespace ShopLibrary.Models {
    public enum TransactionType {
        Deposit = 1,
        Withdrawal = 2
    }

    public enum UserRole {
        Root = 1,
        Admin,
        AppUser,
        Viewer
    }

    public enum SaleType {
        All = 0,
        WholeSale,
        RetailSale
    }

    public enum ReturnType
    {
        Refund,
        PurchaseReturn
    }

    public enum ReportType
    {
        Summary = 0,
        BankAccountReport,
        CustomerReport,
        DebtCollectionReport,
        EmployeeReport,
        ExpenseReport,
        PaymentReport,
        PurchaseReport,
        PurchaseReturnReport,
        RefundReport,
        RepaymentReport,
        SaleReport,
        SupplierReport,
        TransactionReport
    }
}