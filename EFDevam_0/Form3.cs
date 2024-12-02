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
            _db = new NorthwindEntities();
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

            p.CategoryID = Convert.ToInt32(CmbKategoriler.SelectedValue);

            _db.Products.Add(p);

            _db.SaveChanges();
            UrunleriVeKategorileriListele();
        }

        private void LstUrunler_Click(object sender, EventArgs e)
        {
            if (LstUrunler.SelectedItem != null)
            {
                _secilen = LstUrunler.SelectedItem as Product;
                TxtIsim.Text=_secilen.ProductName;
                TxtFiyat.Text=_secilen.UnitPrice.ToString();
                if (_secilen.CategoryID == null)
                {
                    CmbKategoriler.SelectedIndex =-1;
                }
                else
                {
                    CmbKategoriler.SelectedValue = _secilen.CategoryID;
                }
                
            }
            

        }
    }
}
