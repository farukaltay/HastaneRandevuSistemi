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
    public partial class FormYönetici : Form
    {

        Yönetici ynt = new Yönetici();  //varsayılan kurucu fonksiyon çalışması için
        Yönetici ynt2 = new Yönetici("string değer"); //string değer ile kurucu fonksiyon çalışması için

        public FormYönetici()
        {
            InitializeComponent();
        }

        private void FormYönetici_Load(object sender, EventArgs e)
        {
            lbKontrol.Text = ynt.lbdogrulama;
            lbSifre.Text = ynt2.lbsifre;
            lbYöneticiİD.Text = ynt.lbisim;
            lbBaslik.Text = ynt2.lbbaslik;
            btnGiris.Text = ynt2.butonisim;
            tbRndSayi.Text = ynt.sayi.ToString();

        }

        private void tbKontrol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (tbKontrol.Text == tbRndSayi.Text)
            {
               
                ynt.baglanti.Open();

                SqlCommand komut = new SqlCommand("Select * from yonetici where yoneticiid=@yid and sifre=@sifre", ynt.baglanti);
                komut.Parameters.AddWithValue("@yid", tbYöneticiİD.Text);
                komut.Parameters.AddWithValue("@sifre", tbSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read()) //data reader açıldı ve okuyabilir
                {
                    this.Hide();
                    FormYoneticiİslem fyi = new FormYoneticiİslem();
                    fyi.ShowDialog();
                    this.Show();
                    
                }
                else
                {
                    MessageBox.Show("Hatalı giriş");
                    tbYöneticiİD.Text = "";
                    tbSifre.Text = "";
                }
            
                ynt.baglanti.Close();


            }
            else
            {
                MessageBox.Show("Hatalı giriş.");
                tbKontrol.Text = "";
                tbYöneticiİD.Text = "";
                tbSifre.Text = "";
            }
        }
    }
}
