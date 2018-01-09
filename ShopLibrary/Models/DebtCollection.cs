using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class DebtCollection : ICustomerReportable, ICashFlow {
        public DebtCollection() {
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("customerId")]
        public ObjectId CustomerId { get; set; }
        [BsonElement("customerName")]
        public string CustomerName { get; set; }
        [BsonElement("amount")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Amount { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        #endregion

        #region Getters
        public string Created => Meta.Created.ToString("dd/MM/yyyy hh:mm tt");
        public string Creator => Meta.Creator;
        public string DebtCollectionId => "DC" + ObjectId.Increment;
        public string GetAmount => Amount.ToString("0.##");
        public string GetCustomerId => "C" + CustomerId.Increment;
        public string Modified => Meta.Modified.ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier => Meta.Modifier;
        #endregion

        #region ICustomerReportable Fields
        string ICustomerReportable.Id => DebtCollectionId;
        string ICustomerReportable.Type => "Due Col.";
        string ICustomerReportable.Amount => GetAmount;
        string ICustomerReportable.Due => "";
        string ICustomerReportable.Profit => "";
        string ICustomerReportable.TimeStamp => Meta.Created.ToString("u");
        #endregion

        #region ICashFlow Fields
        string ICashFlow.Type => "Due Col.";
        decimal ICashFlow.InFlow => Amount;
        string ICashFlow.GetInFlow => GetAmount;
        decimal ICashFlow.OutFlow => 0;
        string ICashFlow.GetOutFlow => "0";
        DateTime ICashFlow.TimeStamp => Meta.Created;
        string ICashFlow.GetTimeStamp => Meta.Created.ToLocalTime().ToString("u");
        string ICashFlow.Note => $"Due Collected from {CustomerId} - {CustomerName}"; 
        #endregion
    }
}