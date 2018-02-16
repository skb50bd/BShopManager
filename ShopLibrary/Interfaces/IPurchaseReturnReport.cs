using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface IPurchaseReturnReport: IReportable {
        List<PurchaseReturn> PurchaseReturns { get; set; }
        int NumberOfPurchaseReturns { get; }
        decimal PriceAmountTotal { get; }
        decimal CutAmountTotal { get; }
        decimal RefundAmountTotal { get; }

        List<PurchaseReturn> GetPurchaseReturns();
    }
}