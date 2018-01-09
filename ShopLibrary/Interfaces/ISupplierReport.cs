using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface ISupplierReport : IReportable {
        Supplier Supplier { get; set; }
        List<Purchase> Purchases { get; set; }
        List<PurchaseReturn> PurchaseReturns { get; set; }
        List<Repayment> Repayments { get; set; }
        List<ISupplierReportable> SupplierReportables { get; set; }
        int NumberOfPurchases { get; }
        int NumberOfPurchaseReturns { get; }
        int NumberOfRepayments { get; }
        decimal PurchasesPriceTotal { get; }
        decimal TotalPaid { get; }
        decimal TotalRepayable { get; }
        decimal CurrentRepayable { get; }
        decimal PurchaseReturnPriceTotal { get; }

        List<Purchase> GetSupplierPurchases(Supplier supplier);
        List<PurchaseReturn> GetSupplierPurchaseReturns(Supplier supplier);
        List<Repayment> GetSupplierRepayments(Supplier supplier);
    }
}