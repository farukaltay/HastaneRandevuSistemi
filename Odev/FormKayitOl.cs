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
    public partial class FormKayitOl : Form
    {
        KayitOl kayitol = new KayitOl();
        string cinsiyet;


        public FormKayitOl()
        {
            InitializeComponent();
        }

        private void FormKayitOl_Load(object sender, EventArgs e)
        {
            lbTckn.Text = kayitol.lbisim;
            lbSifre.Text = kayitol.lbsifre;
            lbBaslik.Text = kayitol.lbbaslik;
            
        }

        private void btnKayitol_Click(object sender, EventArgs e)
        {
       
            if (tbMail.Text!=string.Empty && tbAd.Text != string.Empty && tbSoyad.Text != string.Empty && tbTcKimlikNo.Text.Length == 11 && tbSifre.Text != string.Empty && tbSifreTekrar.Text != string.Empty && (rbErkek.Checked != false || rbKadın.Checked != false))
            {
                if (tbMail.Text.IndexOf("@gmail.com") != -1 || tbMail.Text.IndexOf("@hotmail.com")!= -1 || tbMail.Text.IndexOf("@outlook.com") != -1 || tbMail.Text.IndexOf("@msn.com") != -1 && tbMail.Text.IndexOf("@yahoo.com") != -1 )
                {
                    kayitol.baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("Select * from hastakaydi where tckno=@tckno  or mail=@mail", kayitol.baglanti);
                    komut2.Parameters.AddWithValue("@tckno", tbTcKimlikNo.Text);
                    komut2.Parameters.AddWithValue("@mail", tbMail.Text);   
                    SqlDataReader dr2 = komut2.ExecuteReader();
                    if (dr2.Read())
                    {
                        MessageBox.Show("böyle bir kullanici bulunmaktadır");
                        kayitol.baglanti.Close();
                        tbAd.Text = "";
                        tbSoyad.Text = "";
                        tbMail.Text = "";
                        mbTelefon.Text = "";
                        tbSifre.Text = "";
                        tbSifreTekrar.Text = "";
                        dtpDogTar.Text = "";
                        tbTcKimlikNo.Text = "";
                        rbErkek.Checked = false;
                        rbKadın.Checked = false;
                    }
                    else
                    {
                        if (tbSifre.Text == tbSifreTekrar.Text)
                        {

                            dr2.Close();
                            SqlCommand komut = new SqlCommand("insert into hastakaydi(tckno,sifre,ad,soyad,telefon,mail,cinsiyet,dogTar) values(@tckno,@sifre,@ad,@soyad,@telefon,@mail,@cinsiyet,@dogTar)", kayitol.baglanti);
                            komut.Parameters.AddWithValue("@tckno", tbTcKimlikNo.Text);
                            komut.Parameters.AddWithValue("@sifre", tbSifre.Text);
                            komut.Parameters.AddWithValue("@ad", tbAd.Text);
                            komut.Parameters.AddWithValue("@soyad", tbSoyad.Text);
                            komut.Parameters.AddWithValue("@telefon", mbTelefon.Text);
                            komut.Parameters.AddWithValue("@mail", tbMail.Text);
                            komut.Parameters.AddWithValue("@dogTar", Convert.ToDateTime(dtpDogTar.Text));
                            if (rbErkek.Checked)
                            {
                                cinsiyet = "Erkek";
                            }
                            else
                                if (rbKadın.Checked)
                                {
                                    cinsiyet = "Kadın";
                                }
                            komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                            komut.ExecuteNonQuery();
                            kayitol.baglanti.Close();
                            MessageBox.Show("Kaydınız Başarı ile gerçekleşti.");
                            this.Close();
                            FormHastaİslem frmhst = new FormHastaİslem();
                            frmhst.Show();
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("Şifreler aynı değil.");
                            tbSifre.Text = "";
                            tbSifreTekrar.Text = "";
                            kayitol.baglanti.Close();
                        }
                    }
                }

                else MessageBox.Show("Düzgün Mail Adresi Giriniz!");
                 
                    
                }
                else MessageBox.Show("Tüm alanları doldurunuz.");
            }

        private void tbTcKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
            
       
    }
}

