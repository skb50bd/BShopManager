using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface IRepaymentReport : IReportable {
        List<Repayment> Repayments { get; set; }
        int NumberOfRepayments { get; }
        decimal TotalRepaid { get; }

        List<Repayment> GetRepayments();
    }
}