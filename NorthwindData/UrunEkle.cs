using NorthwindData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindData
{
    public enum Disc
    {
        False,
        True
    }
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        NorthwindContext _dbContext = new();

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            Temizle();
            ListeyiDoldurKategori();
            ListeyiDoldurSupplier();
            ListeyiDoldurUrunler();
            cmbDisc.DataSource = Enum.GetNames(typeof(Disc));
        }
        private void ListeyiDoldurKategori()
        {
            lstKategoriler.Items.Clear();
            foreach (Category category1 in _dbContext.Categories)
            {
                lstKategoriler.Items.Add(category1);
            }
        }
        private void ListeyiDoldurSupplier()
        {
            lstSuppliers.Items.Clear();
            foreach (Supplier supplier1 in _dbContext.Suppliers)
            {
                lstSuppliers.Items.Add(supplier1);
            }
        }
        private void ListeyiDoldurUrunler()
        {
            lstÜrünler.Items.Clear();
            foreach (Product product1 in _dbContext.Products)
            {
                lstÜrünler.Items.Add(product1);
            }
        }
        public void Temizle()
        {
            lstKategoriler.SelectedIndex = -1;
            lstSuppliers.SelectedIndex = -1;
            lstÜrünler.SelectedIndex = -1;
            txtUrunAdi.Text = "";
            txtQPU.Text = "";
            txtUP.Text = "";
            txtUIS.Text = "";
            txtUOO.Text = "";
            txtRO.Text = "";
            cmbDisc.SelectedIndex = -1;
        }
        Category selectedCategory;

        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex == -1) return;
            selectedCategory = lstKategoriler.SelectedItem as Category;
        }
        Supplier selectedSupplier;

        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSuppliers.SelectedIndex == -1) return;
            selectedSupplier = lstSuppliers.SelectedItem as Supplier;
        }
        Product selectedProduct;

        private void lstÜrünler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstÜrünler.SelectedIndex == -1) return;
            selectedProduct = lstÜrünler.SelectedItem as Product;
            foreach (Category _ in _dbContext.Categories)
            {
                if (_.CategoryId == selectedProduct.CategoryId)
                {
                    selectedCategory = _;
                    lstKategoriler.SelectedItem = selectedCategory;
                }
            }
            foreach (Supplier _ in _dbContext.Suppliers)
            {
                if (_.SupplierId == selectedProduct.SupplierId)
                {
                    selectedSupplier = _;
                    lstSuppliers.SelectedItem = selectedSupplier;
                }
            }
            txtUrunAdi.Text = selectedProduct.ProductName;
            txtQPU.Text = selectedProduct.QuantityPerUnit;
            txtUP.Text = selectedProduct.UnitPrice.ToString();
            txtUIS.Text = selectedProduct.UnitsInStock.ToString();
            txtUOO.Text = selectedProduct.UnitsOnOrder.ToString();
            txtRO.Text = selectedProduct.ReorderLevel.ToString();
            cmbDisc.SelectedItem = Enum.GetName(typeof(Disc), selectedProduct.Discontinued);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            try
            {
                newProduct.Category = selectedCategory;
                newProduct.Supplier = selectedSupplier;
                newProduct.ProductName = txtUrunAdi.Text;
                newProduct.Discontinued = bool.Parse(cmbDisc.SelectedItem.ToString());
                newProduct.QuantityPerUnit = txtQPU.Text;
                newProduct.ReorderLevel = short.Parse(txtRO.Text);
                newProduct.UnitPrice = decimal.Parse(txtUP.Text);
                newProduct.UnitsOnOrder = short.Parse(txtUOO.Text);
                newProduct.UnitsInStock = short.Parse(txtUIS.Text);
                _dbContext.Products.Add(newProduct);
                _dbContext.SaveChanges();
                Temizle();
                ListeyiDoldurUrunler();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstSuppliers.SelectedIndex == -1) return;
            if (lstKategoriler.SelectedIndex == -1) return;
            try
            {
                selectedProduct.Category = selectedCategory;
                selectedProduct.Supplier = selectedSupplier;
                selectedProduct.ProductName = txtUrunAdi.Text;
                selectedProduct.Discontinued = bool.Parse(cmbDisc.SelectedItem.ToString());
                selectedProduct.QuantityPerUnit = txtQPU.Text;
                selectedProduct.ReorderLevel = short.Parse(txtRO.Text);
                selectedProduct.UnitPrice = decimal.Parse(txtUP.Text);
                selectedProduct.UnitsOnOrder = short.Parse(txtUOO.Text);
                selectedProduct.UnitsInStock = short.Parse(txtUIS.Text);
                _dbContext.SaveChanges();
                Temizle();
                ListeyiDoldurUrunler();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedProduct is not null)
            {
                _dbContext.Products.Remove(selectedProduct);
                _dbContext.SaveChanges();
                Temizle();
                ListeyiDoldurUrunler();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            List<Product> products = new();
            if (string.IsNullOrEmpty(txtAra.Text))
            {
                lstÜrünler.DataSource = _dbContext.Products.ToList();
            }
            else
            {

                foreach (var item in _dbContext.Products)
                {
                    if (item.ProductName.ToUpper().Contains(txtAra.Text.ToUpper()))
                    {
                        products.Add(item);
                    }
                }
                lstÜrünler.DataSource = products;
            }
        }
    }
}
