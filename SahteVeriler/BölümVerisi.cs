using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeriler
{
  public  class BölümVerisi
    {
        Random rnd;
        public BölümVerisi()
        {
            rnd = new Random();
        }
        public string DepartmanGetir()
        {
            
            List<string> Departmanlar = new List<string>();
            Departmanlar.Add("Bilişim");
            Departmanlar.Add("İnsan Kaynakları");
            Departmanlar.Add("Üretim ");
            Departmanlar.Add("Satış");
            Departmanlar.Add("Bilgi İşlem");
            string Departman = Departmanlar[rnd.Next(0, Departmanlar.Count)];
            return Departman;
        }

    }
}
