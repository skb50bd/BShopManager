﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    public class Cash
    {
        public Cash()
        {
            ObjectId = ObjectId.Empty;
            Current = 0;
        }

        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("current")]
        public decimal Current { get; set; }

        public string GetCurrent => Current.ToString("0.##");
    }
}
