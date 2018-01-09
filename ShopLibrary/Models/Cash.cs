using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models
{
    public class Cash
    {
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("current")]
        public decimal Current { get; set; }

        public string GetCurrent => Current.ToString("0.##");
    }
}
