using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface IBankAccountReport: IReportable
    {
        BankAccount BankAccount { get; set; }
        int NumberOfTransactions { get; }
        int NumberOfWithdraws { get; }
        decimal WithdrawTotal { get; }
        int NumberOfDeposits { get; }
        decimal DepositTotal { get; }

        List<Transaction> GetBankTransactions(BankAccount bankAccount);
    }
}