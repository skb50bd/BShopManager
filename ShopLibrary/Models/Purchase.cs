using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Purchase : ISupplierReportable, ICashFlow {
        public Purchase() { }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("supplierId")]
        public ObjectId SupplierId { get; set; }
        [BsonElement("supplierName")]
        public string SupplierName { get; set; }
        [BsonElement("supplierCompany")]
        public string SupplierCompany { get; set; }
        [BsonElement("supplierAddress")]
        public string SupplierAddress { get; set; }
        [BsonElement("totalAmount")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal TotalAmount { get; set; }
        [BsonElement("cart")]
        public List<ShoppingCart> Cart { get; set; } = new List<ShoppingCart>();
        [BsonElement("less")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Less { get; set; }
        [BsonElement("paid")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Paid { get; set; }
        [BsonElement("dealTime")]
        public DateTime DealTime { get; set; }
        [BsonElement("note")]
        public string Note { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        #endregion

        #region Getters
        public decimal Due             => Payable - Paid;
        public decimal Payable         => TotalAmount - Less;
        public float Discount          => TotalAmount == 0
                                            ? 0
                                            : (float)(Less / TotalAmount * (decimal)100.0);
        public string Created          => Meta.Created.ToString("dd/MM/yyyy hh:mm tt");
        public string Creator          => Meta.Creator;
        public string GetDiscount      => Discount.ToString("0.##");
        public string GetDue           => Due.ToString("0.##");
        public string GetLess          => Less.ToString("0.##");
        public string GetPaid          => Paid.ToString("0.##");
        public string GetPayable       => Payable.ToString("0.##");
        public string GetSupplierId    => "SP" + SupplierId.Increment;
        public string Modified         => Meta.Modified.ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier         => Meta.Modifier;
        public string PurchaseId       => "PC" + ObjectId.Increment;
        #endregion

        #region ISupplierReportable Fields

        string ISupplierReportable.Id => PurchaseId;
        string ISupplierReportable.Type => "Purchase";
        string ISupplierReportable.Amount => GetPayable;
        string ISupplierReportable.Due => GetDue;
        string ISupplierReportable.TimeStamp => Meta.Created.ToString("u");

        #endregion

        public void AddToCart(ShoppingCart sc) => Cart.Add(sc);
        public override string ToString() => "P" + DealTime.ToString("yyyyMMddHHmmss") + " " + SupplierName;

        #region ICashFlow Fields
        string ICashFlow.Type => "Purchase";
        decimal ICashFlow.InFlow => 0;
        string ICashFlow.GetInFlow => "0";
        decimal ICashFlow.OutFlow => Paid;
        string ICashFlow.GetOutFlow => GetPaid;
        DateTime ICashFlow.TimeStamp => Meta.Created;
        string ICashFlow.GetTimeStamp => Meta.Created.ToLocalTime().ToString("u");
        string ICashFlow.Note => Note;
        #endregion
    }
}