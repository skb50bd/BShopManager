using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Shop {
        public Shop() {
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("shopName")]
        public string ShopName { get; set; }
        [BsonElement("address")]
        public string Address { get; set; }
        [BsonElement("tagline")]
        public string Tagline { get; set; }
        [BsonElement("details")]
        public string Details { get; set; }
        [BsonElement("contactNumbers")]
        public List<string> ContactNumbers { get; set; }
        [BsonElement("emailAddresses")]
        public List<string> EmailAddresses { get; set; }
        [BsonElement("propietorName")]
        public string PropietorName { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        #endregion

        #region Getters
        public string Created             => Meta.Created.ToString("dd/MM/yyyy hh:mm tt");
        public string Creator             => Meta.Creator;
        public string Modified            => Meta.Modified.ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier            => Meta.Modifier;
        public string ShopId              => "SP" + ObjectId.Increment;
        #endregion

        public override string ToString() => ShopName;
    }
}