using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface IPurchaseReport: IReportable {
        List<Purchase> Purchases { get; set; }
        decimal PurchasePriceTotal { get;}
        decimal TotalPaid { get; }
        decimal TotalRepayable { get; }
        int NumberOfPurchases { get; }

        List<Purchase> GetPurchases();
    }
}