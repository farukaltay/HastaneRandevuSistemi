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
    public class Doktor:Kullanici
    {
        //public List<FormDoktorİslem> randevular = new List<FormDoktorİslem>();
     
        public Doktor()
        {
            lbisim = "Kullanıcı Adı  :";
            
           

        }
        public Doktor(string a): base("sss")
        {
            butonisim = "GİRİŞ";
           
        }
       

        //public string KullaniciAdi
        //{
        //    get { return kullaniciAdi; }
        //    set
        //    {
        //        if (value.Length >= 6)
        //        {
        //            kullaniciAdi = value;
        //        }
        //        else
        //            throw new Exception("En az 6 haneli olmalıdır.");
        //    }
        
    }
}
