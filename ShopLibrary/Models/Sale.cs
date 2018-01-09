using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using static ShopLibrary.Models.SaleType;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Sale : ICustomerReportable, ICashFlow {
        public Sale() {
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("cart")]
        public List<ShoppingCart> Cart { get; set; } = new List<ShoppingCart>();
        [BsonElement("shopId")]
        public ObjectId ShopId { get; set; }
        [BsonElement("saleType")]
        public SaleType SaleType { get; set; }
        [BsonElement("customerId")]
        public ObjectId CustomerId { get; set; }
        [BsonElement("customerName")]
        public string CustomerName { get; set; }
        [BsonElement("customerCompany")]
        public string CustomerCompany { get; set; }
        [BsonElement("customerAddress")]
        public string CustomerAddress { get; set; }
        [BsonElement("totalAmount")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal TotalAmount { get; set; }
        [BsonElement("less")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Less { get; set; }
        [BsonElement("paid")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Paid { get; set; }
        [BsonElement("dealTime")]
        public DateTime DealTime { get; set; }
        [BsonElement("notes")]
        public string Note { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        #endregion

        #region Getters
        public decimal Due                => Payable - Paid;
        public decimal Payable            => TotalAmount - Less;
        public decimal Profit             => Payable - TotalPurchasePrice;
        public decimal TotalPurchasePrice => Cart.Sum(sc => sc.NetPurchasePrice);
        public float Discount             => TotalAmount == 0 ? 0 : (float)(Less / TotalAmount * (decimal)100.0);
        public string Created             => Meta.Created.ToString("dd/MM/yyyy hh:mm tt");
        public string Creator             => Meta.Creator;
        public string GetCustomerId       => "C" + CustomerId.Increment;
        public string GetDiscount         => Discount.ToString("0.##");
        public string GetDue              => Due.ToString("0.##");
        public string GetLess             => Less.ToString("0.##");
        public string GetPaid             => Paid.ToString("0.##");
        public string GetPayable          => Payable.ToString("0.##");
        public string GetProfit           => Profit.ToString("0.##");
        public string GetShopId           => "SP" + ShopId.Increment;
        public string GetTotalAmount      => TotalAmount.ToString("0.##");
        public string Modified            => Meta.Modified.ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier            => Meta.Modifier;
        public string SaleId              => "S" + ObjectId.Increment;
        public string SaleTypeInitial     => SaleType == RetailSale ? "R" : "W";
        #endregion

        #region ICustomerReportable Fields
        string ICustomerReportable.Id        => SaleId;
        string ICustomerReportable.Type      => "Sale" + $" ({ SaleTypeInitial })";
        string ICustomerReportable.Amount    => GetPayable;
        string ICustomerReportable.Due       => GetDue;
        string ICustomerReportable.Profit    => Profit.ToString("0.##");
        string ICustomerReportable.TimeStamp => Meta.Created.ToString("u");
        #endregion

        public override string ToString()
            => (SaleType == RetailSale
                ? "R-"
                : "W-") +
                  DealTime.ToString("yyyyMMddHHmmss") +
                  " " +
                  CustomerName;
        public void AddToCart(ShoppingCart sc) => Cart.Add(sc);

        #region ICashFlow Fields
        string ICashFlow.Type => "Sale" + $" ({ SaleTypeInitial })";
        decimal ICashFlow.InFlow => Paid;
        string ICashFlow.GetInFlow => GetPaid;
        decimal ICashFlow.OutFlow => 0;
        string ICashFlow.GetOutFlow => "0";
        DateTime ICashFlow.TimeStamp => Meta.Created;
        string ICashFlow.GetTimeStamp => Meta.Created.ToLocalTime().ToString("u");
        string ICashFlow.Note => Note;
        #endregion
    }
}