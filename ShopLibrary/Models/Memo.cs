using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    public class Memo : Sale {
        public Memo (Sale sale, Customer customer, Shop shop) : base(sale) {
            PreviousDue  = customer.Debt;
            ShopName     = shop.ShopName;
            Address      = shop.Address;
            ShopContacts = string.Join(", ", shop.ContactNumbers) 
                         + " - " 
                         + string.Join(", ", shop.EmailAddresses);
        }

        [BsonElement("shopName")]
        public string ShopName { get; set; }

        [BsonElement("shopAddress")]
        public string Address { get; set; }

        [BsonElement("shopContacts")]
        public string ShopContacts { get; set; }

        [BsonElement("previousDue")]
        public decimal? PreviousDue { get; set; }

        [BsonElement("totalPayable")]
        public decimal TotalPayable => (PreviousDue == null)
                                           ? Payable
                                           : (decimal)PreviousDue + Payable;

        [BsonElement("currentDue")]
        public decimal CurrentDue => TotalPayable - Paid;
    }
}
