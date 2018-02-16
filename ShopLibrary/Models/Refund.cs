using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Refund : ICustomerReportable, ICashFlow {
        public Refund() {
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("saleId")]
        public ObjectId SaleId { get; set; }
        [BsonElement("customerId")]
        public ObjectId CustomerId { get; set; }
        [BsonElement("cart")]
        public List<ShoppingCart> Cart { get; set; } = new List<ShoppingCart>();
        [BsonElement("priceAmount")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal PriceAmount { get; set; }
        [BsonElement("refundAmount")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal RefundAmount { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        [BsonElement("note")]
        public string Note { get; set; }
        #endregion

        #region Getters
        public decimal RefundCut      => PriceAmount - RefundAmount;
        public string Created         => Meta.Created.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Creator         => Meta.Creator;
        public string GetCustomerId   => "C" + CustomerId.Increment;
        public string GetPriceAmount  => PriceAmount.ToString("0.##");
        public string GetRefundAmount => RefundAmount.ToString("0.##");
        public string GetRefundCut    => RefundCut.ToString("0.##");
        public string GetSaleId       => "S" + SaleId.Increment;
        public string Modified        => Meta.Modified.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier        => Meta.Modifier;
        public string RefundId        => "RF" + ObjectId.Increment;
        #endregion

        #region ICustomer Reportable Fields
        string ICustomerReportable.Id => RefundId;
        string ICustomerReportable.Type => "Refund";
        string ICustomerReportable.Amount => GetRefundAmount;
        string ICustomerReportable.Due => "";
        string ICustomerReportable.Profit => "";
        string ICustomerReportable.TimeStamp => Meta.Created.ToString("u");
        #endregion

        #region ICashFlow Fields
        string ICashFlow.Id => RefundId;
        string ICashFlow.Type => "Refund";
        decimal ICashFlow.InFlow => 0;
        string ICashFlow.GetInFlow => "0";
        decimal ICashFlow.OutFlow => RefundAmount;
        string ICashFlow.GetOutFlow => GetRefundAmount;
        DateTime ICashFlow.TimeStamp => Meta.Created;
        string ICashFlow.GetTimeStamp => Meta.Created.ToLocalTime().ToString("u");
        string ICashFlow.Note => Note;
        #endregion
    }
}