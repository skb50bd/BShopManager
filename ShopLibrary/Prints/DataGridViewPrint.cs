using iTextSharp.text;
using iTextSharp.text.pdf;
using ShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary.Prints
{
    public class DataGridViewPrint
    {
        public void ExportDataTableToPdf(List<Customer>C, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            var Color = new BaseColor(0, 0, 0);

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, Color);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 10, 2, Color);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Report Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(5);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 12, 1, Color);

            PdfPCell cell = new PdfPCell();
            cell.AddElement(new Chunk("ID", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Name", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Adress", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Phone No", fntColumnHeader));
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Chunk("Due", fntColumnHeader));
            table.AddCell(cell);


            //table Data
            foreach(Customer customer in C)
            {
                table.AddCell(customer.CustomerId);
                table.AddCell(customer.FullName);
                table.AddCell(customer.Address);
                table.AddCell(customer.Phone);
                cell = new PdfPCell(new Phrase(customer.GetDebt));
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(cell);
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }
}
