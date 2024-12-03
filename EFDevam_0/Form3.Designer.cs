namespace EFDevam_0
{
    partial class Form3
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
            this.LstUrunler = new System.Windows.Forms.ListBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbKategoriler = new System.Windows.Forms.ComboBox();
            this.BtnSecimResetle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstUrunler
            // 
            this.LstUrunler.FormattingEnabled = true;
            this.LstUrunler.ItemHeight = 22;
            this.LstUrunler.Location = new System.Drawing.Point(390, 36);
            this.LstUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.LstUrunler.Name = "LstUrunler";
            this.LstUrunler.Size = new System.Drawing.Size(793, 730);
            this.LstUrunler.TabIndex = 11;
            this.LstUrunler.Click += new System.EventHandler(this.LstUrunler_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(71, 588);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(204, 54);
            this.BtnGuncelle.TabIndex = 8;
            this.BtnGuncelle.Text = "Guncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(71, 492);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(204, 54);
            this.BtnEkle.TabIndex = 9;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(71, 685);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(204, 54);
            this.BtnSil.TabIndex = 10;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(39, 224);
            this.TxtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(248, 28);
            this.TxtFiyat.TabIndex = 6;
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(40, 110);
            this.TxtIsim.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(248, 28);
            this.TxtIsim.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Urun Ismi";
            // 
            // CmbKategoriler
            // 
            this.CmbKategoriler.FormattingEnabled = true;
            this.CmbKategoriler.Location = new System.Drawing.Point(39, 297);
            this.CmbKategoriler.Name = "CmbKategoriler";
            this.CmbKategoriler.Size = new System.Drawing.Size(227, 30);
            this.CmbKategoriler.TabIndex = 12;
            // 
            // BtnSecimResetle
            // 
            this.BtnSecimResetle.Location = new System.Drawing.Point(40, 349);
            this.BtnSecimResetle.Name = "BtnSecimResetle";
            this.BtnSecimResetle.Size = new System.Drawing.Size(193, 30);
            this.BtnSecimResetle.TabIndex = 13;
            this.BtnSecimResetle.Text = "Kategori Resetle";
            this.BtnSecimResetle.UseVisualStyleBackColor = true;
            this.BtnSecimResetle.Click += new System.EventHandler(this.BtnSecimResetle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 840);
            this.Controls.Add(this.BtnSecimResetle);
            this.Controls.Add(this.CmbKategoriler);
            this.Controls.Add(this.LstUrunler);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstUrunler;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbKategoriler;
        private System.Windows.Forms.Button BtnSecimResetle;
    }
}