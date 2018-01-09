using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;

namespace WinFormsUI.Forms {
    public partial class ImportForm : Form {
        public ImportForm() {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FilePathText.Text = openFileDialog1.FileName;
            }
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            foreach (Customer customer in ExcelImporter.Import.ReadCustomer(FilePathText.Text))
                Connection[0].InsertCustomer(customer);
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            foreach (Supplier supplier in ExcelImporter.Import.ReadSupplier(FilePathText.Text))
                Connection[0].InsertSupplier(supplier);
        }

        private void ProductButton_Click(object sender, EventArgs e) {
            foreach (Product product in ExcelImporter.Import.ReadProduct(FilePathText.Text,
                Shops[0]))
            {
                //Insert Categories and Specifications if needed
                Category category;
                if (!Categories.Exists(c => c.CategoryName == product.Category)) {
                    category = new Category {
                        CategoryName = product.Category,
                        Specifications = new List<string>() { product.Specification }
                    };
                    Connection[0].InsertCategory(category);
                } else if (!Categories.Single(c => c.CategoryName == product.Category).Specifications.Contains(product.Specification)) {
                    category = Categories.Single(c => c.CategoryName == product.Category);
                    category.Specifications.Add(product.Specification);
                    Connection[0].UpdateCategory(category);
                }
                Connection[0].InsertProduct(product);
            }
        }
    }
}
