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
    public partial class Form1 : Form
    {




        NorthwindEntities _db;

        public Form1()
        {
            InitializeComponent();
            _db = DBTool.DbInstance;
        }

        //Form yüklendigi zaman Kategori bilgilerinin ListBox'a gelmesini istiyoruz...

        private void Form1_Load(object sender, EventArgs e)
        {
            KategorileriListele();
           

        }


        public void SecileniResetle()
        {
            _secilen = null;
        }


        public void CommitleVeListele(string islemIsmi)
        {
            _db.SaveChanges(); //Transaction'i Commitleyen(onaylayan) ifadenizdir
            KategorileriListele();
            TxtAciklama.Text = TxtIsim.Text = null;
            MessageBox.Show($"{islemIsmi} gercekleştirildi");

        }

        private void KategorileriListele()
        {
            //DataSource , object tipinde veri kabul etse de sadece ve sadece List tipindeki verileri gösterebilir.... O yüzden verileri listeleyebilmek icin ona List tipinde bir koleksiyon atmalısınız (DbSet tipindeki koleksiyonumuzu ToList() ile List tipindeki bir koleksiyona ceviriyoruz..
            //
            //DataSource sizden her zaman List tipinde bir yapı bekler....
            LstKategoriler.DataSource = _db.Categories.ToList();  //Database'e git, Categories tablosuna gir ve listeye dök...Sonra Listeye dökülen yapıları LstKategoriler'in DataSource property'sine aktar...


            LstKategoriler.DisplayMember = "CategoryName"; //Display Member ListBox'in icerisinde tuttuğu class'ın bir property'sini verirseniz instance'ların o property'sindeki degerlerini gösterir...BU property ismini string olarak yazmalısınız...Bu görüntüleme formatlarından sadece bir tanesidir ve sadece bir property sergileyebilir...

            LstKategoriler.SelectedIndex = -1;
        }



        private void BtnEkle_Click(object sender, EventArgs e)
        {

            //Add demek (Crud,Create) ilgili class'tan yeni bir nesne olusturmak demektir...Bir şey yaratılıyor...
            Category c = new Category();
            c.CategoryName = TxtIsim.Text;
            c.Description = TxtAciklama.Text;

            _db.Categories.Add(c); //Veritabanında bir degişiklik yaratacak her türlü ifadede(add,delete,update) güvenlik önlemi nedeniyle önce transaction dedigimiz bir sistem devreye girer... Transaction, sistemi geri sarmaya hazır bir mekanizmadır...Siz SaveChanges() emrini vermediginiz takdirde bu Transaction işlemi geri sarılacaktır...


            CommitleVeListele("Ekleme işlemi");



        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if(_secilen == null)
            {
                MessageBox.Show("Lütfen önce kategori seciniz");
                return;
            }

            _secilen.CategoryName = TxtIsim.Text;
            _secilen.Description = TxtAciklama.Text;

            CommitleVeListele("Güncelleme işlemi");
            SecileniResetle();


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(_secilen == null)
            {
                MessageBox.Show("Lütfen önce Kategori seciniz");
                return;
            }

            _db.Categories.Remove(_secilen);
            CommitleVeListele("Silme işlemi");
            SecileniResetle();
        }


        Category _secilen;

        private void LstKategoriler_Click(object sender, EventArgs e)
        {
            if (LstKategoriler.SelectedItem != null)
            {
                _secilen = LstKategoriler.SelectedItem as Category;
                TxtIsim.Text = _secilen.CategoryName;
                TxtAciklama.Text = _secilen.Description;
            }
        }
    }
}
