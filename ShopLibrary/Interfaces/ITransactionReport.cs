using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface ITransactionReport: IReportable {
        List<Transaction> Transactions { get; set; }
        int NumberOfTransactions { get; }
        int NumberOfWithdraws { get; }
        decimal WithdrawTotal { get; }
        int NumberOfDeposits { get; }
        decimal DepositTotal { get; }

        List<Transaction> GetTransactions();
    }
}