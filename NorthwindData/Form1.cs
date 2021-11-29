using NorthwindData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NorthwindData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindContext _dbContext = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }
        private Category selectedCategory;

        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex == -1) return;

            selectedCategory = lstKategoriler.SelectedItem as Category;
            txtKategoriAdi.Text = selectedCategory.CategoryName;
            txtAciklama.Text = selectedCategory.Description;
            pbResim.Image = (Image)new System.Drawing.ImageConverter().ConvertFrom(selectedCategory.Picture);
        }
        private void ListeyiDoldur()
        {
            lstKategoriler.Items.Clear();
            foreach (Category category1 in _dbContext.Categories)
            {
                lstKategoriler.Items.Add(category1);
            }
        }
        private void KutulariBosalt()
        {
            txtKategoriAdi.Text = "";
            txtAciklama.Text = "";
            pbResim.Image = null;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedCategory == null) return;

            selectedCategory.CategoryName = txtKategoriAdi.Text;
            selectedCategory.Description = txtAciklama.Text;
            selectedCategory.Picture = (byte[])new ImageConverter().ConvertTo(pbResim.Image, typeof(byte[]));
            _dbContext.SaveChanges();
            ListeyiDoldur();
        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbResim.Image = new Bitmap(open.FileName);
                // image file path  
                pbResim.Text = open.FileName;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category();
            try
            {
                newCategory.CategoryName = txtKategoriAdi.Text;
                newCategory.Description = txtAciklama.Text;
                newCategory.Picture = (byte[])new ImageConverter().ConvertTo(pbResim.Image, typeof(byte[]));
                _dbContext.Categories.Add(newCategory);
                _dbContext.SaveChanges();
                ListeyiDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Bir Hata Oluþtu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedCategory == null) return;
            _dbContext.Categories.Remove(selectedCategory);
            _dbContext.SaveChanges();
            ListeyiDoldur();
            KutulariBosalt();
        }
    }
}