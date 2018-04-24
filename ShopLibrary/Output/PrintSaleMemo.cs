using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using MongoDB.Bson;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;

namespace ShopLibrary.Output {
    public static class PrintSaleMemo {
        public static void ToPdf (Memo memo) {
            string infilename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                              + @"\Brotal\SaleMemorandumTemp.pdf";

            if (!File.Exists(infilename)) {
                Debug.WriteLine("The template sale memo is missing from the application directory\n"
                              + "Cannot print the sale memo");

                return;
            }

            string outfilename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                               + @"\Brotal\"
                               + memo.SaleId
                               + ".pdf";

            using ( FileStream outFile = new FileStream(outfilename, FileMode.Create) ) {
                PdfReader  reader  = new PdfReader(infilename);
                PdfStamper stamper = new PdfStamper(reader, outFile);
                AcroFields form    = stamper.AcroFields;


                // STAMPING
                form.SetField("ShopName", memo.ShopName);
                form.SetField("ShopAddress", memo.Address);
                form.SetField("ShopContacts", memo.ShopContacts);
                form.SetField("Date", memo.DealTime.ToLocalTime().ToString("dd MMM yyyy"));
                form.SetField("Memo", memo.SaleId);

                if (memo.CustomerId != ObjectId.Empty) {
                    form.SetField("Customer Id", memo.GetCustomerId);
                    form.SetField("Customer Phone", Customers.Single(c => c.ObjectId == memo.CustomerId).Phone);
                }
                else {
                    form.SetField("Customer Id", "N/A");
                    form.SetField("Customer Phone", "N/A");
                }

                form.SetField("Customer Name", memo.CustomerName);
                form.SetField("Customer Company", memo.CustomerCompany);
                form.SetField("Customer Address", memo.CustomerAddress);

                // FILL UP THE TABLE
                int i = 1;

                foreach (ShoppingCart sc in memo.Cart) {
                    form.SetField("Row" + i, i.ToString("00"));
                    form.SetField("DescriptionRow" + i, sc.GetProductId + " - " + sc.ProductName);
                    form.SetField("Unit PriceRow" + i, sc.GetUnitPrice + "/" + sc.GetUnitName);
                    form.SetField("QuantityRow" + i, sc.GetQuantity + " " + sc.GetUnitName);
                    form.SetField("Net PriceRow" + i, sc.GetNetPrice + " Tk");
                    i++;
                }

                form.SetField("TotalPrice", memo.GetTotalAmount);
                form.SetField("Discount", memo.GetLess + $"({memo.GetDiscount}%)");
                form.SetField("PreviousDue", memo.PreviousDue?.ToString("C"));
                form.SetField("TotalPayable", (memo.TotalPayable).ToString("C"));
                form.SetField("Paid", memo.GetPaid);
                form.SetField("CurrentDue", (memo.CurrentDue).ToString("C"));
                form.SetField("Quotation", "Thanks for shopping with us");

                stamper.Close();
                reader.Close();

                foreach (KeyValuePair<string, AcroFields.Item> field in form.Fields)
                    form.SetFieldProperty(field.Key, "readonly", true, null);

                Process.Start(outfilename);
            }
        }
    }
}
