namespace NorthwindData
{
    partial class AnaForm
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
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Location = new System.Drawing.Point(81, 109);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(175, 70);
            this.btnKategoriler.TabIndex = 0;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(315, 109);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(175, 70);
            this.btnUrunler.TabIndex = 1;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 333);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.btnKategoriler);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnKategoriler;
        private Button btnUrunler;
    }
}