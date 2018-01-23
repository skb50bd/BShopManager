using System;
using System.Linq;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;

namespace ConsoleUI
{
    public class ReadDatabase
    {
        private static string command;

        public static void ReadCustomers()
        {
            Console.WriteLine($"Customers : \t{Customers.Count}." +
                              "\n\tTotal Due : \t" +
                              $"{Customers.Sum(c => c.Debt).ToString("0.##") + " Tk"} " +
                              $"({Customers.Count(c => c.Debt > 0)})");
            Console.Write("Show List? (y/N) : ");
            command = Console.ReadLine();
            if (command.ToLower() == "y")
            {
                Console.WriteLine("ID".PadLeft(6) + " " +
                                  "Name".PadRight(35) + " " +
                                  "Phone".PadLeft(15) + " " +
                                  "Due".PadLeft(10));
                foreach (Customer customer in Customers)
                {
                    Console.WriteLine(customer.CustomerId.PadLeft(6) + " " +
                                      customer.FullName.PadRight(35) + " " +
                                      customer.Phone.PadLeft(15) + " " +
                                      customer.GetDebt.PadLeft(10));
                }
            }
            Console.WriteLine("\n\n");
        }

        public static void ReadSuppliers()
        {
            Console.WriteLine($"Suppliers : \t{Suppliers.Count}." +
                              $"\n\tTotal Payable: \t{Suppliers.Sum(s => s.Payable).ToString("0.##") + " Tk"} ({Suppliers.Count(s => s.Payable > 0)})");
            Console.Write("Show List? (y/N) : ");
            command = Console.ReadLine();
            if (command.ToLower() == "y")
            {
                Console.WriteLine("ID".PadLeft(6) + " " +
                                  "Name".PadRight(35) + " " +
                                  "Phone".PadLeft(15) + " " +
                                  "Payable".PadLeft(10));
                foreach (Supplier supplier in Suppliers)
                {
                    Console.WriteLine(supplier.SupplierId.PadLeft(6) + " " +
                                      supplier.FullName.PadRight(35) + " " +
                                      supplier.Phone.PadLeft(15) + " " +
                                      supplier.GetPayable.PadLeft(10));
                }
            }
            Console.WriteLine("\n\n");
        }

        public static void ReadProducts()
        {
            Console.WriteLine($"Products : \t{Products.Count}" +
                              $"\n\tLow Stock : \t{Products.Count(c => c.StockIsLow && c.TotalStock > 0)}" +
                              $"\n\tEmpty Stock : \t{Products.Count(c => c.TotalStock == 0.0)}" +
                              $"\n\tPurchase Worth : \t{Products.Sum(p => p.PurchasePrice * (decimal)p.TotalStock).ToString("0.##")}");
            Console.Write("Show List? (y/N) : ");
            command = Console.ReadLine();
            if (command.ToLower() == "y")
            {
                Console.WriteLine("ID".PadLeft(6) + " " +
                                  "Name".PadRight(35) + " " +
                                  "Stock".PadLeft(15) + " " +
                                  "Prc. Price".PadRight(10) + " " +
                                  "Ret Price".PadRight(10));
                foreach (Product product in Products)
                {
                    Console.WriteLine(product.ProductId.PadLeft(6) + " " +
                                      product.ProductName.PadRight(35) + " " +
                                      $"{product.GetTotalStock} {product.GetDefaultUnitName}".PadLeft(15) + " " +
                                      $"{product.GetPurchasePrice} Tk".PadRight(10) + " " +
                                      $"{product.GetRetailPrice} Tk".PadRight(10));
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}