using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;

namespace ShopLibrary.Output
{
    public static class PrintSaleMemo
    {
        public static void ToPdf(Sale sale, Shop shop, Customer customer)
        {
            string infilename = "SaleMemorandumTemp.pdf";
            if (!File.Exists(infilename))
            {
                Debug.WriteLine("The template sale memo is missing from the application directory\n" +
                                "Cannot print the sale memo");
                return;
            }
            string outfilename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                             + @"\Brotal\" + sale.SaleId + ".pdf";

            using (FileStream outFile = new FileStream(outfilename, FileMode.Create))
            {

                PdfReader reader = new PdfReader(infilename);
                PdfStamper stamper = new PdfStamper(reader, outFile);
                AcroFields form = stamper.AcroFields;


                // STAMPING
                form.SetField("ShopName", shop.ShopName);
                form.SetField("ShopAddress", shop.Address);
                form.SetField("ShopContacts",
                    string.Join(", ", shop.ContactNumbers) + " - " + string.Join(", ", shop.EmailAddresses));
                form.SetField("Date", sale.DealTime.ToLocalTime().ToString("dd/mm/yyyy hh:mm tt"));
                form.SetField("Memo", sale.SaleId);
                form.SetField("Customer Id", sale.GetCustomerId);
                form.SetField("Customer Name", sale.CustomerName);
                form.SetField("Customer Company", sale.CustomerCompany);
                form.SetField("Customer Address", sale.CustomerAddress);
                form.SetField("Customer Phone", Customers.SingleOrDefault(c => c.ObjectId == sale.CustomerId).Phone);

                // FILL UP THE TABLE
                int i = 1;
                foreach (ShoppingCart sc in sale.Cart)
                {
                    form.SetField("Row" + i, i.ToString("00"));
                    form.SetField("DescriptionRow" + i, sc.GetProductId + " - " + sc.ProductName);
                    form.SetField("Unit PriceRow" + i, sc.GetUnitPrice + "/" + sc.GetUnitName);
                    form.SetField("QuantityRow" + i, sc.GetQuantity + " " + sc.GetUnitName);
                    form.SetField("Net PriceRow" + i, sc.GetNetPrice + " Tk");
                    i++;
                }

                form.SetField("TotalPrice", sale.GetTotalAmount);
                form.SetField("Discount", sale.GetLess + $"({sale.GetDiscount}%)");
                form.SetField("PreviousDue", customer.GetDebt);
                form.SetField("TotalPayable", (customer.Debt + sale.Payable).ToString("0.##"));
                form.SetField("Paid", sale.GetPaid);
                form.SetField("CurrentDue", (sale.Payable - sale.Paid).ToString("0.##"));
                form.SetField("Quotation", "Thanks for shopping with us");
                // TODO - Complete These Fields

                stamper.Close();
                reader.Close();

                foreach (KeyValuePair<string, AcroFields.Item> field in form.Fields)
                    form.SetFieldProperty(field.Key, "readonly", true, null);

                Process.Start(outfilename);
            }
        }
    }
}
