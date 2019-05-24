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
    public partial class FormYoneticiİslem : Form
    {

        Yönetici yi = new Yönetici();
        SqlDataAdapter da;
        DataTable dt;    
     
        public FormYoneticiİslem()
        {
            InitializeComponent();
        }

       
        private void FormYoneticiİslem_Load(object sender, EventArgs e)
        {
            yGiris yg = new yGiris();
            yg.Girismesaj();
            this.doktorTableAdapter.Fill(this.dataSet1.doktor);
            yi.baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from doktor  ", yi.baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "doktor");
            dgwListe.DataSource = ds.Tables["doktor"];
            yi.baglanti.Close();
           
         
           
        }
     
        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            if (tbDoktoridEkle.Text!=string.Empty && tbAdEkle.Text !=string.Empty && tbSoyadEkle.Text !=string.Empty && tbKuladEkle.Text !=string.Empty && tbSifreEkle.Text !=string.Empty)
            {
                yi.baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Select doktorid,kulad from doktor where doktorid=@doktorid or kulad=@kulad", yi.baglanti);
                komut2.Parameters.AddWithValue("@doktorid", tbDoktoridEkle.Text);
                komut2.Parameters.AddWithValue("@kulad", tbKuladEkle.Text);
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    MessageBox.Show("böyle bir id veya kullanıcı adı ile doktor bulunmaktadır.Yeni kayıt yapamazsınız.");
                    yi.baglanti.Close();
                    tbDoktoridEkle.Text = "";
                    tbKuladEkle.Text = "";
                }
                else
                {
                    dr2.Close();
                    SqlCommand komut = new SqlCommand("insert into doktor(doktorid,ad,soyad,kulad,sifre) values(@doktorid,@ad,@soyad,@kulad,@sifre)", yi.baglanti);
                    komut.Parameters.AddWithValue("@doktorid", tbDoktoridEkle.Text);
                    komut.Parameters.AddWithValue("@ad", tbAdEkle.Text);
                    komut.Parameters.AddWithValue("@soyad", tbSoyadEkle.Text);
                    komut.Parameters.AddWithValue("@kulad", tbKuladEkle.Text);
                    komut.Parameters.AddWithValue("@sifre", tbSifreEkle.Text);
                    komut.ExecuteNonQuery();
                    yi.baglanti.Close();
                    MessageBox.Show("Doktor Eklemeniz başarı ile gerçekleşmiştir.");

                }
                SqlDataAdapter da = new SqlDataAdapter("select * from doktor  ", yi.baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "doktor");
                dgwListe.DataSource = ds.Tables["doktor"];
                yi.baglanti.Close();
            }
            else
                MessageBox.Show("Tüm alanları doldurunuz");
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbDoktoridEkle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lbDoktoridEkle, "Doktor İD leri A-Z arası bir harf ve sonrasında 3 adet 0-9 arası rakam içeren 4 haneli bir veridir.");
            toolTip1.ToolTipTitle = "UYARI";
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
        }

       

        private void tbDoktoridEkle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tbDoktoridEkle, "Doktor İD leri A-Z arası bir harf ve sonrasında 3 adet 0-9 arası rakam içeren 4 haneli bir veridir.");
            toolTip1.ToolTipTitle = "UYARI";
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
        }

        private void tbidSil_TextChanged(object sender, EventArgs e)
        {
            yi.baglanti.Open();
         da = new SqlDataAdapter("select * from doktor where doktorid like '" + tbidSil.Text + "%'", yi.baglanti);
          DataSet ds = new DataSet();
          da.Fill(ds, "doktor");
          dgwListe.DataSource = ds.Tables["doktor"];
        dt = new DataTable();
        da.Fill(dt);
        dgwListe.DataSource = dt;
         yi.baglanti.Close();




        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            yi.baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from doktor where doktorid=@doktorid" , yi.baglanti);
            komut.Parameters.AddWithValue("@doktorid", dgwListe.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            MessageBox.Show("Seçilen veri silindi.");
          
            SqlDataAdapter da = new SqlDataAdapter("select * from doktor  ", yi.baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "doktor");
            dgwListe.DataSource = ds.Tables["doktor"];
            yi.baglanti.Close();
            tbidSil.Text = "";
              

         
        }

     

        private void tbDoktoridEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void tbAdEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void tbSoyadEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void tbKuladEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void tbSifreEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void tbidSil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

     
      

       

    
      

       

       
    }
}
