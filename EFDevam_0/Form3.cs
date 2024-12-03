using EFDevam_0.DesignPatterns.SingletonPattern;
using EFDevam_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDevam_0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            _db = DBTool.DbInstance;
        }

        NorthwindEntities _db;


        private void UrunleriVeKategorileriListele()
        {
            LstUrunler.DataSource = _db.Products.ToList();
            LstUrunler.DisplayMember = "ProductName";


            CmbKategoriler.DataSource = _db.Categories.ToList();
            CmbKategoriler.DisplayMember = "CategoryName";


            CmbKategoriler.ValueMember = "CategoryID"; //ValueMember arka tarafta saklanan , kullanıcıya direkt gözükmeyen bir deger demektir...Su anda bu combobox icerisindeki elemanların arka tarafında ilgili verilerine ait CategoryID'ler bulunuyor...

            CmbKategoriler.SelectedIndex = LstUrunler.SelectedIndex = -1;
            TxtFiyat.Text = TxtIsim.Text = string.Empty;
            //TxtFiyat.Text = TxtIsim.Text = "";
            //TxtFiyat.Text = TxtIsim.Text = null;


        }


        private void Form3_Load(object sender, EventArgs e)
        {
            UrunleriVeKategorileriListele();




        }
        Product _secilen;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = TxtIsim.Text;
            p.UnitPrice = Convert.ToDecimal(TxtFiyat.Text);
            //if (CmbKategoriler.SelectedValue != null) p.CategoryID = Convert.ToInt32(CmbKategoriler.SelectedValue);
            KategoriBelirle(p);


            //if (CmbKategoriler.SelectedValue != null)
            //{
            //   p.CategoryID = Convert.ToInt32(CmbKategoriler.SelectedValue);
            //}
            //else
            //{
            //    p.CategoryID = null;
            //}



            //default keyword'u, argümanını verdiginiz tip varsayılan ne alabiliyorsa onu verecektir...

            //int => 0
            //string => null

            //int? => null //bir deger tip, hibritleşip null gecilen bir hale dönüsüyorsa bazı özellikler kazanır...

            //string a = default; 



            //p.CategoryID = CmbKategoriler.SelectedValue != null ? Convert.ToInt32(CmbKategoriler.SelectedValue) : default(int?);

            //int? cid = Convert.ToInt32(CmbKategoriler.SelectedValue);


            //p.CategoryID = CmbKategoriler.SelectedValue == null ? null: cid;

            //p.CategoryID = CmbKategoriler.SelectedValue == null ? default : Convert.ToInt32(CmbKategoriler.SelectedValue);


           



            _db.Products.Add(p);

            KaydetVeResetle();
            UrunleriVeKategorileriListele();
        }

        private void LstUrunler_Click(object sender, EventArgs e)
        {
            if (LstUrunler.SelectedItem != null)
            {
                _secilen = LstUrunler.SelectedItem as Product;
                TxtIsim.Text = _secilen.ProductName;
                TxtFiyat.Text = _secilen.UnitPrice.ToString();



                #region UzunYazim
                //if (_secilen.CategoryID == null)
                //{
                //    //CmbKategoriler.SelectedValue = -1;

                //}
                //else
                //{
                //    //CmbKategoriler.SelectedValue = _secilen.CategoryID;

                //}
                #endregion


                CmbKategoriler.SelectedValue = _secilen.CategoryID != null ? _secilen.CategoryID : -1;





                #region Not
                //string a;

                //int b = 2, c = 3;

                //if (b < c)
                //{
                //    a = "Merhaba";
                //}
                //else
                //{
                //    a = "Test";
                //}

                //a = b < c ? "Merhaba" : "Test"; 
                #endregion







            }


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if(_secilen == null)
            {
                MessageBox.Show("Lütfen önce ürün seciniz");
                return;
            }

            try
            {
                _secilen.ProductName = TxtIsim.Text;
                _secilen.UnitPrice = Convert.ToDecimal(TxtFiyat.Text);

                KategoriBelirle(_secilen);
                KaydetVeResetle();
                UrunleriVeKategorileriListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

       


        }

        private void KaydetVeResetle()
        {
            _db.SaveChanges();
            TxtFiyat.Text = TxtIsim.Text = string.Empty;
            KategoriResetle();
            _secilen = null;
        }

        private void KategoriResetle()
        {
            CmbKategoriler.SelectedItem = null;
        }

        private void KategoriBelirle(Product item)
        {
            item.CategoryID = CmbKategoriler.SelectedItem != null ? Convert.ToInt32(CmbKategoriler.SelectedValue) : default(int?);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(_secilen == null)
            {
                MessageBox.Show("Lütfen bir ürün seciniz");
                return;
            }
            _db.Products.Remove(_secilen);
            KaydetVeResetle();
            UrunleriVeKategorileriListele();
        }

        private void BtnSecimResetle_Click(object sender, EventArgs e)
        {
            KategoriResetle();
        }


      
    }
}
