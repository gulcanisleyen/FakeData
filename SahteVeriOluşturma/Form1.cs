using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SahteVeriler;

namespace SahteVeriOluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Personeller> plist = new List<Personeller>();
        Random rnd = new Random();
        public void KarmaGetir()
        {
          
            Personeller sv = new Personeller();
            İsimVerisi ism = new İsimVerisi();
            SoyisimVerisi si = new SoyisimVerisi();
            AdresVerisi ad = new AdresVerisi();
            BölümVerisi bl = new BölümVerisi();
            TelefonVerisi tl = new TelefonVerisi();
            for (int i = 1; i <= 100; i++)
            {

                //  int tel = rnd.Next(1000000, 9999999);

                Personeller o1 = new Personeller();
                o1.Id = i;
                o1.Ad = ism.AdGetir();
                o1.Soyad = si.SoyadGetir();
                o1.Adres = ad.AdresGetir();
                o1.Departman = bl.DepartmanGetir();
                o1.TelefonNo = "(+90) " + tl.Telefon();
                plist.Add(o1);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = plist;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            KarmaGetir();
        }
    }
}
