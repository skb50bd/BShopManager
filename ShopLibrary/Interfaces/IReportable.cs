using System;

namespace ShopLibrary.Models {
    public interface IReportable {
        ReportType ReportType { get; set; }
        int NumberOfEntries { get; }
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }
    }
}