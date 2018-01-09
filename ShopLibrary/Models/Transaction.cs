using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Transaction : ICashFlow {
        public Transaction() {
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("bankAccountId")]
        public ObjectId BankAccountId { get; set; }
        [BsonElement("bankAccountName")]
        public string BankAccountName { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("amount")]
        public decimal Amount { get; set; }
        [BsonElement("transactionType")]
        public TransactionType TransactionType { get; set; }
        [BsonElement("transactionCode")]
        public string TransactionCode { get; set; }
        [BsonElement("checkNumber")]
        public string CheckNumber { get; set; }
        [BsonElement("individual")]
        public string Individual { get; set; }
        [BsonElement("note")]
        public string Note { get; set; }
        [BsonElement("customerId")]
        public ObjectId CustomerId { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        #endregion

        #region Getters
        public string Created            => Meta.Created.ToString("dd/MM/yyyy hh:mm tt");
        public string Creator            => Meta.Creator;
        public string GetAccountId       => "B" + BankAccountId.Increment;
        public string GetAmount          => Amount.ToString("0.##");
        public string GetCustomerId      => "C" + CustomerId.Increment;
        public string GetTransactionType => TransactionType.ToString();
        public string Modified           => Meta.Modified.ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier           => Meta.Modifier;
        public string TransactionId      => "T" + ObjectId.Increment;
        #endregion

        #region ICashFlow Fields
        string ICashFlow.Type         => TransactionType == Models.TransactionType.Deposit ? "Transaction (D)" : "Transaction (W)";
        decimal ICashFlow.InFlow      => TransactionType == Models.TransactionType.Deposit ? 0 : Amount;
        string ICashFlow.GetInFlow    => TransactionType == Models.TransactionType.Deposit ? "0" : GetAmount;
        decimal ICashFlow.OutFlow     => TransactionType == Models.TransactionType.Deposit ? Amount : 0;
        string ICashFlow.GetOutFlow   => TransactionType == Models.TransactionType.Deposit ? GetAmount : "0";
        DateTime ICashFlow.TimeStamp  => Meta.Created;
        string ICashFlow.GetTimeStamp => Meta.Created.ToLocalTime().ToString("u");
        string ICashFlow.Note         => Note;
        #endregion
    }
}