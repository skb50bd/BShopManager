using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models
{
    public class BulkPayment
    {
        [BsonId]
        public ObjectId ObjectId { get; set; }
        public Metadata Meta { get; set; }

    }
}
