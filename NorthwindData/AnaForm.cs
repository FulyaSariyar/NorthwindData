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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();  
            this.Hide();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            UrunEkle frmUrunEkle = new UrunEkle();
            frmUrunEkle.Show();
            this.Hide();
        }
    }
}
