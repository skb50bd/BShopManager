using System;
using System.Collections.Generic;

namespace ShopLibrary.Models
{
    public interface IEmployeeReport: IReportable {
        Employee Employee { get; set; }
        List<Payment> Payments { get; set; }
        int NumberOfPayments { get; }
        int MonthsWorked { get; }
        decimal CurrentBalance { get; }
        decimal TotalPaid { get; }
        DateTime JoinDate { get; }

        List<Payment> GetEmployeePayments(Employee employee);
    }
}