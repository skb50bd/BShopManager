using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    public class BulkPayment
    {
        [BsonId]
        public ObjectId ObjectId { get; set; }
        public Metadata Meta { get; set; }

    }
}
