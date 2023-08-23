using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Insan insan1=new Insan();
            insan1.AdSoyad = "Elif Güngördü";
            insan1.CanliMi=true;

            Insan insan2 = new Insan();
            insan2.AdSoyad = "İbrahim Güngördü";
            insan2.CanliMi = false;

            Insan insan3 = new Insan();
            insan3.AdSoyad = "Berfin Güngördü";
            insan3.CanliMi = true;

            Insan insan4 = new Insan();
            insan4.AdSoyad = "Zülal Güngördü";
            insan4.CanliMi = true;

            MessageBox.Show(insan2.AdiniSoyle());
            MessageBox.Show(Insan.SelamVer());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcVatandas vat1= new TcVatandas();
            vat1.DogumTarihi = Convert.ToDateTime("1995-09-09");
            MessageBox.Show(vat1.VizeAl());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABDVatandas vat2= new ABDVatandas();
            vat2.AdSoyad = "Micheal Fox";
            vat2.Dil = "English";
            vat2.DogumTarihi = Convert.ToDateTime("1999-10-05");
            MessageBox.Show(vat2.Yas.ToString());
        }
    }
}
