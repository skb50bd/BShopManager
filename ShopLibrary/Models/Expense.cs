using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Expense : ICashFlow {
        public Expense() {
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("totalAmount")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal TotalAmount { get; set; }
        [BsonElement("cart")]
        public List<ShoppingCart> Cart { get; set; } = new List<ShoppingCart>();
        [BsonElement("note")]
        public string Note { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        #endregion

        #region Getters
        public string Created                  => Meta.Created.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Creator                  => Meta.Creator;
        public string ExpenseId                => "EX" + ObjectId.Increment;
        public string GetTotalAmount           => TotalAmount.ToString("0.##");
        public string Modified                 => Meta.Modified.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier                 => Meta.Modifier;
        #endregion

        public void AddToCart(ShoppingCart sc) => Cart.Add(sc);

        #region ICashFlow Members
        string ICashFlow.Id => ExpenseId;
        string ICashFlow.Type => "Expense";
        decimal ICashFlow.InFlow => 0;
        string ICashFlow.GetInFlow => "0";
        decimal ICashFlow.OutFlow => TotalAmount;
        string ICashFlow.GetOutFlow => GetTotalAmount;
        DateTime ICashFlow.TimeStamp => Meta.Created;
        string ICashFlow.GetTimeStamp => Meta.Created.ToLocalTime().ToString("u");
        string ICashFlow.Note => Note;
        #endregion
    }
}