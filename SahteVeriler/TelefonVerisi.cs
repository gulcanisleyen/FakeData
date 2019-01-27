using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeriler
{

  public  class TelefonVerisi
    {
        Random rnd;
        public TelefonVerisi()
        {
            rnd = new Random();
        }
        public int Telefon()
        {
            int tel = rnd.Next(1000000, 9999999);
            return tel;
        }
       

    }
}
