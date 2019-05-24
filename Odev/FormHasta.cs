using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; //input u kullanmak için kulandığımız kütüphane.+microsoft.visualbasic referans
using System.Net.Mail;  // mail göndermek için
using System.Net;       // mail göndermek için
using System.Data.SqlClient;

/**
 *** Faruk_Altay 07.07.2017 
 */

namespace HastaneRandevuSistemi
{
    public partial class FormHasta : Form
    {
        
        Hasta hst = new Hasta(); //varsayılan kurucu fonksiyon çalıstı.
        Hasta hst2 = new Hasta(123123);//int kurucu fonksiyon için.
        
       
        public FormHasta()
        {
            InitializeComponent();
                     
        }

        private void FormHasta_Load(object sender, EventArgs e)
        {
            lbKontrol.Text = hst.lbdogrulama;
            lbSifre.Text = hst2.lbsifre;
            lbTckn.Text = hst.lbisim;
            lbBaslik.Text = hst.lbbaslik;
            tbRndsayi.Text = hst.sayi.ToString();
                    
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (tbKontrol.Text == tbRndsayi.Text)
            {
                hst.baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from hastakaydi where tckno=@tckno and sifre=@sifre", hst.baglanti);
                komut.Parameters.AddWithValue("@tckno", tbTckn.Text);
                komut.Parameters.AddWithValue("@sifre", tbSifre.Text);
                
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read()) //data reader açıldı ve okuyabiliyor ise
                {
                   
                    this.Hide();
                    FormHastaİslem fhi = new FormHastaİslem();
                    fhi.tc = tbTckn.Text.ToString();
                    fhi.ShowDialog();
                    this.Show();
                    tbTckn.Text = "";
                    tbSifre.Text = "";
                    tbKontrol.Text = "";
                    
                }
               
                else
                {
                    MessageBox.Show("Hatalı giriş");
                    tbTckn.Text = "";
                    tbSifre.Text = "";

                }
                hst.baglanti.Close();
               
                
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
                tbTckn.Text = "";
                tbSifre.Text = "";
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
      
        private void btnSifreiste_Click(object sender, EventArgs e)
        {
            geri:
            
            string mailadresi = Interaction.InputBox("Mail Adresinizi Giriniz.\nŞifreniz Mail Adresinize Gönderilecektir.", "Mail Adres Girişi");
           
            SqlCommand komut2 = new SqlCommand("Select sifre from hastakaydi where mail=@mail ", hst.baglanti);
            komut2.Parameters.AddWithValue("@mail", mailadresi);
            hst.baglanti.Open();
            var istenensifre = komut2.ExecuteScalar();
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
                if (mailadresi.Length != 0)
                {


                    if (mailadresi.IndexOf("@gmail.com") != -1) { goto ileri; }
                    else if (mailadresi.IndexOf("@hotmail.com") != -1) { goto ileri; }
                    else if (mailadresi.IndexOf("@outlook.com") != -1) { goto ileri; }
                    else if (mailadresi.IndexOf("@msn.com") != -1) { goto ileri; }
                    else if (mailadresi.IndexOf("@yahoo.com") != -1) { goto ileri; }
                    else { MessageBox.Show("Düzgün Değer Giriniz!"); goto geri; }

                ileri:
                    
                    var kimden = new MailAddress("altaytoker@gmail.com", "Altay-Toker");
                    var kime = new MailAddress(mailadresi, mailadresi);
                    string mailsifre = "29051453";
                    string konu = "Hasta Şifre Hatırlatma!";
                    
              
                    string icerik = "\n\nŞifreniz=" + istenensifre;


                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(kimden.Address, mailsifre)
                    };
                    using
                        (
                        var mesaj = new MailMessage(kimden, kime)
                           {
                               Subject = konu,
                               Body = icerik
                           }

                         )
                    {
                        smtp.Send(mesaj);
                    }
                }
                else
                    MessageBox.Show("Mail Adresi Girmediniz!");
            }
            else { MessageBox.Show("Böyle bir mail adresi bulunmamaktadır"); }
            hst.baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }

        
    
}
