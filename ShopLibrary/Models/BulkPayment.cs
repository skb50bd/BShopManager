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
        public ObjectId bulkPaymentId { get; set; }
        public string userId { get; set; }
        public string userName { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date = DateTime.Now ;

    }
}
