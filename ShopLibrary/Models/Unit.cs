using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Unit {
        public Unit() {
            UnitName = "pcs";
            Weight   = 1;
        }

        public Unit(string unitName, float weight) {
            UnitName = unitName;
            Weight   = weight;
        }

        #region Fields
        [BsonElement("unitName")]
        public string UnitName { get; set; }
        [BsonElement("weight")]
        [BsonRepresentation(BsonType.Double)]
        public float Weight { get; set; }
        #endregion

        public static float ToBaseUnit(float quantity, Unit unit) => unit.Weight != 0
                                                                        ? quantity / unit.Weight
                                                                        : 0;
        public override string ToString() => UnitName + " [" + Weight.ToString("0.##") + "]";
    }
}