using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using static ShopLibrary.GlobalConfig;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Session {
        public Session() {
            ObjectId   = new ObjectId();
            UserId     = CurrentUser.ObjectId;
            UserName   = CurrentUser.UserName;
            LogoutTime = DateTime.Now;
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("logoutTime")]
        public DateTime LogoutTime { get; set; }
        [BsonElement("userId")]
        public ObjectId UserId { get; set; }
        [BsonElement("userName")]
        public string UserName { get; set; }
        #endregion

        #region Getters
        public string SessionId   => "SessionId_" + ObjectId.Increment;
        public DateTime LoginTime => ObjectId.CreationTime.ToLocalTime();
        #endregion
    }
}
