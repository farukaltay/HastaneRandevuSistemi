using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 *** Faruk_Altay 07.07.2017 
 */

namespace HastaneRandevuSistemi
{
    public class Hasta:Kullanici
    {

        public string ildoldur { get; set; }
        public string ilcedoldur { get; set; }
        public string klinikdoldur { get; set; }
        public string hastanedoldur { get; set; }
        public string saatdoldur { get; set; }

        public DateTime tarihdoldur { get; set; }





        private DateTime randevuTar;

        public Hasta()
        {
            lbbaslik = "Hasta Giriş";
            lbisim = "T.C Kimlik No :";
            
        }

        public Hasta(int a): base("string değer")
        {

        }
       
        public DateTime RandevuTar
        {
            get { return randevuTar; }
            set 
            {
                if (value > (DateTime.Now))
                {
                    randevuTar = value;
                }

                else
                    throw new Exception("Aynı gün ve öncesi için randevu alamazsınız.");

             }     
        }
       
    }
}
