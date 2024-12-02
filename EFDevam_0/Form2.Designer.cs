namespace EFDevam_0
{
    partial class Form2
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
            this.LstCalisanlar = new System.Windows.Forms.ListBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.TxtSoyIsim = new System.Windows.Forms.TextBox();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstCalisanlar
            // 
            this.LstCalisanlar.FormattingEnabled = true;
            this.LstCalisanlar.ItemHeight = 16;
            this.LstCalisanlar.Location = new System.Drawing.Point(331, 45);
            this.LstCalisanlar.Name = "LstCalisanlar";
            this.LstCalisanlar.Size = new System.Drawing.Size(635, 532);
            this.LstCalisanlar.TabIndex = 11;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(76, 447);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(163, 39);
            this.BtnGuncelle.TabIndex = 8;
            this.BtnGuncelle.Text = "Guncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(76, 377);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(163, 39);
            this.BtnEkle.TabIndex = 9;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(76, 517);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(163, 39);
            this.BtnSil.TabIndex = 10;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // TxtSoyIsim
            // 
            this.TxtSoyIsim.Location = new System.Drawing.Point(51, 227);
            this.TxtSoyIsim.Name = "TxtSoyIsim";
            this.TxtSoyIsim.Size = new System.Drawing.Size(199, 22);
            this.TxtSoyIsim.TabIndex = 6;
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(51, 99);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(199, 22);
            this.TxtIsim.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calısan Soyismi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Calisan Ismi";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 635);
            this.Controls.Add(this.LstCalisanlar);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TxtSoyIsim);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstCalisanlar;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TxtSoyIsim;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}