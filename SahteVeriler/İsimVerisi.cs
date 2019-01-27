using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeriler
{
   public class İsimVerisi
    {
        Random rnd;
        public İsimVerisi()
        {
            rnd = new Random();
        }


        public  string AdGetir()
        {
            Random  rnd = new Random();

            List<string> Adlar = new List<string>();
            Adlar.Add("Tuba");
            Adlar.Add("Selin");
            Adlar.Add("Gülcan ");
            Adlar.Add("Ensar");
            Adlar.Add("Berkecan");

            string Ad = Adlar[rnd.Next(0, Adlar.Count)];
            return Ad;

        }
          

    }
}
