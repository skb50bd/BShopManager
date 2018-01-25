using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Employee : Person {
        public Employee() {
            Meta = new Metadata();
            IsActive = true;
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("designation")]
        public string Designation { get; set; }
        [BsonElement("nationalIdN")]
        public string NationalIdN { get; set; }
        [BsonElement("currentBalance")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Balance { get; set; }
        [BsonElement("monthlySalary")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal MonthlySalary { get; set; }
        [BsonElement("joinDate")]
        public DateTime JoinDate { get; set; } = DateTime.Today;
        #endregion

        #region Getters
        public string Created          => Meta.Created.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Creator          => Meta.Creator;
        public string EmployeeId       => "EM" + ObjectId.Increment;
        public string GetBalance       => Balance.ToString("0.##");
        public string GetJoinDate      => JoinDate.ToLocalTime().ToString("dd/MM/yyyy");
        public string GetMonthlySalary => MonthlySalary.ToString("0.##");
        public string Modified         => Meta.Modified.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier         => Meta.Modifier;
        #endregion

        public override string ToString() => FullName;
    }
}
