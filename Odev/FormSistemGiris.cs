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
    public partial class FormSistemGiris : Form
    {
        public FormSistemGiris()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHasta formhasta = new FormHasta();
            formhasta.ShowDialog();
            this.Show();
            
            
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoktor formdoktor = new FormDoktor();
            formdoktor.ShowDialog();
            this.Show();
            
        }

        private void btnYönetici_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormYönetici formyönetici = new FormYönetici();
            formyönetici.ShowDialog();
            this.Show();
           
        }

        
        private void btnKayitol_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormKayitOl formkayitol = new FormKayitOl();
            formkayitol.ShowDialog();
            this.Show();
            
        }
        
        

    }
}
