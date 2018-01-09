using System.Collections.Generic;

namespace ShopLibrary.Models {
    public interface IDebtCollectionReport: IReportable {
        List<DebtCollection> DebtCollections { get; set; }
        int NumberOfDebtCollections { get; }
        decimal DebtCollectionTotal { get; }

        List<DebtCollection> GetDebtCollections();
    }
}