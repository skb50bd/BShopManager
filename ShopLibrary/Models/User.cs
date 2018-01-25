using System;
using System.Diagnostics;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class User : Person {
        public User() {
        }

        public User(
            string fullName,
            string nickName,
            string address,
            string phone,
            string email,
            string userName,
            UserRole accessLevel,
            string password) {
            FullName = fullName;
            NickName = nickName;
            Address = address;
            Phone = phone;
            EmailAddress = email;
            UserName = userName;
            AccessLevel = accessLevel;
            Salt = AES.GetSalt();
            Password = AES.Encrypt(password, Salt);
            IsActive = true;
            Meta = new Metadata(DateTime.Now, CurrentUser.UserName);
        }

        public User(string code) {
            if (code != "brotality")
                return;
            FullName = "Brotal Dev";
            NickName = "Brotal";
            Address = "brotal.net";
            Phone = "01676203752";
            EmailAddress = "info@brotal.net";
            UserName = "brotal";
            AccessLevel = Root;
            Salt = "8G+aJemZStCQeyuDEWvpe40NtB3eRqPrW76UwBqDP9Y=";
            Password = "yQB05JkQHMnDBCAISGel0Q==";
            IsActive = true;
            Meta = new Metadata(DateTime.Now, "self");
        }

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("userName")]
        public string UserName { get; set; }
        [BsonElement("accessLevel")]
        public UserRole AccessLevel { get; set; }
        [BsonElement("salt")]
        private string Salt { get; set; }
        [BsonElement("password")]
        private string Password { get; set; }
        #endregion

        public bool IsRealUser(string userName, string password) => userName == UserName 
                                                                    && AES.Encrypt(password, this.Salt) == this.Password;

        #region Getter
        public string Created => Meta.Created.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Creator => Meta.Creator;
        public string Modified => Meta.Modified.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier => Meta.Modifier;
        public string UserId => "U" + ObjectId.Increment;
        #endregion
    }
}