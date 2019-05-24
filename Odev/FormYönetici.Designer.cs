namespace HastaneRandevuSistemi
{
    partial class FormYönetici
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lbYöneticiİD = new System.Windows.Forms.Label();
            this.lbSifre = new System.Windows.Forms.Label();
            this.lbKontrol = new System.Windows.Forms.Label();
            this.lbBaslik = new System.Windows.Forms.Label();
            this.tbYöneticiİD = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbKontrol = new System.Windows.Forms.TextBox();
            this.tbRndSayi = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::HastaneRandevuSistemi.Properties.Resources.YöneticiGiris;
            this.pictureBox.Location = new System.Drawing.Point(104, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(140, 95);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lbYöneticiİD
            // 
            this.lbYöneticiİD.AutoSize = true;
            this.lbYöneticiİD.Location = new System.Drawing.Point(25, 155);
            this.lbYöneticiİD.Name = "lbYöneticiİD";
            this.lbYöneticiİD.Size = new System.Drawing.Size(71, 13);
            this.lbYöneticiİD.TabIndex = 1;
            this.lbYöneticiİD.Text = "Yönetici İD   :";
            // 
            // lbSifre
            // 
            this.lbSifre.AutoSize = true;
            this.lbSifre.Location = new System.Drawing.Point(25, 181);
            this.lbSifre.Name = "lbSifre";
            this.lbSifre.Size = new System.Drawing.Size(34, 13);
            this.lbSifre.TabIndex = 2;
            this.lbSifre.Text = "Şifre :";
            // 
            // lbKontrol
            // 
            this.lbKontrol.AutoSize = true;
            this.lbKontrol.Location = new System.Drawing.Point(25, 207);
            this.lbKontrol.Name = "lbKontrol";
            this.lbKontrol.Size = new System.Drawing.Size(98, 13);
            this.lbKontrol.TabIndex = 3;
            this.lbKontrol.Text = "Sağda Ne Yazıyor?";
            // 
            // lbBaslik
            // 
            this.lbBaslik.AutoSize = true;
            this.lbBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBaslik.ForeColor = System.Drawing.Color.Red;
            this.lbBaslik.Location = new System.Drawing.Point(130, 110);
            this.lbBaslik.Name = "lbBaslik";
            this.lbBaslik.Size = new System.Drawing.Size(95, 18);
            this.lbBaslik.TabIndex = 4;
            this.lbBaslik.Text = "Yönetici Giriş";
            // 
            // tbYöneticiİD
            // 
            this.tbYöneticiİD.Location = new System.Drawing.Point(129, 152);
            this.tbYöneticiİD.Name = "tbYöneticiİD";
            this.tbYöneticiİD.Size = new System.Drawing.Size(112, 20);
            this.tbYöneticiİD.TabIndex = 5;
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(129, 178);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.PasswordChar = '*';
            this.tbSifre.Size = new System.Drawing.Size(112, 20);
            this.tbSifre.TabIndex = 6;
            // 
            // tbKontrol
            // 
            this.tbKontrol.Location = new System.Drawing.Point(129, 204);
            this.tbKontrol.Name = "tbKontrol";
            this.tbKontrol.Size = new System.Drawing.Size(112, 20);
            this.tbKontrol.TabIndex = 7;
            this.tbKontrol.TextChanged += new System.EventHandler(this.tbKontrol_TextChanged);
            // 
            // tbRndSayi
            // 
            this.tbRndSayi.Enabled = false;
            this.tbRndSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbRndSayi.Location = new System.Drawing.Point(258, 204);
            this.tbRndSayi.Name = "tbRndSayi";
            this.tbRndSayi.ReadOnly = true;
            this.tbRndSayi.Size = new System.Drawing.Size(53, 21);
            this.tbRndSayi.TabIndex = 8;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(69, 250);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(90, 33);
            this.btnGiris.TabIndex = 9;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(213, 255);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 11;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FormYönetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.tbRndSayi);
            this.Controls.Add(this.tbKontrol);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbYöneticiİD);
            this.Controls.Add(this.lbBaslik);
            this.Controls.Add(this.lbKontrol);
            this.Controls.Add(this.lbSifre);
            this.Controls.Add(this.lbYöneticiİD);
            this.Controls.Add(this.pictureBox);
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "FormYönetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormYönetici";
            this.Load += new System.EventHandler(this.FormYönetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lbYöneticiİD;
        private System.Windows.Forms.Label lbSifre;
        private System.Windows.Forms.Label lbKontrol;
        private System.Windows.Forms.Label lbBaslik;
        private System.Windows.Forms.TextBox tbYöneticiİD;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbKontrol;
        private System.Windows.Forms.TextBox tbRndSayi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnGeri;
    }
}