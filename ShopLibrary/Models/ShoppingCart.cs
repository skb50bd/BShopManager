using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class ShoppingCart {
        public ShoppingCart() {
            ProductId = ObjectId.Empty;
        }

        #region Fields
        [BsonElement("productName")]
        public string ProductName { get; set; }
        [BsonElement("productId")]
        public ObjectId ProductId { get; set; }
        [BsonElement("quantity")]
        [BsonRepresentation(BsonType.Double)]
        public float Quantity { get; set; }
        [BsonElement("unit")]
        public Unit Unit { get; set; }
        [BsonElement("unitPrice")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal UnitPrice { get; set; }
        [BsonElement("unitPurchasePrice")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal UnitPurchasePrice { get; set; }
        #endregion

        #region Getters & Setters
        public decimal BaseUnitPrice         => UnitPrice * (decimal)Unit.Weight;
        public decimal BaseUnitPurchasePrice => UnitPurchasePrice * (decimal)Unit.Weight;
        public decimal NetPrice {
            get => (decimal)Quantity * UnitPrice;
            set => UnitPrice = Quantity != 0.00
                ? value / (decimal)Quantity
                : 0;
        }
        public decimal NetPurchasePrice        => (decimal)Quantity * UnitPurchasePrice;
        public decimal Profit                  => NetPrice - NetPurchasePrice;
        public float BaseQuantity              => Unit.ToBaseUnit(Quantity, Unit);
        public string GetBaseQuantity          => BaseQuantity.ToString("0.##");
        public string GetBaseUnitPrice         => BaseUnitPrice.ToString("0.##");
        public string GetBaseUnitPurchasePrice => BaseUnitPurchasePrice.ToString("0.##");
        public string GetNetPrice              => NetPrice.ToString("0.##");
        public string GetNetPurchasePrice      => NetPurchasePrice.ToString("0.##");
        public string GetProductId             => "P" + ProductId.Increment;
        public string GetProfit                => Profit.ToString("0.##");
        public string GetQuantity              => Quantity.ToString("0.##");
        public string GetUnitName              => Unit.UnitName;
        public string GetUnitPrice             => UnitPrice.ToString("0.##");
        public string GetUnitPurchasePrice     => UnitPurchasePrice.ToString("0.##");
        public string GetUnitWeight            => Unit.Weight.ToString("0.##");
        public string Signature                => GetProductId + " - " + ProductName;
        #endregion

        #region Operator Overloads
        public static ShoppingCart operator -(ShoppingCart left, ShoppingCart right) {
            if (left?.ProductId == right?.ProductId
                && left?.ProductName == right?.ProductName) {
                left.Quantity = (left.BaseQuantity - right.BaseQuantity) * left.Unit.Weight;
            }
            return left;
        }

        public static ShoppingCart operator +(ShoppingCart left, ShoppingCart right) {
            if (left?.ProductId == right?.ProductId
                && left?.ProductName == right?.ProductName) {
                left.Quantity = (left.BaseQuantity + right.BaseQuantity) * left.Unit.Weight;
            }
            return left;
        }

        public static bool operator ==(ShoppingCart left, ShoppingCart right) {
            return left?.ProductId == right?.ProductId
                   && left?.ProductName == right?.ProductName
                   && left?.BaseQuantity == right?.BaseQuantity;
        }

        public static bool operator !=(ShoppingCart left, ShoppingCart right) {
            return left?.ProductId != right?.ProductId
                   || left?.ProductName != right?.ProductName
                   || left?.BaseQuantity != right?.BaseQuantity;
        }
        protected bool Equals(ShoppingCart other) => string.Equals(ProductName, other.ProductName) && ProductId.Equals(other.ProductId) && Quantity.Equals(other.Quantity) && Equals(Unit, other.Unit) && UnitPrice == other.UnitPrice && UnitPurchasePrice == other.UnitPurchasePrice;

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ShoppingCart)obj);
        }

        public override int GetHashCode() {
            unchecked {
                int hashCode = (ProductName != null ? ProductName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ ProductId.GetHashCode();
                hashCode = (hashCode * 397) ^ Quantity.GetHashCode();
                hashCode = (hashCode * 397) ^ (Unit != null ? Unit.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ UnitPrice.GetHashCode();
                hashCode = (hashCode * 397) ^ UnitPurchasePrice.GetHashCode();
                return hashCode;
            }
        }
        #endregion

        public override string ToString() => GetProductId + " - " + ProductName;
    }
}