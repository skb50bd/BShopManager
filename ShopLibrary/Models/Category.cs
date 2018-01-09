using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Category {
        public Category() { }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("categoryName")]
        public string CategoryName { get; set; }
        [BsonElement("specifications")]
        public List<string> Specifications { get; set; } = new List<string>();
        #endregion

        #region Getters
        public string CategoryId          => "CT" + ObjectId.Increment;
        #endregion
        public override string ToString() => CategoryName;
    }
}