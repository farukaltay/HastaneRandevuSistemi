namespace HastaneRandevuSistemi
{
    partial class FormHasta
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
            this.tbTckn = new System.Windows.Forms.TextBox();
            this.lbSifre = new System.Windows.Forms.Label();
            this.lbKontrol = new System.Windows.Forms.Label();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbKontrol = new System.Windows.Forms.TextBox();
            this.tbRndsayi = new System.Windows.Forms.TextBox();
            this.lbTckn = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnSifreiste = new System.Windows.Forms.Button();
            this.lbBaslik = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTckn
            // 
            this.tbTckn.Location = new System.Drawing.Point(136, 153);
            this.tbTckn.MaxLength = 11;
            this.tbTckn.Name = "tbTckn";
            this.tbTckn.Size = new System.Drawing.Size(100, 20);
            this.tbTckn.TabIndex = 0;
            // 
            // lbSifre
            // 
            this.lbSifre.AutoSize = true;
            this.lbSifre.Location = new System.Drawing.Point(31, 189);
            this.lbSifre.Name = "lbSifre";
            this.lbSifre.Size = new System.Drawing.Size(88, 13);
            this.lbSifre.TabIndex = 2;
            this.lbSifre.Text = "Şifre                   :";
            // 
            // lbKontrol
            // 
            this.lbKontrol.AutoSize = true;
            this.lbKontrol.Location = new System.Drawing.Point(31, 221);
            this.lbKontrol.Name = "lbKontrol";
            this.lbKontrol.Size = new System.Drawing.Size(98, 13);
            this.lbKontrol.TabIndex = 3;
            this.lbKontrol.Text = "Sağda Ne Yazıyor?";
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(136, 186);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.PasswordChar = '*';
            this.tbSifre.Size = new System.Drawing.Size(100, 20);
            this.tbSifre.TabIndex = 4;
            // 
            // tbKontrol
            // 
            this.tbKontrol.Location = new System.Drawing.Point(136, 221);
            this.tbKontrol.Name = "tbKontrol";
            this.tbKontrol.Size = new System.Drawing.Size(100, 20);
            this.tbKontrol.TabIndex = 5;
            // 
            // tbRndsayi
            // 
            this.tbRndsayi.Enabled = false;
            this.tbRndsayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbRndsayi.Location = new System.Drawing.Point(261, 218);
            this.tbRndsayi.Name = "tbRndsayi";
            this.tbRndsayi.ReadOnly = true;
            this.tbRndsayi.Size = new System.Drawing.Size(50, 21);
            this.tbRndsayi.TabIndex = 7;
            // 
            // lbTckn
            // 
            this.lbTckn.AutoSize = true;
            this.lbTckn.Location = new System.Drawing.Point(30, 156);
            this.lbTckn.Name = "lbTckn";
            this.lbTckn.Size = new System.Drawing.Size(89, 13);
            this.lbTckn.TabIndex = 8;
            this.lbTckn.Text = "T.C Kimlik No     :";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(53, 255);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 36);
            this.btnGiris.TabIndex = 9;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnSifreiste
            // 
            this.btnSifreiste.Location = new System.Drawing.Point(188, 255);
            this.btnSifreiste.Name = "btnSifreiste";
            this.btnSifreiste.Size = new System.Drawing.Size(100, 21);
            this.btnSifreiste.TabIndex = 10;
            this.btnSifreiste.Text = "Şifremi Unuttum";
            this.btnSifreiste.UseVisualStyleBackColor = true;
            this.btnSifreiste.Click += new System.EventHandler(this.btnSifreiste_Click);
            // 
            // lbBaslik
            // 
            this.lbBaslik.AutoSize = true;
            this.lbBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBaslik.ForeColor = System.Drawing.Color.Red;
            this.lbBaslik.Location = new System.Drawing.Point(133, 119);
            this.lbBaslik.Name = "lbBaslik";
            this.lbBaslik.Size = new System.Drawing.Size(82, 18);
            this.lbBaslik.TabIndex = 12;
            this.lbBaslik.Text = "Hasta Giriş";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(202, 282);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastaneRandevuSistemi.Properties.Resources.HastaGiris;
            this.pictureBox1.Location = new System.Drawing.Point(44, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lbBaslik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSifreiste);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lbTckn);
            this.Controls.Add(this.tbRndsayi);
            this.Controls.Add(this.tbKontrol);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.lbKontrol);
            this.Controls.Add(this.lbSifre);
            this.Controls.Add(this.tbTckn);
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "FormHasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHasta";
            this.Load += new System.EventHandler(this.FormHasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTckn;
        private System.Windows.Forms.Label lbSifre;
        private System.Windows.Forms.Label lbKontrol;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbKontrol;
        private System.Windows.Forms.TextBox tbRndsayi;
        private System.Windows.Forms.Label lbTckn;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnSifreiste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbBaslik;
        private System.Windows.Forms.Button btnGeri;
    }
}