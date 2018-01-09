using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface IExpenseReport: IReportable {
        List<Expense> Expenses { get; set; }
        int NumberOfExpenses { get; }
        decimal TotalExpense { get; }

        List<Expense> GetExpenses();
    }
}