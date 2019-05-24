using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/**
 *** Faruk_Altay 07.07.2017 
 */
namespace HastaneRandevuSistemi
{
    public partial class FormDoktorİslem : Form
    {
         Doktor dok = new Doktor();
      
        public FormDoktorİslem()
        {
            InitializeComponent();
        }

        private void FormDoktorGiris_Load(object sender, EventArgs e)
        {
            dGiris dg = new dGiris();
            dg.Girismesaj();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstHastakaydi.Items.Clear();
            dok.baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from randevular",dok.baglanti);          
                     
            SqlDataReader dr3 = komut4.ExecuteReader();
        
            while (dr3.Read())
            {
                lstHastakaydi.Items.Add(dr3["randevular"]);
            }
            dr3.Close();
     
            dok.baglanti.Close();
        }
        public enum durum
        {
            Kötü,
            Orta,
            İyi,
            Çokiyi
        };
        

         private void button2_Click(object sender, EventArgs e)
         {
             int i=lstTip.SelectedIndex;
             durum durumtip;
             durumtip = (durum)i;
             MessageBox.Show("Gününüzün "+durumtip.ToString()+" Geçtiği Bilgisi Gönderildi.");
             
             
             
             
         }

         private void radioButton1_CheckedChanged(object sender, EventArgs e)
         {
             lstHastakaydi.Font = new Font(lstHastakaydi.Font, FontStyle.Bold);
         }

    }
}
