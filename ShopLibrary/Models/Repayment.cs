using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Repayment : ISupplierReportable, ICashFlow {
        public Repayment(){}

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("supplierId")]
        public ObjectId SupplierId { get; set; }
        [BsonElement("supplierName")]
        public string SupplierName { get; set; }
        [BsonElement("amount")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Amount { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        #endregion

        #region Getters
        public string Created       => Meta.Created.ToString("dd/MM/yyyy hh:mm tt");
        public string Creator       => Meta.Creator;
        public string GetAmount     => Amount.ToString("0.##");
        public string GetSupplierId => "SP" + SupplierId.Increment;
        public string Modified      => Meta.Modified.ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier      => Meta.Modifier;
        public string RepaymentId   => "RP" + ObjectId.Increment;
        #endregion

        #region ISupplierReportable Fields

        string ISupplierReportable.Id => RepaymentId;
        string ISupplierReportable.Type => "Repayment";
        string ISupplierReportable.Amount => Amount.ToString("0.##");
        string ISupplierReportable.Due => "";
        string ISupplierReportable.TimeStamp => Meta.Created.ToString("u");


        #endregion

        #region ICashFlow Fields
        string ICashFlow.Type         => "Repayment";
        decimal ICashFlow.InFlow      => 0;
        string ICashFlow.GetInFlow    => "0";
        decimal ICashFlow.OutFlow     => Amount;
        string ICashFlow.GetOutFlow   => GetAmount;
        DateTime ICashFlow.TimeStamp  => Meta.Created;
        string ICashFlow.GetTimeStamp => Meta.Created.ToLocalTime().ToString("u");
        string ICashFlow.Note         => $"Repayed due to Supplier: {SupplierId} - {SupplierName}";
        #endregion
    }
}
