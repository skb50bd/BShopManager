using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopLibrary.Models {
    [BsonIgnoreExtraElements]
    public class Product {
        public Product() => ObjectId = ObjectId.Empty;

        #region Fields
        [BsonId]
        public ObjectId ObjectId { get; set; }
        [BsonElement("shopId")]
        public ObjectId ShopId { get; set; } // Product Belonging to Unique Shop
        [BsonElement("productName")]
        public string ProductName { get; set; }
        [BsonElement("manufacturer")]
        public string Manufacturer { get; set; }
        [BsonElement("units")]
        public List<Unit> Units { get; set; } = new List<Unit>(); // The list of units (Name, Weightage)
        [BsonElement("shopStock")]
        [BsonRepresentation(BsonType.Double)]
        public float ShopStock { get; set; } // Stock in Shop
        [BsonElement("godownStock")]
        [BsonRepresentation(BsonType.Double)]
        public float GodownStock { get; set; } // Stock in Godown
        [BsonElement("alertStock")]
        [BsonRepresentation(BsonType.Double)]
        public float AlertStock { get; set; } // Will be Alerted if the Stock comes down to this number
        [BsonElement("purchasePrice")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal PurchasePrice { get; set; }
        [BsonElement("retailPrice")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal RetailPrice { get; set; } // Retail Price for a Single Unit
        [BsonElement("wholeSalePrice")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal WholeSalePrice { get; set; } // Whole Sale Price for a Single Unit
        [BsonElement("mrp")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Mrp { get; set; } // Price labeled on the Product
        [BsonElement("category")]
        public string Category { get; set; }
        [BsonElement("specification")]
        public string Specification { get; set; } // Major Attribute of the Product
        [BsonElement("notes")]
        public string Notes { get; set; }
        [BsonElement("meta")]
        public Metadata Meta { get; set; } = new Metadata();
        #endregion

        #region Getters
        public bool StockIsLow                           => TotalStock <= AlertStock;
        public decimal PurchasePriceByUnit(Unit unit)    => unit.Weight != 0 ? PurchasePrice / (decimal)unit.Weight : PurchasePrice;
        public decimal RetailPriceByUnit(Unit unit)      => unit.Weight != 0 ? RetailPrice / (decimal)unit.Weight : RetailPrice;
        public decimal WholeSalePriceByUnit(Unit unit)   => unit.Weight != 0 ? WholeSalePrice / (decimal)unit.Weight : WholeSalePrice;
        public float TotalStock                          => ShopStock + GodownStock;
        public string Created                            => Meta.Created.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Creator                            => Meta.Creator;
        public string DefaultUnitName                    => Units.Count > 0 ? Units.First().UnitName : "";
        public string GetAlertStock                      => AlertStock.ToString("0.##");
        public string GetGodownStock                     => GodownStock.ToString("0.##");
        public string GetMrp                             => Mrp.ToString("0.##");
        public string GetPurchasePrice                   => PurchasePrice.ToString("0.##");
        public string GetPurchasePriceByUnit(Unit unit)  => PurchasePriceByUnit(unit).ToString("0.##");
        public string GetRetailPrice                     => RetailPrice.ToString("0.##");
        public string GetRetailPriceByUnit(Unit unit)    => RetailPriceByUnit(unit).ToString("0.##");
        public string GetShopId                          => "SP" + ShopId.Increment;
        public string GetShopStock                       => ShopStock.ToString("0.##");
        public string GetTotalStock                      => TotalStock.ToString("0.##"); // Stock in Total
        public string GetWholeSalePrice                  => WholeSalePrice.ToString("0.##");
        public string GetWholeSalePriceByUnit(Unit unit) => WholeSalePriceByUnit(unit).ToString("0.##");
        public string Modified                           => Meta.Modified.ToLocalTime().ToString("dd/MM/yyyy hh:mm tt");
        public string Modifier                           => Meta.Modifier;
        public string ProductId                          => "P" + ObjectId.Increment;
        public string Signature                          => ProductId + " - " + ProductName;
        #endregion
        public override string ToString() => ProductName;
    }
}