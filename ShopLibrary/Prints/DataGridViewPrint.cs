﻿using iTextSharp.text;
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
        public static void ExportDataTableToPdf(List<Customer> C, String strPdfPath, string strHeader) {
            FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            BaseColor color = new BaseColor(0, 0, 0);

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, color);
            Paragraph prgHeading = new Paragraph {
                Alignment = Element.ALIGN_CENTER
            };
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 11, 2, color);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Date: " + DateTime.Now.ToLocalTime().ToShortDateString(), fntAuthor));
            prgAuthor.Add(new Chunk($"\nTotal Due: {C.Sum(c => c.Debt).ToString("0.##")} BDT", fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, color, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(5);
            table.WidthPercentage = 100f;
            float[] widths = new float[] { 10f, 26f, 14f, 20f, 28f };
            table.SetWidths(widths);

            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, color);

            PdfPCell cell = new PdfPCell();
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
            foreach (Customer customer in C) {
                cell = new PdfPCell(new Phrase(customer.GetDebt))
                {
                    HorizontalAlignment = Element.ALIGN_RIGHT
                };
                table.AddCell(customer.CustomerId);
                table.AddCell(customer.FullName);
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(customer.Phone))
                {
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

        public static DataTable ConvertToDataTable<T>(IList<T> data) {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data) {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }
}
