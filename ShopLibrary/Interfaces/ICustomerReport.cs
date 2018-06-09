using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface ICustomerReport: IReportable {
        Customer Customer { get; set; }
        List<Sale> Sales { get; set; }
        List<DebtCollection> DebtCollections { get; set; }
        List<Refund> Refunds { get; set; }
        List<ICustomerReportable> CustomerReportables { get; set; }
        int NumberOfSales { get; }
        int NumberOfDebtCollections { get; }
        int NumberOfRefunds { get; }
        decimal SalesPriceTotal { get; }
        decimal TotalPaid { get; }
        decimal TotalDue { get; }
        decimal TotalDebtCollection { get; }
        decimal CurrentDue { get; }
        decimal TotalRefund { get; }
        decimal TotalProfit { get; }

        List<Sale> GetCustomerSales(Customer customer);
        List<DebtCollection> GetCustomerDebtCollections(Customer customer);
        List<Refund> GetCustomerRefunds(Customer customer);

        void LoadCustomerReport ();
    }
}