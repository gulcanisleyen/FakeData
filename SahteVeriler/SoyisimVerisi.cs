using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeriler
{
  public  class SoyisimVerisi
    {
        Random rnd;
        public SoyisimVerisi()
        {
            rnd = new Random();
        }
        public  string SoyadGetir()
        {

            List<string> Soyadlar = new List<string>();
            Soyadlar.Add("Demir");
            Soyadlar.Add("Bozkanat");
            Soyadlar.Add("İşleyen ");
            Soyadlar.Add("Özkan");
            Soyadlar.Add("Kanar");
            string soyisim = Soyadlar[rnd.Next(0, Soyadlar.Count)];
            return soyisim;
        }

    }
}
