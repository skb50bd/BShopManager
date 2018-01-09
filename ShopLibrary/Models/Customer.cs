using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Customer : Person {
        public Customer() {
            Meta = new Metadata();
            IsActive = true;
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("companyName")]
        public string CompanyName { get; set; }
        [BsonElement("debt")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Debt { get; set; }
        #endregion

        #region Getters
        public string CustomerId          => "C" + ObjectId.Increment;
        public string GetDebt             => Debt.ToString("0.##");
        public string Creator             => Meta.Creator;
        public string Created             => Meta.Created.ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier            => Meta.Modifier;
        public string Modified            => Meta.Modified.ToString("dd/MM/yyyy hh:mm tt");
        #endregion
        public override string ToString() => CustomerId + " - " + FullName;
    }
}