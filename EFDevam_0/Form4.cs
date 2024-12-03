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
    public partial class Form4 : Form
    {
        NorthwindEntities _db;
        public Form4()
        {
            InitializeComponent();
            _db = DBTool.DbInstance;
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = _db.Employees.ToList();
           
        }

        private void listBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            //Bu Format event'in özelliklerin(e tarafından tutulan özelliklerinde)  ListItem property'si ListBox'in / ComboBox'in icerisinde bulunan elemanların her birinin (bireysel olarak) temsil edildigi bir property'dir...Herbir ListItem'in (elemanın) tipinin object oldugunu biliyoruz ve Employee tipinde olduklarını da biliyoruz... Dolayısıyla ListItem'i Employee'e cast edip (unboxing) onun özelliklerine ulasabiliriz...

            //e.ListItem

            //e.ListItem as Employee

            Employee emp = e.ListItem as Employee;
            string fullName = $"{emp.FirstName} {emp.LastName}";

            e.Value = fullName;
            
        }
    }
}
