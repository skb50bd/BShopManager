using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Payment : ICashFlow {
        public Payment() {
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("employeeId")]
        public ObjectId EmployeeId { get; set; }
        [BsonElement("employeeName")]
        public string EmployeeName { get; set; }
        [BsonElement("amount")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Amount { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        #endregion

        #region Getters
        public string Created       => Meta.Created.ToString("dd/MM/yyyy hh:mm tt");
        public string Creator       => Meta.Creator;
        public string GetAmount     => Amount.ToString("0.##");
        public string GetEmployeeId => "EM" + EmployeeId.Increment;
        public string Modified      => Meta.Modified.ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier      => Meta.Modifier;
        public string PaymentId     => "PY" + ObjectId.Increment;
        #endregion

        #region ICashFlow Fields
        string ICashFlow.Type => "Employee Salary";
        decimal ICashFlow.InFlow => 0;
        string ICashFlow.GetInFlow => "0";
        decimal ICashFlow.OutFlow => Amount;
        string ICashFlow.GetOutFlow => GetAmount;
        DateTime ICashFlow.TimeStamp => Meta.Created;
        string ICashFlow.GetTimeStamp => Meta.Created.ToLocalTime().ToString("u");
        string ICashFlow.Note => $"Salary paid to {EmployeeId} - {EmployeeName}";
        #endregion
    }
}
