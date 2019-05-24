namespace HastaneRandevuSistemi
{
    partial class FormDoktor
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.lbKullaniciAdi = new System.Windows.Forms.Label();
            this.lbSifre = new System.Windows.Forms.Label();
            this.lbKontrol = new System.Windows.Forms.Label();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbKontrol = new System.Windows.Forms.TextBox();
            this.tbRndsayi = new System.Windows.Forms.TextBox();
            this.lbBaslik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(69, 248);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(92, 35);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lbKullaniciAdi
            // 
            this.lbKullaniciAdi.AutoSize = true;
            this.lbKullaniciAdi.Location = new System.Drawing.Point(32, 155);
            this.lbKullaniciAdi.Name = "lbKullaniciAdi";
            this.lbKullaniciAdi.Size = new System.Drawing.Size(70, 13);
            this.lbKullaniciAdi.TabIndex = 2;
            this.lbKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lbSifre
            // 
            this.lbSifre.AutoSize = true;
            this.lbSifre.Location = new System.Drawing.Point(32, 185);
            this.lbSifre.Name = "lbSifre";
            this.lbSifre.Size = new System.Drawing.Size(49, 13);
            this.lbSifre.TabIndex = 3;
            this.lbSifre.Text = "Şifre      :";
            // 
            // lbKontrol
            // 
            this.lbKontrol.AutoSize = true;
            this.lbKontrol.Location = new System.Drawing.Point(32, 211);
            this.lbKontrol.Name = "lbKontrol";
            this.lbKontrol.Size = new System.Drawing.Size(98, 13);
            this.lbKontrol.TabIndex = 4;
            this.lbKontrol.Text = "Sağda Ne Yazıyor?";
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.Location = new System.Drawing.Point(139, 152);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.tbKullaniciAdi.TabIndex = 5;
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(139, 178);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.PasswordChar = '*';
            this.tbSifre.Size = new System.Drawing.Size(100, 20);
            this.tbSifre.TabIndex = 6;
            // 
            // tbKontrol
            // 
            this.tbKontrol.Location = new System.Drawing.Point(139, 208);
            this.tbKontrol.Name = "tbKontrol";
            this.tbKontrol.Size = new System.Drawing.Size(100, 20);
            this.tbKontrol.TabIndex = 7;
            // 
            // tbRndsayi
            // 
            this.tbRndsayi.Enabled = false;
            this.tbRndsayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbRndsayi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRndsayi.Location = new System.Drawing.Point(258, 208);
            this.tbRndsayi.Name = "tbRndsayi";
            this.tbRndsayi.ReadOnly = true;
            this.tbRndsayi.Size = new System.Drawing.Size(52, 21);
            this.tbRndsayi.TabIndex = 8;
            // 
            // lbBaslik
            // 
            this.lbBaslik.AutoSize = true;
            this.lbBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBaslik.ForeColor = System.Drawing.Color.Red;
            this.lbBaslik.Location = new System.Drawing.Point(124, 113);
            this.lbBaslik.Name = "lbBaslik";
            this.lbBaslik.Size = new System.Drawing.Size(89, 18);
            this.lbBaslik.TabIndex = 10;
            this.lbBaslik.Text = "Doktor Giriş";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastaneRandevuSistemi.Properties.Resources.DoktorGiris;
            this.pictureBox1.Location = new System.Drawing.Point(91, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(213, 254);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 11;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FormDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lbBaslik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbRndsayi);
            this.Controls.Add(this.tbKontrol);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbKullaniciAdi);
            this.Controls.Add(this.lbKontrol);
            this.Controls.Add(this.lbSifre);
            this.Controls.Add(this.lbKullaniciAdi);
            this.Controls.Add(this.btnGiris);
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "FormDoktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoktor";
            this.Load += new System.EventHandler(this.FormDoktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lbKullaniciAdi;
        private System.Windows.Forms.Label lbSifre;
        private System.Windows.Forms.Label lbKontrol;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbKontrol;
        private System.Windows.Forms.TextBox tbRndsayi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbBaslik;
        private System.Windows.Forms.Button btnGeri;
    }
}