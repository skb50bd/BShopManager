using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface IRefundReport: IReportable {
        List<Refund> Refunds { get; set; }
        int NumberOfRefunds { get; }
        decimal PriceAmountTotal { get; }
        decimal RefundAmountTotal { get; }
        decimal CutAmountTotal { get; }

        List<Refund> GetRefunds();
    }
}