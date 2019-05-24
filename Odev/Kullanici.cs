using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

/**
 *** Faruk_Altay 07.07.2017 
 */

namespace HastaneRandevuSistemi
{
    public  class Kullanici
    {
        public int sayi;
        public string lbisim;
        public string lbsifre;
        public string lbdogrulama;
        public string lbbaslik;
        public string butonisim;      
        public SqlConnection baglanti = new SqlConnection("Data Source=.;Integrated Security=TRUE;Initial Catalog=master");
        public List<Kullanici> hastaislem = new List<Kullanici>();
        public Kullanici()
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(10000, 99999);
            lbdogrulama = "Sağda Ne Yazıyor? :";
            lbsifre = "Şifre             :";

        }
        public Kullanici(string a)
        {
            butonisim = "Giriş";
            lbsifre = "Şifre    :";
        }
        
       


    }
}
