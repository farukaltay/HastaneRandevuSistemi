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

    public partial class FormHastaİslem : Form
    {
        int a;
        public string il;
        public string ilce;
        public string klinik;
        public string hastane;
        public string tc;
        Hasta hsi = new Hasta();
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        FormHasta frm = new FormHasta();


        public void RandevuDoldur()
        {
         
            hsi.ildoldur = il;
            hsi.ilcedoldur = ilce;
            hsi.klinikdoldur = klinik;
            hsi.hastanedoldur = hastane;
            hsi.tarihdoldur = dtpRanTar.Value;
            hsi.hastaislem.Add(hsi);
            if (lbs1.ForeColor == Color.Red)
            {              
                lstRandevuListesi.Items.Clear();
                hsi.saatdoldur = lbs1.Text;
                lstRandevuListesi.Items.Add("Tc= "+tc+" --- "+hsi.ildoldur + " - " + hsi.ilcedoldur + " - " + hsi.klinikdoldur + " - " + hsi.hastanedoldur + " - " + hsi.saatdoldur + " [ " + hsi.tarihdoldur.Date.ToShortDateString() + " ]");
                veritabani();
            }
            else if (lbs2.ForeColor == Color.Red)
            {
                lstRandevuListesi.Items.Clear();
                hsi.saatdoldur = lbs2.Text;
                lstRandevuListesi.Items.Add("Tc= "+tc+" --- "+hsi.ildoldur + " - " + hsi.ilcedoldur + " - " + hsi.klinikdoldur + " - " + hsi.hastanedoldur + " - " + hsi.saatdoldur + " [ " + hsi.tarihdoldur.Date.ToShortDateString() + " ]");
                veritabani();
            }
            else if (lbs3.ForeColor == Color.Red)
            {
                lstRandevuListesi.Items.Clear();
                hsi.saatdoldur = lbs3.Text;
                lstRandevuListesi.Items.Add("Tc= " + tc + " --- " + hsi.ildoldur + " - " + hsi.ilcedoldur + " - " + hsi.klinikdoldur + " - " + hsi.hastanedoldur + " - " + hsi.saatdoldur + " [ " + hsi.tarihdoldur.Date.ToShortDateString() + " ]");
                veritabani();
            }
            else if (lbs4.ForeColor == Color.Red)
            {
                lstRandevuListesi.Items.Clear();
                hsi.saatdoldur = lbs4.Text;
                lstRandevuListesi.Items.Add("Tc= " + tc + " --- " + hsi.ildoldur + " - " + hsi.ilcedoldur + " - " + hsi.klinikdoldur + " - " + hsi.hastanedoldur + " - " + hsi.saatdoldur + " [ " + hsi.tarihdoldur.Date.ToShortDateString() + " ]");
                veritabani();
            }
            else if (lbs5.ForeColor == Color.Red)
            {
                lstRandevuListesi.Items.Clear();
                hsi.saatdoldur = lbs5.Text;
                lstRandevuListesi.Items.Add("Tc= " + tc + " --- " + hsi.ildoldur + " - " + hsi.ilcedoldur + " - " + hsi.klinikdoldur + " - " + hsi.hastanedoldur + " - " + hsi.saatdoldur + " [ " + hsi.tarihdoldur.Date.ToShortDateString() + " ]");
                veritabani();
            }
            else if (lbs6.ForeColor == Color.Red)
            {
                lstRandevuListesi.Items.Clear();
                hsi.saatdoldur = lbs6.Text;
                lstRandevuListesi.Items.Add("Tc= " + tc + " --- " + hsi.ildoldur + " - " + hsi.ilcedoldur + " - " + hsi.klinikdoldur + " - " + hsi.hastanedoldur + " - " + hsi.saatdoldur + " [ " + hsi.tarihdoldur.Date.ToShortDateString() + " ]");
                veritabani();
            }
            else if (lbs7.ForeColor == Color.Red)
            {
                lstRandevuListesi.Items.Clear();
                hsi.saatdoldur = lbs7.Text;
                lstRandevuListesi.Items.Add("Tc= " + tc + " --- " + hsi.ildoldur + " - " + hsi.ilcedoldur + " - " + hsi.klinikdoldur + " - " + hsi.hastanedoldur + " - " + hsi.saatdoldur + " [ " + hsi.tarihdoldur.Date.ToShortDateString() + " ]");
                veritabani();
            }
            else if (lbs8.ForeColor == Color.Red)
            {
                lstRandevuListesi.Items.Clear();
                hsi.saatdoldur = lbs8.Text;
                lstRandevuListesi.Items.Add("Tc= " + tc + " --- " + hsi.ildoldur + " - " + hsi.ilcedoldur + " - " + hsi.klinikdoldur + " - " + hsi.hastanedoldur + " - " + hsi.saatdoldur + " [ " + hsi.tarihdoldur.Date.ToShortDateString() + " ]");
                veritabani();
            }
            else if (lbs9.ForeColor == Color.Red)
            {
                lstRandevuListesi.Items.Clear();
                hsi.saatdoldur = lbs9.Text;
                lstRandevuListesi.Items.Add("Tc= " + tc + " --- " + hsi.ildoldur + " - " + hsi.ilcedoldur + " - " + hsi.klinikdoldur + " - " + hsi.hastanedoldur + " - " + hsi.saatdoldur + " [ " + hsi.tarihdoldur.Date.ToShortDateString() + " ]");
                veritabani();
            }
            else MessageBox.Show("Randevu saati seçmediniz.");
            
            
                     
            
           
            
        }

        public string hastaneindex()
        {
            if (cbil.SelectedIndex == 0 && cbilce.SelectedIndex == 0)
            {
                 a = 1;              
            }
            else if (cbil.SelectedIndex == 0 && cbilce.SelectedIndex == 1)
            {
                 a = 2;               
            }
            else if (cbil.SelectedIndex == 0 && cbilce.SelectedIndex == 2)
            {
                 a = 3;               
            }
            else if (cbil.SelectedIndex == 0 && cbilce.SelectedIndex == 3)
            {
                 a = 4;
            }
            else if (cbil.SelectedIndex == 0 && cbilce.SelectedIndex == 4)
            {
                 a = 5;
            }
            else if (cbil.SelectedIndex == 1 && cbilce.SelectedIndex == 0)
            {
                 a = 6;
            }

            else if (cbil.SelectedIndex == 1 && cbilce.SelectedIndex == 1)
            {
                 a = 7;
            }
            else if (cbil.SelectedIndex == 1 && cbilce.SelectedIndex == 2)
            {
                 a = 8;
            }
            else if (cbil.SelectedIndex == 1 && cbilce.SelectedIndex == 3)
            {
                 a = 9;
            }
            else if (cbil.SelectedIndex == 1 && cbilce.SelectedIndex == 4)
            {
                 a = 10;
            }
            else if (cbil.SelectedIndex == 2 && cbilce.SelectedIndex == 0)
            {
                 a = 11;
            }
            else if (cbil.SelectedIndex == 2 && cbilce.SelectedIndex == 1)
            {
                 a = 12;
            }
            else if (cbil.SelectedIndex == 2 && cbilce.SelectedIndex == 2)
            {
                 a = 13;
            }
            else if (cbil.SelectedIndex == 2 && cbilce.SelectedIndex == 3)
            {
                 a = 14;
            }
            else if (cbil.SelectedIndex == 2 && cbilce.SelectedIndex == 4)
            {
                 a = 15;
            }
            else if (cbil.SelectedIndex == 3 && cbilce.SelectedIndex == 0)
            {
                 a = 16;
            }
            else if (cbil.SelectedIndex == 3 && cbilce.SelectedIndex == 1)
            {
                 a = 17;
            }
            else if (cbil.SelectedIndex == 3 && cbilce.SelectedIndex == 2)
            {
                 a = 18;
            }
            else if (cbil.SelectedIndex == 3 && cbilce.SelectedIndex == 3)
            {
                 a = 19;
            }
            else a = 20 ;

                 return a.ToString();
        }




        void iller()
        {
            cbil.SelectedIndexChanged -= cbil_SelectedIndexChanged;
           
            adp = new SqlDataAdapter("select iller from il", hsi.baglanti);
            DataSet dataset = new DataSet();
           
            adp.Fill(dataset);
            
            cbil.ValueMember = "id";
            cbil.DisplayMember = "iller";
            cbil.DataSource = dataset.Tables[0];
            cbil.SelectedIndexChanged += cbil_SelectedIndexChanged;

          
        }
      

        public FormHastaİslem()
        {
            InitializeComponent();

        }

        private void FormHastaİslem_Load(object sender, EventArgs e)
        {
            hGiris hg = new hGiris();
            hg.Girismesaj();
            
            iller();
            
            
        
        }

        private void cbil_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbilce.Items.Clear();

            hsi.baglanti.Open();
            komut.Connection = hsi.baglanti;
            komut.CommandText = "select ilceler From ilce Where ilid=" + (cbil.SelectedIndex + 1);
            SqlDataReader oku;
            oku = komut.ExecuteReader();

            while (oku.Read())
            {
                cbilce.Items.Add(oku[0].ToString());
            }
            hsi.baglanti.Close();
        }

        private void cbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbHastane.Items.Clear();

            hsi.baglanti.Open();
            komut.Connection = hsi.baglanti;

            komut.CommandText = "select hastaneler From hastane Where ilceid=" + hastaneindex();

            // MessageBox.Show(cbilce.SelectedIndex.ToString());

            SqlDataReader oku;
            oku = komut.ExecuteReader();

            while (oku.Read())
            {
                cbHastane.Items.Add(oku[0].ToString());
            }
            hsi.baglanti.Close();
        }

        private void cbilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKlinik.Items.Clear();

            hsi.baglanti.Open();
            komut.Connection = hsi.baglanti;
            komut.CommandText = "select klinik From klinik";
            SqlDataReader oku;
            oku = komut.ExecuteReader();

            while (oku.Read())
            {
                cbKlinik.Items.Add(oku[0].ToString());
            }
            hsi.baglanti.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           if (cbil.SelectedIndex != -1 && cbilce.SelectedIndex != -1 && cbKlinik.SelectedIndex != -1 && cbHastane.SelectedIndex != -1)
             { 
               try
                  {
                     
                     hsi.RandevuTar = dtpRanTar.Value;
                     ilcagir();
                     ilcecagir();
                     klinikcagir();
                     hastanecagir();
                     RandevuDoldur();
                    

                     
               
                               
                  }
               catch (Exception ex) { MessageBox.Show(ex.Message); }
               
                
               
             }

         else MessageBox.Show("Lütfen eksik yerleri tamamlayınız.");
          
        }
        

        private void label5_Click(object sender, EventArgs e)
        {
            
            lbs1.BorderStyle = BorderStyle.Fixed3D;
            lbs1.ForeColor = Color.Red;
            lbs2.BorderStyle = BorderStyle.FixedSingle;
            lbs2.ForeColor =Color.ForestGreen;
            lbs3.BorderStyle = BorderStyle.FixedSingle;
            lbs3.ForeColor = Color.ForestGreen;
            lbs4.BorderStyle = BorderStyle.FixedSingle;
            lbs4.ForeColor = Color.ForestGreen;
            lbs5.BorderStyle = BorderStyle.FixedSingle;
            lbs5.ForeColor = Color.ForestGreen;
            lbs6.BorderStyle = BorderStyle.FixedSingle;
            lbs6.ForeColor = Color.ForestGreen;
            lbs7.BorderStyle = BorderStyle.FixedSingle;
            lbs7.ForeColor = Color.ForestGreen;
            lbs8.BorderStyle = BorderStyle.FixedSingle;
            lbs8.ForeColor = Color.ForestGreen;
            lbs9.BorderStyle = BorderStyle.FixedSingle;
            lbs9.ForeColor = Color.ForestGreen;
        }
        private void label6_Click(object sender, EventArgs e)
        {

            lbs1.BorderStyle = BorderStyle.FixedSingle;
            lbs1.ForeColor = Color.ForestGreen;
            lbs2.BorderStyle = BorderStyle.Fixed3D;
            lbs2.ForeColor = Color.Red;
            lbs3.BorderStyle = BorderStyle.FixedSingle;
            lbs3.ForeColor = Color.ForestGreen;
            lbs4.BorderStyle = BorderStyle.FixedSingle;
            lbs4.ForeColor = Color.ForestGreen;
            lbs5.BorderStyle = BorderStyle.FixedSingle;
            lbs5.ForeColor = Color.ForestGreen;
            lbs6.BorderStyle = BorderStyle.FixedSingle;
            lbs6.ForeColor = Color.ForestGreen;
            lbs7.BorderStyle = BorderStyle.FixedSingle;
            lbs7.ForeColor = Color.ForestGreen;
            lbs8.BorderStyle = BorderStyle.FixedSingle;
            lbs8.ForeColor = Color.ForestGreen;
            lbs9.BorderStyle = BorderStyle.FixedSingle;
            lbs9.ForeColor = Color.ForestGreen;
        }
        private void label7_Click(object sender, EventArgs e)
        {

            lbs1.BorderStyle = BorderStyle.FixedSingle;
            lbs1.ForeColor = Color.ForestGreen;
            lbs2.BorderStyle = BorderStyle.Fixed3D;
            lbs2.ForeColor = Color.ForestGreen;
            lbs3.BorderStyle = BorderStyle.Fixed3D;
            lbs3.ForeColor = Color.Red;
            lbs4.BorderStyle = BorderStyle.FixedSingle;
            lbs4.ForeColor = Color.ForestGreen;
            lbs5.BorderStyle = BorderStyle.FixedSingle;
            lbs5.ForeColor = Color.ForestGreen;
            lbs6.BorderStyle = BorderStyle.FixedSingle;
            lbs6.ForeColor = Color.ForestGreen;
            lbs7.BorderStyle = BorderStyle.FixedSingle;
            lbs7.ForeColor = Color.ForestGreen;
            lbs8.BorderStyle = BorderStyle.FixedSingle;
            lbs8.ForeColor = Color.ForestGreen;
            lbs9.BorderStyle = BorderStyle.FixedSingle;
            lbs9.ForeColor = Color.ForestGreen;
        }
        private void label8_Click(object sender, EventArgs e)
        {

            lbs1.BorderStyle = BorderStyle.FixedSingle;
            lbs1.ForeColor = Color.ForestGreen;
            lbs2.BorderStyle = BorderStyle.FixedSingle;
            lbs2.ForeColor = Color.ForestGreen;
            lbs3.BorderStyle = BorderStyle.FixedSingle;
            lbs3.ForeColor = Color.ForestGreen;
            lbs4.BorderStyle = BorderStyle.Fixed3D;
            lbs4.ForeColor = Color.Red;
            lbs5.BorderStyle = BorderStyle.FixedSingle;
            lbs5.ForeColor = Color.ForestGreen;
            lbs6.BorderStyle = BorderStyle.FixedSingle;
            lbs6.ForeColor = Color.ForestGreen;
            lbs7.BorderStyle = BorderStyle.FixedSingle;
            lbs7.ForeColor = Color.ForestGreen;
            lbs8.BorderStyle = BorderStyle.FixedSingle;
            lbs8.ForeColor = Color.ForestGreen;
            lbs9.BorderStyle = BorderStyle.FixedSingle;
            lbs9.ForeColor = Color.ForestGreen;
        }
        private void label9_Click(object sender, EventArgs e)
        {

            lbs1.BorderStyle = BorderStyle.FixedSingle;
            lbs1.ForeColor = Color.ForestGreen;
            lbs2.BorderStyle = BorderStyle.FixedSingle;
            lbs2.ForeColor = Color.ForestGreen;
            lbs3.BorderStyle = BorderStyle.FixedSingle;
            lbs3.ForeColor = Color.ForestGreen;
            lbs4.BorderStyle = BorderStyle.FixedSingle;
            lbs4.ForeColor = Color.ForestGreen;
            lbs5.BorderStyle = BorderStyle.Fixed3D;
            lbs5.ForeColor = Color.Red;
            lbs6.BorderStyle = BorderStyle.FixedSingle;
            lbs6.ForeColor = Color.ForestGreen;
            lbs7.BorderStyle = BorderStyle.FixedSingle;
            lbs7.ForeColor = Color.ForestGreen;
            lbs8.BorderStyle = BorderStyle.FixedSingle;
            lbs8.ForeColor = Color.ForestGreen;
            lbs9.BorderStyle = BorderStyle.FixedSingle;
            lbs9.ForeColor = Color.ForestGreen;
        }

        private void label10_Click(object sender, EventArgs e)
        {

            lbs1.BorderStyle = BorderStyle.FixedSingle;
            lbs1.ForeColor = Color.ForestGreen;
            lbs2.BorderStyle = BorderStyle.FixedSingle;
            lbs2.ForeColor = Color.ForestGreen;
            lbs3.BorderStyle = BorderStyle.FixedSingle;
            lbs3.ForeColor = Color.ForestGreen;
            lbs4.BorderStyle = BorderStyle.FixedSingle;
            lbs4.ForeColor = Color.ForestGreen;
            lbs5.BorderStyle = BorderStyle.FixedSingle;
            lbs5.ForeColor = Color.ForestGreen;
            lbs6.BorderStyle = BorderStyle.Fixed3D;
            lbs6.ForeColor = Color.Red;
            lbs7.BorderStyle = BorderStyle.FixedSingle;
            lbs7.ForeColor = Color.ForestGreen;
            lbs8.BorderStyle = BorderStyle.FixedSingle;
            lbs8.ForeColor = Color.ForestGreen;
            lbs9.BorderStyle = BorderStyle.FixedSingle;
            lbs9.ForeColor = Color.ForestGreen;
        }

        private void label11_Click(object sender, EventArgs e)
        {

            lbs1.BorderStyle = BorderStyle.FixedSingle;
            lbs1.ForeColor = Color.ForestGreen;
            lbs2.BorderStyle = BorderStyle.FixedSingle;
            lbs2.ForeColor = Color.ForestGreen;
            lbs3.BorderStyle = BorderStyle.FixedSingle;
            lbs3.ForeColor = Color.ForestGreen;
            lbs4.BorderStyle = BorderStyle.FixedSingle;
            lbs4.ForeColor = Color.ForestGreen;
            lbs5.BorderStyle = BorderStyle.FixedSingle;
            lbs5.ForeColor = Color.ForestGreen;
            lbs6.BorderStyle = BorderStyle.FixedSingle;
            lbs6.ForeColor = Color.ForestGreen;
            lbs7.BorderStyle = BorderStyle.Fixed3D;
            lbs7.ForeColor = Color.Red;
            lbs8.BorderStyle = BorderStyle.FixedSingle;
            lbs8.ForeColor = Color.ForestGreen;
            lbs9.BorderStyle = BorderStyle.FixedSingle;
            lbs9.ForeColor = Color.ForestGreen;
        }

        private void label12_Click(object sender, EventArgs e)
        {

            lbs1.BorderStyle = BorderStyle.FixedSingle;
            lbs1.ForeColor = Color.ForestGreen;
            lbs2.BorderStyle = BorderStyle.FixedSingle;
            lbs2.ForeColor = Color.ForestGreen;
            lbs3.BorderStyle = BorderStyle.FixedSingle;
            lbs3.ForeColor = Color.ForestGreen;
            lbs4.BorderStyle = BorderStyle.FixedSingle;
            lbs4.ForeColor = Color.ForestGreen;
            lbs5.BorderStyle = BorderStyle.FixedSingle;
            lbs5.ForeColor = Color.ForestGreen;
            lbs6.BorderStyle = BorderStyle.FixedSingle;
            lbs6.ForeColor = Color.ForestGreen;
            lbs7.BorderStyle = BorderStyle.FixedSingle;
            lbs7.ForeColor = Color.ForestGreen;
            lbs8.BorderStyle = BorderStyle.Fixed3D;
            lbs8.ForeColor = Color.Red;
            lbs9.BorderStyle = BorderStyle.FixedSingle;
            lbs9.ForeColor = Color.ForestGreen;
        }

        private void label13_Click(object sender, EventArgs e)
        {

            lbs1.BorderStyle = BorderStyle.FixedSingle;
            lbs1.ForeColor = Color.ForestGreen;
            lbs2.BorderStyle = BorderStyle.FixedSingle;
            lbs2.ForeColor = Color.ForestGreen;
            lbs3.BorderStyle = BorderStyle.FixedSingle;
            lbs3.ForeColor = Color.ForestGreen;
            lbs4.BorderStyle = BorderStyle.FixedSingle;
            lbs4.ForeColor = Color.ForestGreen;
            lbs5.BorderStyle = BorderStyle.FixedSingle;
            lbs5.ForeColor = Color.ForestGreen;
            lbs6.BorderStyle = BorderStyle.FixedSingle;
            lbs6.ForeColor = Color.ForestGreen;
            lbs7.BorderStyle = BorderStyle.FixedSingle;
            lbs7.ForeColor = Color.ForestGreen;
            lbs8.BorderStyle = BorderStyle.FixedSingle;
            lbs8.ForeColor = Color.ForestGreen;
            lbs9.BorderStyle = BorderStyle.Fixed3D;
            lbs9.ForeColor = Color.Red;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ilcecagir()
        {
            hsi.baglanti.Open();
            komut.Connection = hsi.baglanti;
            komut.CommandText = "select ilceler From ilce Where id=" + a;
            SqlDataReader okuilce;
            okuilce = komut.ExecuteReader();

            while (okuilce.Read())
            {
                ilce = okuilce[0].ToString();
            }
            okuilce.Close();
            hsi.baglanti.Close();

        }
        public void ilcagir()
        {
            hsi.baglanti.Open();
            komut.Connection = hsi.baglanti;
            komut.CommandText = "select iller From il Where id=" + (cbil.SelectedIndex+1);
            SqlDataReader okuil;
            okuil = komut.ExecuteReader();
            while (okuil.Read())
            {
                il = okuil[0].ToString();
            }
            okuil.Close();
            hsi.baglanti.Close();

        }
        public void hastanecagir()
        {
            hsi.baglanti.Open();
            komut.Connection = hsi.baglanti;
            komut.CommandText = "select hastaneler From hastane Where id=" + a;
            SqlDataReader okuhastane;
            okuhastane = komut.ExecuteReader();
            while (okuhastane.Read())
            {
                hastane = okuhastane[0].ToString();
            }
            okuhastane.Close();
            hsi.baglanti.Close();

        }
        public  void klinikcagir()
        {
            hsi.baglanti.Open();
            komut.Connection = hsi.baglanti;
            komut.CommandText = "select klinik From klinik Where id=" + (cbKlinik.SelectedIndex + 1);
            SqlDataReader okuklinik;
            okuklinik = komut.ExecuteReader();
            while (okuklinik.Read())
            {
                klinik = okuklinik[0].ToString();
            }
            okuklinik.Close();
            hsi.baglanti.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lstRandevuListesi.Items.Remove(lstRandevuListesi.SelectedItem);
            
           
        }
        public void veritabani()
        {
            hsi.baglanti.Open();
            string a = "Tc= " + tc + " --- " + hsi.ildoldur + " - " + hsi.ilcedoldur + " - " + hsi.klinikdoldur + " - " + hsi.hastanedoldur + " - " + hsi.saatdoldur + " [ " + hsi.tarihdoldur.Date.ToShortDateString() + " ]";
           
            SqlCommand komut2 = new SqlCommand("Select * from randevular where randevular=@randevular", hsi.baglanti);
            
            komut2.Parameters.AddWithValue("@randevular",a );
            
            SqlDataReader dr2 = komut2.ExecuteReader();
            
            if (dr2.Read())
            {
                MessageBox.Show("Bu Randevu Tarihi Zaten Alındı!");
               

            }
            
            else
            {
                dr2.Close();
                SqlCommand komut = new SqlCommand("insert into randevular(randevular) values(@randevular)", hsi.baglanti);
                foreach (string randevular in lstRandevuListesi.Items)
                {
                    
                    komut.Parameters.AddWithValue("@randevular", randevular.ToString());
                    komut.ExecuteNonQuery();
                    hsi.baglanti.Close();

                }
            }
            hsi.baglanti.Close();
        }
        


       
    }
}
