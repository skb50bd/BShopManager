using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    public abstract class Person {
        #region Fields
        [BsonElement("fullName")]
        public string FullName { get; set; }
        [BsonElement("nickName")]
        public string NickName { get; set; }
        [BsonElement("address")]
        public string Address { get; set; }
        [BsonElement("phone")]
        public string Phone { get; set; }
        [BsonElement("emailAddress")]
        public string EmailAddress { get; set; }

        [BsonElement("isActive")]
        public bool IsActive { get; set; }
        [BsonElement("note")]
        public string Note { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; }
        #endregion
    }
}