using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class PurchaseReturn : ISupplierReportable, ICashFlow {
        public PurchaseReturn() {
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("purchaseId")]
        public ObjectId PurchaseId { get; set; }
        [BsonElement("supplierId")]
        public ObjectId SupplierId { get; set; }
        [BsonElement("cart")]
        public List<ShoppingCart> Cart { get; set; } = new List<ShoppingCart>();
        [BsonElement("priceAmount")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal PriceAmount { get; set; }
        [BsonElement("purchaseReturnAmount")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal PurchaseReturnAmount { get; set; }
        [BsonElement("note")]
        public string Note { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        #endregion

        #region Getters
        public decimal PurchaseReturnCut     => PriceAmount - PurchaseReturnAmount;
        public string Created                => Meta.Created.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Creator                => Meta.Creator;
        public string GetPriceAmount         => PriceAmount.ToString("0.##");
        public string GetPurchaseId          => "PC" + PurchaseId.Increment;
        public string GetPurchaseReturnCut   => PurchaseReturnCut.ToString("0.##");
        public string GetPurchasReturnAmount => PurchaseReturnAmount.ToString("0.##");
        public string GetSupplierId          => "SP" + SupplierId.Increment;
        public string Modified               => Meta.Modified.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier               => Meta.Modifier;
        public string PurchaseReturnId       => "PR" + ObjectId.Increment.ToString("0000");
        #endregion

        #region ISupplierReportable Fields

        string ISupplierReportable.Id => PurchaseReturnId;
        string ISupplierReportable.Type => "Prc. Rtrn";
        string ISupplierReportable.Amount => GetPurchasReturnAmount;
        string ISupplierReportable.Due => "";
        string ISupplierReportable.TimeStamp => Meta.Created.ToLocalTime().ToString("u");


        #endregion

        #region ICashFlow Members
        string ICashFlow.Id => PurchaseReturnId;
        string ICashFlow.Type => "Purchase Return";
        decimal ICashFlow.InFlow => PurchaseReturnAmount;
        string ICashFlow.GetInFlow => GetPurchasReturnAmount;
        decimal ICashFlow.OutFlow => 0;
        string ICashFlow.GetOutFlow => "0";
        DateTime ICashFlow.TimeStamp => Meta.Created;
        string ICashFlow.GetTimeStamp => Meta.Created.ToLocalTime().ToString("u");
        string ICashFlow.Note => Note;
        #endregion
    }
}
