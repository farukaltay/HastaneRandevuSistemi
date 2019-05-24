using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

/**
 *** Faruk_Altay 07.07.2017 
 */

namespace HastaneRandevuSistemi
{
   public class Yönetici:Kullanici
    {
        

        public Yönetici()
        {
           
            lbisim = "Yönetici İD   :";
            
            

        }
        public Yönetici(string a):base("string değer")
        {
            lbbaslik = "Yönetici Giriş";
         
        }


    }
}
