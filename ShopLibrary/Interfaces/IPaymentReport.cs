using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface IPaymentReport : IReportable {
        List<Payment> Payments { get; set; }
        int NumberOfPayments { get; }
        decimal TotalPaid { get; }

        List<Payment> GetPayments();
    }
}