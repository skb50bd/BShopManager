using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using static ShopLibrary.GlobalConfig;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Metadata {
        public Metadata() => Create();

        public Metadata(
            DateTime created,
            string creator,
            DateTime modified,
            string modifier) {
            Created = created;
            Creator = creator;
            Modified = modified;
            Modifier = modifier;
        }

        public Metadata(
            string created,
            string creator,
            string modified,
            string modifier) {
            Created = DateTime.Parse(created);
            Creator = creator;
            Modified = DateTime.Parse(modified);
            Modifier = modifier;
        }

        public Metadata(
            DateTime created,
            string creator) {
            Created = created;
            Creator = creator;
            Modified = created;
            Modifier = creator;
        }

        public Metadata(
            string created,
            string creator) {
            Created = DateTime.Parse(created);
            Creator = creator;
            Modified = DateTime.Parse(created);
            Modifier = creator;
        }


        #region Fields

        [BsonElement("created")]
        [BsonRepresentation(BsonType.DateTime)]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Created { get; set; }

        [BsonElement("creator")]
        public string Creator { get; set; }

        [BsonElement("modified")]
        [BsonRepresentation(BsonType.DateTime)]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Modified { get; set; }

        [BsonElement("modifier")]
        public string Modifier { get; set; }

        #endregion

        public void Create() {
            Created = DateTime.Now;
            Creator = CurrentUser.UserName;
            Modified = DateTime.Now;
            Modifier = CurrentUser.UserName;
        }

        public void Modify() {
            Modified = DateTime.Now;
            Modifier = CurrentUser.UserName;
        }
    }
}
