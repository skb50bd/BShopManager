using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface ISaleReport: IReportable {
        List<Sale> Sales { get; }
        decimal PurchasePriceTotal { get; }
        decimal SalePriceTotal { get; }
        decimal TotalProfit { get; }
        decimal TotalPaid { get; }
        decimal TotalDue { get; }
        int NumberOfWholeSales { get; }
        int NumberOfRetailSales { get; }
        int NumberOfSales { get; }

        List<Sale> GetSales();
    }
}