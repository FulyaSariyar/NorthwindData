namespace NorthwindData
{
    partial class UrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstÜrünler = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cmbDisc = new System.Windows.Forms.ComboBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtQPU = new System.Windows.Forms.TextBox();
            this.txtUP = new System.Windows.Forms.TextBox();
            this.txtUIS = new System.Windows.Forms.TextBox();
            this.txtUOO = new System.Windows.Forms.TextBox();
            this.txtRO = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Seç";
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.ItemHeight = 15;
            this.lstKategoriler.Location = new System.Drawing.Point(40, 41);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(120, 289);
            this.lstKategoriler.TabIndex = 2;
            this.lstKategoriler.SelectedIndexChanged += new System.EventHandler(this.lstKategoriler_SelectedIndexChanged);
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.ItemHeight = 15;
            this.lstSuppliers.Location = new System.Drawing.Point(199, 41);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(120, 289);
            this.lstSuppliers.TabIndex = 3;
            this.lstSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSuppliers_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity Per Unit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Unit Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Units in stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Units on order:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Reorder level:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Discounted:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(676, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "ÜRÜNLER";
            // 
            // lstÜrünler
            // 
            this.lstÜrünler.FormattingEnabled = true;
            this.lstÜrünler.ItemHeight = 15;
            this.lstÜrünler.Location = new System.Drawing.Point(676, 28);
            this.lstÜrünler.Name = "lstÜrünler";
            this.lstÜrünler.Size = new System.Drawing.Size(212, 229);
            this.lstÜrünler.TabIndex = 12;
            this.lstÜrünler.SelectedIndexChanged += new System.EventHandler(this.lstÜrünler_SelectedIndexChanged);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(676, 282);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(212, 23);
            this.txtAra.TabIndex = 13;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // cmbDisc
            // 
            this.cmbDisc.FormattingEnabled = true;
            this.cmbDisc.Location = new System.Drawing.Point(544, 225);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(100, 23);
            this.cmbDisc.TabIndex = 14;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(544, 38);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 23);
            this.txtUrunAdi.TabIndex = 15;
            // 
            // txtQPU
            // 
            this.txtQPU.Location = new System.Drawing.Point(544, 71);
            this.txtQPU.Name = "txtQPU";
            this.txtQPU.Size = new System.Drawing.Size(100, 23);
            this.txtQPU.TabIndex = 16;
            // 
            // txtUP
            // 
            this.txtUP.Location = new System.Drawing.Point(544, 102);
            this.txtUP.Name = "txtUP";
            this.txtUP.Size = new System.Drawing.Size(100, 23);
            this.txtUP.TabIndex = 17;
            // 
            // txtUIS
            // 
            this.txtUIS.Location = new System.Drawing.Point(544, 133);
            this.txtUIS.Name = "txtUIS";
            this.txtUIS.Size = new System.Drawing.Size(100, 23);
            this.txtUIS.TabIndex = 18;
            // 
            // txtUOO
            // 
            this.txtUOO.Location = new System.Drawing.Point(544, 162);
            this.txtUOO.Name = "txtUOO";
            this.txtUOO.Size = new System.Drawing.Size(100, 23);
            this.txtUOO.TabIndex = 19;
            // 
            // txtRO
            // 
            this.txtRO.Location = new System.Drawing.Point(544, 192);
            this.txtRO.Name = "txtRO";
            this.txtRO.Size = new System.Drawing.Size(100, 23);
            this.txtRO.TabIndex = 20;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(468, 266);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(569, 266);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(468, 295);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(569, 295);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 24;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 340);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtRO);
            this.Controls.Add(this.txtUOO);
            this.Controls.Add(this.txtUIS);
            this.Controls.Add(this.txtUP);
            this.Controls.Add(this.txtQPU);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.cmbDisc);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstÜrünler);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSuppliers);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstKategoriler;
        private ListBox lstSuppliers;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListBox lstÜrünler;
        private TextBox txtAra;
        private ComboBox cmbDisc;
        private TextBox txtUrunAdi;
        private TextBox txtQPU;
        private TextBox txtUP;
        private TextBox txtUIS;
        private TextBox txtUOO;
        private TextBox txtRO;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
    }
}