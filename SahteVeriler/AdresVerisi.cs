using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeriler
{
   public class AdresVerisi
    {
        Random rnd;
        public AdresVerisi()
        {
            rnd = new Random();
        }

        public  string AdresGetir()
        {
          
            List<string> Adresler = new List<string>();
            Adresler.Add("Türkiye");
            Adresler.Add("Fransa");
            Adresler.Add("İsveç ");
            Adresler.Add("Almanya");
            Adresler.Add("Norveç");
            string Adres = Adresler[rnd.Next(0, Adresler.Count)];
            return Adres;
        }
    }
}
