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
    public partial class FormDoktor : Form
    {



        Doktor dok = new Doktor();//varsayılan
        Doktor dok2 = new Doktor("dasd");//string değer
        public FormDoktor()
        {
            InitializeComponent();
            
        }

        private void FormDoktor_Load(object sender, EventArgs e)
        {

            lbKontrol.Text = dok.lbdogrulama;
            lbSifre.Text = dok2.lbsifre;
            lbKullaniciAdi.Text = dok.lbisim;
            lbBaslik.Text = dok.lbbaslik;
            btnGiris.Text = dok2.butonisim;
            tbRndsayi.Text =dok.sayi.ToString();     

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (tbKontrol.Text == tbRndsayi.Text)
            {
                dok.baglanti.Open();

                SqlCommand komut = new SqlCommand("Select kulad,sifre from doktor where kulad=@kulad and sifre=@sifre", dok.baglanti);
                komut.Parameters.AddWithValue("@kulad", tbKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@sifre", tbSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read()) //data reader açıldı ve okuyabiliyor ise
                {
                    this.Hide();
                    FormDoktorİslem frm = new FormDoktorİslem();
                    frm.ShowDialog();
                    this.Show();
                    tbKullaniciAdi.Text = "";
                    tbSifre.Text = "";
                    tbKontrol.Text = "";
                }
                else
                {
                    MessageBox.Show("Hatalı giriş");
                    tbKullaniciAdi.Text = "";
                    tbSifre.Text = "";
                    tbKontrol.Text = "";

                }
                dok.baglanti.Close();

            }
            else
            {
                MessageBox.Show("Hatalı giriş.");
                tbKontrol.Text = "";
                tbKullaniciAdi.Text = "";
                tbSifre.Text = "";
            }
        }



        
    }
}
