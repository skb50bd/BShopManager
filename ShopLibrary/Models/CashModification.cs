using System;
using iTextSharp.text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models
{
    [BsonIgnoreExtraElements]
    public class CashModification : ICashFlow
    {
        public CashModification()
        {
            ObjectId = ObjectId.Empty;
            PreviousBalance = 0;
            NewBalance = 0;
            Meta = new Metadata();
            Note = "";
        }

        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("previousBalance")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal PreviousBalance { get; set; }
        [BsonElement("newBalance")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal NewBalance { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; }
        [BsonElement("note")]
        public string Note { get; set; }

        #region ICashFlow Fields
        string ICashFlow.Type => PreviousBalance > NewBalance ? "Cash Decrease" : "Cash Increase";
        decimal ICashFlow.InFlow => PreviousBalance > NewBalance ? 0 : PreviousBalance - NewBalance;
        string ICashFlow.GetInFlow => PreviousBalance > NewBalance ? "0" : (PreviousBalance - NewBalance).ToString("0.##");
        decimal ICashFlow.OutFlow => PreviousBalance > NewBalance ? (PreviousBalance - NewBalance) : 0;
        string ICashFlow.GetOutFlow => PreviousBalance > NewBalance ? (PreviousBalance - NewBalance).ToString("0.##") : "0";
        DateTime ICashFlow.TimeStamp => Meta.Created;
        string ICashFlow.GetTimeStamp => Meta.Created.ToLocalTime().ToString("u");
        string ICashFlow.Note => Note;
        #endregion
    }
}