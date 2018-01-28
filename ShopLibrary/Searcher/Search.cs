using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;

namespace ShopLibrary.Searcher {
    public static class Search {
        #region Product Searching
        public static Product SearchSingleProductByText(string text, List<Product> context = null) {
            text = text.ToLowerInvariant();
            string[] texts = text.Split();

            if (text.Length == 0)
                return new Product { ObjectId = ObjectId.Empty };
            if (texts.Length == 1) {
                if (int.TryParse(text, out int id))
                    return context?.Find(p => p.ProductId.ToLowerInvariant().Contains(text)) ??
                           Products.Find(p => p.ProductId.ToLowerInvariant().Contains(text));
                if (text[0] == 'p')
                    return context?.Find(p => p.ProductId.ToLowerInvariant().StartsWith(text)) ??
                           Products.Find(p => p.ProductId.ToLowerInvariant().StartsWith(text));
                return context?.Find(p => p.ProductName.ToLowerInvariant().Contains(text)) ??
                       Products.Find(p => p.ProductName.ToLowerInvariant().Contains(text));
            }
            return context?.Find(p => p.ProductName.ToLowerInvariant().Contains(text)) ??
                   Products.Find(p => p.ProductName.ToLowerInvariant().Contains(text));
        }

        public static List<Product> SearchProductsByText(string text, List<Product> context = null) {
            text = text.ToLowerInvariant();
            string[] texts = text.Split();

            if (text.Length == 0)
                return context ?? Products;

            if (texts.Length != 1)
                return context?.Where(p => p.ProductName.ToLowerInvariant().Contains(text)).ToList() ??
                       Products.Where(p => p.ProductName.ToLowerInvariant().Contains(text)).ToList();

            if (int.TryParse(text, out int id))
                return context?.Where(p => p.ProductId.ToLowerInvariant().StartsWith(text)).ToList() ??
                       Products.Where(p => p.ProductId.ToLowerInvariant().StartsWith(text)).ToList();
            if (text[0] == 'p')
                return context?.Where(p =>
                           p.ProductId.ToLowerInvariant().StartsWith(text) ||
                           p.ProductName.ToLowerInvariant().Contains(text)).ToList() ??
                       Products.Where(p =>
                           p.ProductId.ToLowerInvariant().StartsWith(text) ||
                           p.ProductName.ToLowerInvariant().Contains(text)).ToList();
            return context?.Where(p => p.ProductName.ToLowerInvariant().Contains(text)).ToList() ??
                   Products.Where(p => p.ProductName.ToLowerInvariant().Contains(text)).ToList();

        }

        public static List<Product> SearchProductsByShop(Shop shop, List<Product> context = null) {
            return context?.Where(p => p.ShopId == shop.ObjectId).ToList() ??
                   Products.Where(p => p.ShopId == shop.ObjectId).ToList();
        }
        #endregion

        #region Customer Searching
        public static Customer SearchSingleCustomerByText(string text, List<Customer> context = null) {
            text = text.ToLowerInvariant();
            string[] texts = text.Split();
            if (text.Length == 0)
                return new Customer();

            if (texts.Length == 1)
            {
                if (int.TryParse(text, out int id))
                    return context?.Find(c => c.ObjectId.Increment == id) ??
                           Customers.Find(c => c.ObjectId.Increment == id);

                return context?.Find(c =>
                           c.FullName.ToLowerInvariant().Contains(text) ||
                           c.CustomerId.ToLowerInvariant().Contains(text)) ??
                       Customers.Find(c =>
                           c.FullName.ToLowerInvariant().Contains(text) ||
                           c.CustomerId.ToLowerInvariant().Contains(text));
            }
            if (text[0] == 'c' && int.TryParse(texts[0].Substring(1), out int id2))
                return context?.Find(c => c.ObjectId.Increment == id2) ??
                       Customers.Find(c => c.ObjectId.Increment == id2);
            return context?.Find(c => c.FullName.ToLowerInvariant().Contains(text)) ??
                   Customers.Find(c => c.FullName.ToLowerInvariant().Contains(text));
        }

        public static List<Customer> SearchCustomersByText(string text, List<Customer> context = null) {
            text = text.ToLowerInvariant();
            string[] texts = text.Split();
            if (text.Length == 0)
                return context ?? Customers;

            if (texts.Length == 1) {
                if (int.TryParse(text, out int id))
                    return context?.Where(c => c.ObjectId.Increment == id).ToList() ??
                           Customers.Where(c => c.ObjectId.Increment == id).ToList();
                return context?.Where(c =>
                           c.FullName.ToLowerInvariant().Contains(text) ||
                           c.CompanyName.ToLowerInvariant().Contains(text) ||
                           c.CustomerId.ToLowerInvariant().Contains(text)).ToList() ??
                       Customers.Where(c =>
                           c.FullName.ToLowerInvariant().Contains(text) ||
                           c.CompanyName.ToLowerInvariant().Contains(text) ||
                           c.CustomerId.ToLowerInvariant().Contains(text)).ToList();
            }
            return context?.Where(c => c.FullName.ToLowerInvariant().Contains(text) ||
                                       c.CompanyName.ToLowerInvariant().Contains(text)).ToList() ??
                   Customers.Where(c => c.FullName.ToLowerInvariant().Contains(text) ||
                                        c.CompanyName.ToLowerInvariant().Contains(text)).ToList();
        }
        #endregion
    }
}