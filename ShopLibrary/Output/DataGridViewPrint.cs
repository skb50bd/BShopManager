using iTextSharp.text;
using iTextSharp.text.pdf;
using ShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;

namespace ShopLibrary.Prints {
    public static class DataGridViewPrint {
        public static void PrintCustomerStatementToPdf (
            this ICustomerReport customerReport,
            string               strPdfPath)
        {
            var fs = new FileStream(strPdfPath,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None);

            var document = new Document();
            document.SetPageSize(PageSize.A4);
            var writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            var color = new BaseColor(0, 0, 0);

            //Report Header
            var bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,
                BaseFont.CP1252,
                BaseFont.NOT_EMBEDDED);
            var fntHead = new Font(bfntHead, 16, 1, color);
            var prgHeading = new Paragraph {
                Alignment = Element.ALIGN_CENTER
            };
            prgHeading.Add(new Chunk("[STATEMENT]\n" + customerReport.Customer,
                fntHead));
            document.Add(prgHeading);

            //Author
            var prgAuthor = new Paragraph();
            var btnAuthor = BaseFont.CreateFont(BaseFont.COURIER,
                BaseFont.CP1252,
                BaseFont.NOT_EMBEDDED);
            var fntAuthor = new Font(btnAuthor, 11, 2, color);
            prgAuthor.Alignment = Element.ALIGN_LEFT;
            prgAuthor.Add(new Chunk(
                $"\n{"Name",-14} : {customerReport.Customer.FullName}",
                fntAuthor));
            prgAuthor.Add(new Chunk(
                $"\n{"Company",-14} : {customerReport.Customer.CompanyName}",
                fntAuthor));
            prgAuthor.Add(new Chunk(
                $"\n{"Address",-14} : {customerReport.Customer.Address}",
                fntAuthor));
            prgAuthor.Add(new Chunk(
                $"\n{"Phone",-14} : {customerReport.Customer.Phone}",
                fntAuthor));
            prgAuthor.Add(new Chunk(
                $"\n{"Current Due",-14} : {customerReport.Customer.GetDebt} BDT",
                fntAuthor));
            prgAuthor.Add(new Chunk(
                $"\n{"Sale",-14} : {customerReport.SalesPriceTotal:C2} BDT ({customerReport.NumberOfSales:N0})",
                fntAuthor));
            prgAuthor.Add(new Chunk(
                $"\n{"Due Collection",-14} : {customerReport.TotalDebtCollection:C2} BDT ({customerReport.NumberOfDebtCollections:N0})",
                fntAuthor));
            prgAuthor.Add(new Chunk(
                $"\n{"Refund",-14} : {customerReport.TotalRefund:C2} BDT ({customerReport.NumberOfRefunds:N0})",
                fntAuthor));
            prgAuthor.Add(new Chunk(
                $"\n{"Date",-14} : {DateTime.Now.ToLocalTime().ToLongDateString()}",
                fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            var p = new Paragraph(new Chunk(
                new iTextSharp.text.pdf.draw.LineSeparator(0.0F,
                    100.0F,
                    color,
                    Element.ALIGN_LEFT,
                    1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            var table = new PdfPTable(5) {
                WidthPercentage = 100f
            };
            var widths = new[] {15f, 15f, 15f, 15f, 40f};
            table.SetWidths(widths);

            //Table header
            var btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,
                BaseFont.CP1252,
                BaseFont.NOT_EMBEDDED);
            var fntColumnHeader = new Font(btnColumnHeader, 10, 1, color);

            var cell = new PdfPCell();
            cell.AddElement(new Chunk("Type", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Id", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Amount", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Due", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Date", fntColumnHeader));
            table.AddCell(cell);


            //table Data
            foreach (var item in customerReport.CustomerReportables)
            {
                //cell = new PdfPCell(new Phrase(item.Type)) {
                //    HorizontalAlignment = Element.ALIGN_RIGHT
                //};
                table.AddCell(item.Type);
                table.AddCell(item.Id);
                table.AddCell(item.Amount);
                table.AddCell(item.Due);
                table.AddCell(item.TimeStamp);
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }

        public static void PrintDueListToPdf (List<Customer> C,
            String                                           strPdfPath,
            string                                           strHeader)
        {
            var fs = new FileStream(strPdfPath,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None);
            var document = new Document();
            document.SetPageSize(PageSize.A4);
            var writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            var color = new BaseColor(0, 0, 0);

            //Report Header
            var bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,
                BaseFont.CP1252,
                BaseFont.NOT_EMBEDDED);
            var fntHead = new Font(bfntHead, 16, 1, color);
            var prgHeading = new Paragraph {
                Alignment = Element.ALIGN_CENTER
            };
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            var prgAuthor = new Paragraph();
            var btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,
                BaseFont.CP1252,
                BaseFont.NOT_EMBEDDED);
            var fntAuthor = new Font(btnAuthor, 11, 2, color);
            prgAuthor.Alignment = Element.ALIGN_LEFT;
            prgAuthor.Add(new Chunk(
                "Date: " + DateTime.Now.ToLocalTime().ToLongDateString(),
                fntAuthor));
            prgAuthor.Add(new Chunk(
                $"\nTotal Due: {C.Sum(c => c.Debt):C2} BDT",
                fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            var p = new Paragraph(new Chunk(
                new iTextSharp.text.pdf.draw.LineSeparator(0.0F,
                    100.0F,
                    color,
                    Element.ALIGN_LEFT,
                    1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            var table = new PdfPTable(5) {
                WidthPercentage = 100f
            };
            var widths = new float[] {10f, 26f, 14f, 20f, 28f};
            table.SetWidths(widths);

            //Table header
            var btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,
                BaseFont.CP1252,
                BaseFont.NOT_EMBEDDED);
            var fntColumnHeader = new Font(btnColumnHeader, 10, 1, color);

            var cell = new PdfPCell();
            cell.AddElement(new Chunk("ID", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Name", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Due", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Phone No", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Adress", fntColumnHeader));
            table.AddCell(cell);


            //table Data
            foreach (var customer in C)
            {
                cell = new PdfPCell(new Phrase(customer.GetDebt)) {
                    HorizontalAlignment = Element.ALIGN_RIGHT
                };
                table.AddCell(customer.CustomerId);
                table.AddCell(customer.FullName);
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(customer.Phone)) {
                    HorizontalAlignment = Element.ALIGN_RIGHT
                };
                table.AddCell(cell);
                table.AddCell(customer.Address);
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }

        public static void PrintInventoryToPdf (Shop shop,
            List<Product>                            P,
            string                                   strPdfPath,
            bool                                     includePurchaseInfo)
        {
            {
                var fs = new FileStream(strPdfPath,
                    FileMode.Create,
                    FileAccess.Write,
                    FileShare.None);

                var document = new Document();
                document.SetPageSize(PageSize.A4);
                var writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                var color = new BaseColor(0, 0, 0);

                //Report Header
                var bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,
                    BaseFont.CP1252,
                    BaseFont.NOT_EMBEDDED);
                var fntHead = new Font(bfntHead, 16, 1, color);
                var prgHeading = new Paragraph {
                    Alignment = Element.ALIGN_CENTER
                };
                prgHeading.Add(new Chunk("[INVENTORY]\n" + shop.ShopName,
                    fntHead));
                document.Add(prgHeading);

                //Author
                var prgAuthor = new Paragraph();
                var btnAuthor = BaseFont.CreateFont(BaseFont.COURIER,
                    BaseFont.CP1252,
                    BaseFont.NOT_EMBEDDED);
                var fntAuthor = new Font(btnAuthor, 11, 2, color);
                prgAuthor.Alignment = Element.ALIGN_LEFT;
                prgAuthor.Add(new Chunk(
                    $"\n{"Products: ",-14} : {P.Count}",
                    fntAuthor));
                prgAuthor.Add(new Chunk(
                    $"\n{"Low Stock: ",-14} : {P.Count(pr => pr.StockIsLow)}",
                    fntAuthor));

                if (includePurchaseInfo)
                {
                    prgAuthor.Add(new Chunk(
                        $"\n{"Worth in Stock",-14} : {P.Sum(pr => pr.PurchasePrice * (decimal) pr.TotalStock):C2}",
                        fntAuthor));
                    prgAuthor.Add(new Chunk(
                        $"\n{"Worth in Shop",-14} : {P.Sum(pr => pr.PurchasePrice * (decimal) pr.ShopStock):C2}",
                        fntAuthor));
                    prgAuthor.Add(new Chunk(
                        $"\n{"Worth in Godown",-14} : {P.Sum(pr => pr.PurchasePrice * (decimal) pr.GodownStock):C2}",
                        fntAuthor));
                }

                prgAuthor.Add(new Chunk(
                    $"\n{"Date",-14} : {DateTime.Now.ToLocalTime().ToLongDateString()}",
                    fntAuthor));
                document.Add(prgAuthor);

                //Add a line seperation
                var p = new Paragraph(new Chunk(
                    new iTextSharp.text.pdf.draw.LineSeparator(0.0F,
                        100.0F,
                        color,
                        Element.ALIGN_LEFT,
                        1)));
                document.Add(p);

                //Add line break
                document.Add(new Chunk("\n", fntHead));

                //Write the table
                var table = new PdfPTable(7) {
                    WidthPercentage = 100f
                };

                var widths = new[] { 8f, 25f, 10f, 10f, 10f, 17f, 20f };
                
                table.SetWidths(widths);

                //Table header
                var btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,
                    BaseFont.CP1252,
                    BaseFont.NOT_EMBEDDED);
                var fntColumnHeader = new Font(btnColumnHeader, 10, 1, color);

                var cell = new PdfPCell();
                cell.AddElement(new Chunk("Id", fntColumnHeader));
                table.AddCell(cell);

                cell = new PdfPCell();
                cell.AddElement(new Chunk("Name", fntColumnHeader));
                table.AddCell(cell);

                cell = new PdfPCell();
                cell.AddElement(new Chunk("In Shop", fntColumnHeader));
                table.AddCell(cell);

                cell = new PdfPCell();
                cell.AddElement(new Chunk("In Godown", fntColumnHeader));
                table.AddCell(cell);

                cell = new PdfPCell();
                cell.AddElement(new Chunk("Total Stock", fntColumnHeader));
                table.AddCell(cell);

                   cell = new PdfPCell();
                    cell.AddElement(
                        new Chunk("Purchase Price", fntColumnHeader));
                    table.AddCell(cell);

                    cell = new PdfPCell();
                    cell.AddElement(new Chunk("Worth", fntColumnHeader));
                    table.AddCell(cell);
                
                
                //table Data
                foreach (Product item in P)
                {
                    //cell = new PdfPCell(new Phrase(item.Type)) {
                    //    HorizontalAlignment = Element.ALIGN_RIGHT
                    //};
                    table.AddCell(item.ProductId);
                    table.AddCell(item.ProductName);
                    table.AddCell(item.GetShopStock);
                    table.AddCell(item.GetGodownStock);
                    table.AddCell(item.GetTotalStock);

                    if (!includePurchaseInfo)
                    {
                        table.AddCell(" ");
                        table.AddCell(" ");
                    }
                    else
                    {
                        table.AddCell(
                            $"{(item.PurchasePrice * (decimal) item.PurchasePrice):C2}");
                        table.AddCell(
                            $"{(item.PurchasePrice * (decimal) item.TotalStock):C2}");
                    }
                }

                document.Add(table);
                document.Close();
                writer.Close();
                fs.Close();
            }
        }

        public static DataTable ConvertToDataTable <T> (IList<T> data)
        {
            var properties =
                TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name,
                    Nullable.GetUnderlyingType(prop.PropertyType)
                 ?? prop.PropertyType);

            foreach (var item in data)
            {
                var row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
