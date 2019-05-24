namespace HastaneRandevuSistemi
{
    partial class FormSistemGiris
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
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnYönetici = new System.Windows.Forms.Button();
            this.btnKayitol = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHasta
            // 
            this.btnHasta.Location = new System.Drawing.Point(28, 154);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(95, 40);
            this.btnHasta.TabIndex = 0;
            this.btnHasta.Text = "Hasta";
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.Location = new System.Drawing.Point(168, 154);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(94, 40);
            this.btnDoktor.TabIndex = 1;
            this.btnDoktor.Text = "Doktor";
            this.btnDoktor.UseVisualStyleBackColor = true;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // btnYönetici
            // 
            this.btnYönetici.Location = new System.Drawing.Point(28, 207);
            this.btnYönetici.Name = "btnYönetici";
            this.btnYönetici.Size = new System.Drawing.Size(95, 38);
            this.btnYönetici.TabIndex = 2;
            this.btnYönetici.Text = "Yönetici";
            this.btnYönetici.UseVisualStyleBackColor = true;
            this.btnYönetici.Click += new System.EventHandler(this.btnYönetici_Click);
            // 
            // btnKayitol
            // 
            this.btnKayitol.Location = new System.Drawing.Point(168, 207);
            this.btnKayitol.Name = "btnKayitol";
            this.btnKayitol.Size = new System.Drawing.Size(94, 38);
            this.btnKayitol.TabIndex = 3;
            this.btnKayitol.Text = "Kayıt Ol";
            this.btnKayitol.UseVisualStyleBackColor = true;
            this.btnKayitol.Click += new System.EventHandler(this.btnKayitol_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastaneRandevuSistemi.Properties.Resources.SistemGiris;
            this.pictureBox1.Location = new System.Drawing.Point(59, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormSistemGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnKayitol);
            this.Controls.Add(this.btnYönetici);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnHasta);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormSistemGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnYönetici;
        private System.Windows.Forms.Button btnKayitol;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

