using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class BankAccount {
        public BankAccount() { }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("accountName")]
        public string AccountName { get; set; }
        [BsonElement("bankName")]
        public string BankName { get; set; }
        [BsonElement("accountNumber")]
        public string AccountNumber { get; set; }
        [BsonElement("currentBalance")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal CurrentBalance { get; set; }
        [BsonElement("note")]
        public string Note { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        #endregion

        #region Getters
        public string BankAccountId => "B" + ObjectId.Increment;
        public string Creator => Meta.Creator;
        public string Created => Meta.Created.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier => Meta.Modifier;
        public string Modified => Meta.Modified.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        #endregion

        public override string ToString() => AccountName;
    }
}