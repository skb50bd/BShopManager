using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Supplier : Person {
        public Supplier() {
            Meta = new Metadata();
            IsActive = true;
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("companyName")]
        public string CompanyName { get; set; }
        [BsonElement("payable")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Payable { get; set; }
        #endregion

        #region Getters
        public string Created             => Meta.Created.ToString("dd/MM/yyyy hh:mm tt");
        public string Creator             => Meta.Creator;
        public string GetPayable          => Payable.ToString("0.##");
        public string Modified            => Meta.Modified.ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier            => Meta.Modifier;
        public string SupplierId          => "SP" + ObjectId.Increment;
        #endregion

        public override string ToString() => FullName;
    }
}