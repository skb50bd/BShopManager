using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    public class Vouchar : Purchase {
        public Vouchar (Purchase purchase, Supplier supplier) : base(purchase) {
            PreviousDue = supplier.Payable;
        }

        [BsonElement("previousDue")]
        public decimal? PreviousDue { get; set; }

        [BsonElement("totalPayable")]
        public decimal TotalPayable => PreviousDue == null
                                           ? Payable
                                           : (decimal) PreviousDue + Payable;

        [BsonElement("currentDue")]
        public decimal CurrentDue => TotalPayable - Paid;
    }
}
