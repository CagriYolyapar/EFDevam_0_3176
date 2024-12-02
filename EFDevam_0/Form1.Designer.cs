namespace EFDevam_0
{
    partial class Form1
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
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAciklama = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.LstKategoriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Ismi";
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(17, 93);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(199, 28);
            this.TxtIsim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Acıklama";
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Location = new System.Drawing.Point(17, 221);
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(199, 28);
            this.TxtAciklama.TabIndex = 1;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(42, 511);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(163, 39);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(42, 371);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(163, 39);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(42, 441);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(163, 39);
            this.BtnGuncelle.TabIndex = 2;
            this.BtnGuncelle.Text = "Guncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // LstKategoriler
            // 
            this.LstKategoriler.FormattingEnabled = true;
            this.LstKategoriler.ItemHeight = 22;
            this.LstKategoriler.Location = new System.Drawing.Point(297, 39);
            this.LstKategoriler.Name = "LstKategoriler";
            this.LstKategoriler.Size = new System.Drawing.Size(635, 532);
            this.LstKategoriler.TabIndex = 3;
            this.LstKategoriler.Click += new System.EventHandler(this.LstKategoriler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.LstKategoriler);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TxtAciklama);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAciklama;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.ListBox LstKategoriler;
    }
}

