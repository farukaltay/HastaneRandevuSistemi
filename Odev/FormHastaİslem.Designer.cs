namespace HastaneRandevuSistemi
{
    partial class FormHastaİslem
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
            this.cbil = new System.Windows.Forms.ComboBox();
            this.lbil = new System.Windows.Forms.Label();
            this.lbilce = new System.Windows.Forms.Label();
            this.cbilce = new System.Windows.Forms.ComboBox();
            this.cbHastane = new System.Windows.Forms.ComboBox();
            this.lbhastane = new System.Windows.Forms.Label();
            this.lbklinik = new System.Windows.Forms.Label();
            this.cbKlinik = new System.Windows.Forms.ComboBox();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.gbRandevuSaat = new System.Windows.Forms.GroupBox();
            this.lbs9 = new System.Windows.Forms.Label();
            this.lbs8 = new System.Windows.Forms.Label();
            this.lbs7 = new System.Windows.Forms.Label();
            this.lbs6 = new System.Windows.Forms.Label();
            this.lbs5 = new System.Windows.Forms.Label();
            this.lbs4 = new System.Windows.Forms.Label();
            this.lbs3 = new System.Windows.Forms.Label();
            this.lbs1 = new System.Windows.Forms.Label();
            this.lbs2 = new System.Windows.Forms.Label();
            this.lstRandevuListesi = new System.Windows.Forms.ListBox();
            this.lbbaslik = new System.Windows.Forms.Label();
            this.lbRandevuTar = new System.Windows.Forms.Label();
            this.dtpRanTar = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.gbRandevuSaat.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbil
            // 
            this.cbil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbil.FormattingEnabled = true;
            this.cbil.Location = new System.Drawing.Point(117, 52);
            this.cbil.Name = "cbil";
            this.cbil.Size = new System.Drawing.Size(121, 21);
            this.cbil.TabIndex = 0;
            this.cbil.SelectedIndexChanged += new System.EventHandler(this.cbil_SelectedIndexChanged);
            // 
            // lbil
            // 
            this.lbil.AutoSize = true;
            this.lbil.Location = new System.Drawing.Point(21, 55);
            this.lbil.Name = "lbil";
            this.lbil.Size = new System.Drawing.Size(70, 13);
            this.lbil.TabIndex = 1;
            this.lbil.Text = "İl Seçiniz      :";
            // 
            // lbilce
            // 
            this.lbilce.AutoSize = true;
            this.lbilce.Location = new System.Drawing.Point(21, 87);
            this.lbilce.Name = "lbilce";
            this.lbilce.Size = new System.Drawing.Size(70, 13);
            this.lbilce.TabIndex = 2;
            this.lbilce.Text = "İlçe Seçiniz  :";
            // 
            // cbilce
            // 
            this.cbilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbilce.FormattingEnabled = true;
            this.cbilce.Location = new System.Drawing.Point(117, 84);
            this.cbilce.Name = "cbilce";
            this.cbilce.Size = new System.Drawing.Size(121, 21);
            this.cbilce.TabIndex = 3;
            this.cbilce.SelectedIndexChanged += new System.EventHandler(this.cbilce_SelectedIndexChanged);
            // 
            // cbHastane
            // 
            this.cbHastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHastane.FormattingEnabled = true;
            this.cbHastane.Location = new System.Drawing.Point(117, 157);
            this.cbHastane.Name = "cbHastane";
            this.cbHastane.Size = new System.Drawing.Size(121, 21);
            this.cbHastane.TabIndex = 4;
            // 
            // lbhastane
            // 
            this.lbhastane.AutoSize = true;
            this.lbhastane.Location = new System.Drawing.Point(21, 160);
            this.lbhastane.Name = "lbhastane";
            this.lbhastane.Size = new System.Drawing.Size(90, 13);
            this.lbhastane.TabIndex = 5;
            this.lbhastane.Text = "Hastane Seçiniz :";
            // 
            // lbklinik
            // 
            this.lbklinik.AutoSize = true;
            this.lbklinik.Location = new System.Drawing.Point(21, 124);
            this.lbklinik.Name = "lbklinik";
            this.lbklinik.Size = new System.Drawing.Size(75, 13);
            this.lbklinik.TabIndex = 6;
            this.lbklinik.Text = "Klinik Seçiniz :";
            // 
            // cbKlinik
            // 
            this.cbKlinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKlinik.FormattingEnabled = true;
            this.cbKlinik.Location = new System.Drawing.Point(117, 121);
            this.cbKlinik.Name = "cbKlinik";
            this.cbKlinik.Size = new System.Drawing.Size(121, 21);
            this.cbKlinik.TabIndex = 7;
            this.cbKlinik.SelectedIndexChanged += new System.EventHandler(this.cbKlinik_SelectedIndexChanged);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(418, 195);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(114, 43);
            this.btnRandevuAl.TabIndex = 8;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbRandevuSaat
            // 
            this.gbRandevuSaat.Controls.Add(this.lbs9);
            this.gbRandevuSaat.Controls.Add(this.lbs8);
            this.gbRandevuSaat.Controls.Add(this.lbs7);
            this.gbRandevuSaat.Controls.Add(this.lbs6);
            this.gbRandevuSaat.Controls.Add(this.lbs5);
            this.gbRandevuSaat.Controls.Add(this.lbs4);
            this.gbRandevuSaat.Controls.Add(this.lbs3);
            this.gbRandevuSaat.Controls.Add(this.lbs1);
            this.gbRandevuSaat.Controls.Add(this.lbs2);
            this.gbRandevuSaat.ForeColor = System.Drawing.Color.Red;
            this.gbRandevuSaat.Location = new System.Drawing.Point(373, 52);
            this.gbRandevuSaat.Name = "gbRandevuSaat";
            this.gbRandevuSaat.Size = new System.Drawing.Size(198, 136);
            this.gbRandevuSaat.TabIndex = 9;
            this.gbRandevuSaat.TabStop = false;
            this.gbRandevuSaat.Text = "Randevu Saatleri";
            // 
            // lbs9
            // 
            this.lbs9.AutoSize = true;
            this.lbs9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbs9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs9.ForeColor = System.Drawing.Color.Green;
            this.lbs9.Location = new System.Drawing.Point(127, 100);
            this.lbs9.Name = "lbs9";
            this.lbs9.Size = new System.Drawing.Size(46, 18);
            this.lbs9.TabIndex = 19;
            this.lbs9.Text = "17:00";
            this.lbs9.Click += new System.EventHandler(this.label13_Click);
            // 
            // lbs8
            // 
            this.lbs8.AutoSize = true;
            this.lbs8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbs8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs8.ForeColor = System.Drawing.Color.Green;
            this.lbs8.Location = new System.Drawing.Point(75, 100);
            this.lbs8.Name = "lbs8";
            this.lbs8.Size = new System.Drawing.Size(46, 18);
            this.lbs8.TabIndex = 18;
            this.lbs8.Text = "16:00";
            this.lbs8.Click += new System.EventHandler(this.label12_Click);
            // 
            // lbs7
            // 
            this.lbs7.AutoSize = true;
            this.lbs7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbs7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs7.ForeColor = System.Drawing.Color.Green;
            this.lbs7.Location = new System.Drawing.Point(23, 100);
            this.lbs7.Name = "lbs7";
            this.lbs7.Size = new System.Drawing.Size(46, 18);
            this.lbs7.TabIndex = 17;
            this.lbs7.Text = "15:00";
            this.lbs7.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbs6
            // 
            this.lbs6.AutoSize = true;
            this.lbs6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbs6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs6.ForeColor = System.Drawing.Color.Green;
            this.lbs6.Location = new System.Drawing.Point(127, 64);
            this.lbs6.Name = "lbs6";
            this.lbs6.Size = new System.Drawing.Size(46, 18);
            this.lbs6.TabIndex = 16;
            this.lbs6.Text = "14:00";
            this.lbs6.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbs5
            // 
            this.lbs5.AutoSize = true;
            this.lbs5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbs5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs5.ForeColor = System.Drawing.Color.Green;
            this.lbs5.Location = new System.Drawing.Point(75, 64);
            this.lbs5.Name = "lbs5";
            this.lbs5.Size = new System.Drawing.Size(46, 18);
            this.lbs5.TabIndex = 15;
            this.lbs5.Text = "13:00";
            this.lbs5.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbs4
            // 
            this.lbs4.AutoSize = true;
            this.lbs4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbs4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs4.ForeColor = System.Drawing.Color.Green;
            this.lbs4.Location = new System.Drawing.Point(23, 64);
            this.lbs4.Name = "lbs4";
            this.lbs4.Size = new System.Drawing.Size(46, 18);
            this.lbs4.TabIndex = 14;
            this.lbs4.Text = "12:00";
            this.lbs4.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbs3
            // 
            this.lbs3.AutoSize = true;
            this.lbs3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbs3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs3.ForeColor = System.Drawing.Color.Green;
            this.lbs3.Location = new System.Drawing.Point(127, 27);
            this.lbs3.Name = "lbs3";
            this.lbs3.Size = new System.Drawing.Size(46, 18);
            this.lbs3.TabIndex = 13;
            this.lbs3.Text = "11:00";
            this.lbs3.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbs1
            // 
            this.lbs1.AutoSize = true;
            this.lbs1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs1.ForeColor = System.Drawing.Color.Green;
            this.lbs1.Location = new System.Drawing.Point(23, 27);
            this.lbs1.Name = "lbs1";
            this.lbs1.Size = new System.Drawing.Size(46, 18);
            this.lbs1.TabIndex = 11;
            this.lbs1.Text = "09:00";
            this.lbs1.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbs2
            // 
            this.lbs2.AutoSize = true;
            this.lbs2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs2.ForeColor = System.Drawing.Color.Green;
            this.lbs2.Location = new System.Drawing.Point(75, 27);
            this.lbs2.Name = "lbs2";
            this.lbs2.Size = new System.Drawing.Size(46, 18);
            this.lbs2.TabIndex = 12;
            this.lbs2.Text = "10:00";
            this.lbs2.Click += new System.EventHandler(this.label6_Click);
            // 
            // lstRandevuListesi
            // 
            this.lstRandevuListesi.FormattingEnabled = true;
            this.lstRandevuListesi.Location = new System.Drawing.Point(12, 295);
            this.lstRandevuListesi.Name = "lstRandevuListesi";
            this.lstRandevuListesi.Size = new System.Drawing.Size(660, 108);
            this.lstRandevuListesi.TabIndex = 11;
            this.lstRandevuListesi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbbaslik
            // 
            this.lbbaslik.AutoSize = true;
            this.lbbaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbbaslik.ForeColor = System.Drawing.Color.Red;
            this.lbbaslik.Location = new System.Drawing.Point(290, 263);
            this.lbbaslik.Name = "lbbaslik";
            this.lbbaslik.Size = new System.Drawing.Size(92, 18);
            this.lbbaslik.TabIndex = 12;
            this.lbbaslik.Text = "Randevular";
            // 
            // lbRandevuTar
            // 
            this.lbRandevuTar.AutoSize = true;
            this.lbRandevuTar.Location = new System.Drawing.Point(21, 195);
            this.lbRandevuTar.Name = "lbRandevuTar";
            this.lbRandevuTar.Size = new System.Drawing.Size(86, 13);
            this.lbRandevuTar.TabIndex = 13;
            this.lbRandevuTar.Text = "Randevu Tarihi :";
            // 
            // dtpRanTar
            // 
            this.dtpRanTar.Location = new System.Drawing.Point(117, 195);
            this.dtpRanTar.Name = "dtpRanTar";
            this.dtpRanTar.Size = new System.Drawing.Size(200, 20);
            this.dtpRanTar.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Randevu Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormHastaİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpRanTar);
            this.Controls.Add(this.lbRandevuTar);
            this.Controls.Add(this.lbbaslik);
            this.Controls.Add(this.lstRandevuListesi);
            this.Controls.Add(this.gbRandevuSaat);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.cbKlinik);
            this.Controls.Add(this.lbklinik);
            this.Controls.Add(this.lbhastane);
            this.Controls.Add(this.cbHastane);
            this.Controls.Add(this.cbilce);
            this.Controls.Add(this.lbilce);
            this.Controls.Add(this.lbil);
            this.Controls.Add(this.cbil);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(618, 500);
            this.Name = "FormHastaİslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHastaIslem";
            this.Load += new System.EventHandler(this.FormHastaİslem_Load);
            this.gbRandevuSaat.ResumeLayout(false);
            this.gbRandevuSaat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbil;
        private System.Windows.Forms.Label lbil;
        private System.Windows.Forms.Label lbilce;
        private System.Windows.Forms.ComboBox cbilce;
        private System.Windows.Forms.ComboBox cbHastane;
        private System.Windows.Forms.Label lbhastane;
        private System.Windows.Forms.Label lbklinik;
        private System.Windows.Forms.ComboBox cbKlinik;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.GroupBox gbRandevuSaat;
        private System.Windows.Forms.Label lbs1;
        private System.Windows.Forms.Label lbs2;
        private System.Windows.Forms.Label lbs3;
        private System.Windows.Forms.Label lbs9;
        private System.Windows.Forms.Label lbs8;
        private System.Windows.Forms.Label lbs7;
        private System.Windows.Forms.Label lbs6;
        private System.Windows.Forms.Label lbs5;
        private System.Windows.Forms.Label lbs4;
        private System.Windows.Forms.ListBox lstRandevuListesi;
        private System.Windows.Forms.Label lbbaslik;
        private System.Windows.Forms.Label lbRandevuTar;
        private System.Windows.Forms.DateTimePicker dtpRanTar;
        private System.Windows.Forms.Button button1;
    }
}