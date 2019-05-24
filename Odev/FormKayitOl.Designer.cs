namespace HastaneRandevuSistemi
{
    partial class FormKayitOl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKayitol = new System.Windows.Forms.Button();
            this.lbAd = new System.Windows.Forms.Label();
            this.lbSoyad = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbTckn = new System.Windows.Forms.Label();
            this.lbSifre = new System.Windows.Forms.Label();
            this.lbSifre2 = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbTcKimlikNo = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbSifreTekrar = new System.Windows.Forms.TextBox();
            this.mbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lbDogumTarihi = new System.Windows.Forms.Label();
            this.dtpDogTar = new System.Windows.Forms.DateTimePicker();
            this.lbBaslik = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lbCinsiyet = new System.Windows.Forms.Label();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.pbKayitOl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayitOl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKayitol
            // 
            this.btnKayitol.Location = new System.Drawing.Point(171, 360);
            this.btnKayitol.Name = "btnKayitol";
            this.btnKayitol.Size = new System.Drawing.Size(99, 39);
            this.btnKayitol.TabIndex = 0;
            this.btnKayitol.Text = "Kayıt Ol";
            this.btnKayitol.UseVisualStyleBackColor = true;
            this.btnKayitol.Click += new System.EventHandler(this.btnKayitol_Click);
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.Location = new System.Drawing.Point(18, 180);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(71, 13);
            this.lbAd.TabIndex = 1;
            this.lbAd.Text = "Ad                :";
            // 
            // lbSoyad
            // 
            this.lbSoyad.AutoSize = true;
            this.lbSoyad.Location = new System.Drawing.Point(229, 176);
            this.lbSoyad.Name = "lbSoyad";
            this.lbSoyad.Size = new System.Drawing.Size(76, 13);
            this.lbSoyad.TabIndex = 2;
            this.lbSoyad.Text = "Soyad            :";
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(18, 206);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(70, 13);
            this.lbTelefon.TabIndex = 3;
            this.lbTelefon.Text = "Telefon        :";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(18, 261);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(71, 13);
            this.lbMail.TabIndex = 4;
            this.lbMail.Text = "Mail              :";
            // 
            // lbTckn
            // 
            this.lbTckn.AutoSize = true;
            this.lbTckn.Location = new System.Drawing.Point(229, 202);
            this.lbTckn.Name = "lbTckn";
            this.lbTckn.Size = new System.Drawing.Size(74, 13);
            this.lbTckn.TabIndex = 5;
            this.lbTckn.Text = "T.C Kimlik No:";
            // 
            // lbSifre
            // 
            this.lbSifre.AutoSize = true;
            this.lbSifre.Location = new System.Drawing.Point(18, 235);
            this.lbSifre.Name = "lbSifre";
            this.lbSifre.Size = new System.Drawing.Size(70, 13);
            this.lbSifre.TabIndex = 6;
            this.lbSifre.Text = "Şifre             :";
            // 
            // lbSifre2
            // 
            this.lbSifre2.AutoSize = true;
            this.lbSifre2.Location = new System.Drawing.Point(229, 231);
            this.lbSifre2.Name = "lbSifre2";
            this.lbSifre2.Size = new System.Drawing.Size(74, 13);
            this.lbSifre2.TabIndex = 7;
            this.lbSifre2.Text = "Şifre Tekrar   :";
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(94, 177);
            this.tbAd.MaxLength = 20;
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(100, 20);
            this.tbAd.TabIndex = 8;
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(309, 173);
            this.tbSoyad.MaxLength = 20;
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbSoyad.TabIndex = 9;
            // 
            // tbTcKimlikNo
            // 
            this.tbTcKimlikNo.Location = new System.Drawing.Point(309, 199);
            this.tbTcKimlikNo.MaxLength = 11;
            this.tbTcKimlikNo.Name = "tbTcKimlikNo";
            this.tbTcKimlikNo.Size = new System.Drawing.Size(100, 20);
            this.tbTcKimlikNo.TabIndex = 11;
            this.tbTcKimlikNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTcKimlikNo_KeyPress);
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(94, 232);
            this.tbSifre.MaxLength = 20;
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(100, 20);
            this.tbSifre.TabIndex = 12;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // tbSifreTekrar
            // 
            this.tbSifreTekrar.Location = new System.Drawing.Point(309, 228);
            this.tbSifreTekrar.MaxLength = 20;
            this.tbSifreTekrar.Name = "tbSifreTekrar";
            this.tbSifreTekrar.Size = new System.Drawing.Size(100, 20);
            this.tbSifreTekrar.TabIndex = 13;
            this.tbSifreTekrar.UseSystemPasswordChar = true;
            // 
            // mbTelefon
            // 
            this.mbTelefon.Location = new System.Drawing.Point(94, 203);
            this.mbTelefon.Mask = "(999) 000-0000";
            this.mbTelefon.Name = "mbTelefon";
            this.mbTelefon.Size = new System.Drawing.Size(100, 20);
            this.mbTelefon.TabIndex = 15;
            // 
            // lbDogumTarihi
            // 
            this.lbDogumTarihi.AutoSize = true;
            this.lbDogumTarihi.Location = new System.Drawing.Point(18, 290);
            this.lbDogumTarihi.Name = "lbDogumTarihi";
            this.lbDogumTarihi.Size = new System.Drawing.Size(76, 13);
            this.lbDogumTarihi.TabIndex = 16;
            this.lbDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // dtpDogTar
            // 
            this.dtpDogTar.Location = new System.Drawing.Point(94, 290);
            this.dtpDogTar.Name = "dtpDogTar";
            this.dtpDogTar.Size = new System.Drawing.Size(198, 20);
            this.dtpDogTar.TabIndex = 17;
            // 
            // lbBaslik
            // 
            this.lbBaslik.AutoSize = true;
            this.lbBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBaslik.ForeColor = System.Drawing.Color.Red;
            this.lbBaslik.Location = new System.Drawing.Point(168, 137);
            this.lbBaslik.Name = "lbBaslik";
            this.lbBaslik.Size = new System.Drawing.Size(98, 18);
            this.lbBaslik.TabIndex = 19;
            this.lbBaslik.Text = "Kayıt İşlemleri";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(322, 368);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 20;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lbCinsiyet
            // 
            this.lbCinsiyet.AutoSize = true;
            this.lbCinsiyet.Location = new System.Drawing.Point(233, 262);
            this.lbCinsiyet.Name = "lbCinsiyet";
            this.lbCinsiyet.Size = new System.Drawing.Size(70, 13);
            this.lbCinsiyet.TabIndex = 21;
            this.lbCinsiyet.Text = "Cinsiyet        :";
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(311, 261);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 22;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadın
            // 
            this.rbKadın.AutoSize = true;
            this.rbKadın.Location = new System.Drawing.Point(362, 261);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(52, 17);
            this.rbKadın.TabIndex = 23;
            this.rbKadın.TabStop = true;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(94, 259);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(100, 20);
            this.tbMail.TabIndex = 24;
            // 
            // pbKayitOl
            // 
            this.pbKayitOl.Image = global::HastaneRandevuSistemi.Properties.Resources.HastaKayit;
            this.pbKayitOl.Location = new System.Drawing.Point(105, 1);
            this.pbKayitOl.Name = "pbKayitOl";
            this.pbKayitOl.Size = new System.Drawing.Size(230, 121);
            this.pbKayitOl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKayitOl.TabIndex = 18;
            this.pbKayitOl.TabStop = false;
            // 
            // FormKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.rbKadın);
            this.Controls.Add(this.rbErkek);
            this.Controls.Add(this.lbCinsiyet);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lbBaslik);
            this.Controls.Add(this.pbKayitOl);
            this.Controls.Add(this.dtpDogTar);
            this.Controls.Add(this.lbDogumTarihi);
            this.Controls.Add(this.mbTelefon);
            this.Controls.Add(this.tbSifreTekrar);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbTcKimlikNo);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.lbSifre2);
            this.Controls.Add(this.lbSifre);
            this.Controls.Add(this.lbTckn);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.lbSoyad);
            this.Controls.Add(this.lbAd);
            this.Controls.Add(this.btnKayitol);
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "FormKayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKayitOl";
            this.Load += new System.EventHandler(this.FormKayitOl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKayitOl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayitol;
        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.Label lbSoyad;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbTckn;
        private System.Windows.Forms.Label lbSifre;
        private System.Windows.Forms.Label lbSifre2;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbTcKimlikNo;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbSifreTekrar;
        private System.Windows.Forms.MaskedTextBox mbTelefon;
        private System.Windows.Forms.Label lbDogumTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogTar;
        private System.Windows.Forms.PictureBox pbKayitOl;
        private System.Windows.Forms.Label lbBaslik;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lbCinsiyet;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.TextBox tbMail;
    }
}