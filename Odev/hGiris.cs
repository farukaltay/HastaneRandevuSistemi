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
    class hGiris:Giris
    {
        public override void Girismesaj()
        {
            System.Windows.Forms.MessageBox.Show("        Giriş Başarılı!\n              Hasta");

        }
    }
}
