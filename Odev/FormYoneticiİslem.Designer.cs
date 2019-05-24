namespace HastaneRandevuSistemi
{
    partial class FormYoneticiİslem
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
            this.components = new System.ComponentModel.Container();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbSoyadEkle = new System.Windows.Forms.Label();
            this.lbAdEkle = new System.Windows.Forms.Label();
            this.lbKuladEkle = new System.Windows.Forms.Label();
            this.tbAdEkle = new System.Windows.Forms.TextBox();
            this.tbSoyadEkle = new System.Windows.Forms.TextBox();
            this.tbKuladEkle = new System.Windows.Forms.TextBox();
            this.tbSifreEkle = new System.Windows.Forms.TextBox();
            this.lbSifreEkle = new System.Windows.Forms.Label();
            this.lbBaslik = new System.Windows.Forms.Label();
            this.lbetiketekle = new System.Windows.Forms.Label();
            this.lbİDSil = new System.Windows.Forms.Label();
            this.tbidSil = new System.Windows.Forms.TextBox();
            this.lbetiketara = new System.Windows.Forms.Label();
            this.tbDoktoridEkle = new System.Windows.Forms.TextBox();
            this.lbDoktoridEkle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgwListe = new System.Windows.Forms.DataGridView();
            this.doktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new HastaneRandevuSistemi.DataSet1();
            this.doktorTableAdapter = new HastaneRandevuSistemi.DataSet1TableAdapters.doktorTableAdapter();
            this.btnSil = new System.Windows.Forms.Button();
            this.pbYoneticiIslem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYoneticiIslem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(133, 227);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(74, 35);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Doktor Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // lbSoyadEkle
            // 
            this.lbSoyadEkle.AutoSize = true;
            this.lbSoyadEkle.Location = new System.Drawing.Point(36, 142);
            this.lbSoyadEkle.Name = "lbSoyadEkle";
            this.lbSoyadEkle.Size = new System.Drawing.Size(43, 13);
            this.lbSoyadEkle.TabIndex = 2;
            this.lbSoyadEkle.Text = "Soyad :";
            // 
            // lbAdEkle
            // 
            this.lbAdEkle.AutoSize = true;
            this.lbAdEkle.Location = new System.Drawing.Point(36, 116);
            this.lbAdEkle.Name = "lbAdEkle";
            this.lbAdEkle.Size = new System.Drawing.Size(26, 13);
            this.lbAdEkle.TabIndex = 3;
            this.lbAdEkle.Text = "Ad :";
            // 
            // lbKuladEkle
            // 
            this.lbKuladEkle.AutoSize = true;
            this.lbKuladEkle.Location = new System.Drawing.Point(36, 171);
            this.lbKuladEkle.Name = "lbKuladEkle";
            this.lbKuladEkle.Size = new System.Drawing.Size(70, 13);
            this.lbKuladEkle.TabIndex = 4;
            this.lbKuladEkle.Text = "Kullanıcı Adı :";
            // 
            // tbAdEkle
            // 
            this.tbAdEkle.Location = new System.Drawing.Point(124, 113);
            this.tbAdEkle.MaxLength = 10;
            this.tbAdEkle.Name = "tbAdEkle";
            this.tbAdEkle.Size = new System.Drawing.Size(100, 20);
            this.tbAdEkle.TabIndex = 5;
            this.tbAdEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAdEkle_KeyPress);
            // 
            // tbSoyadEkle
            // 
            this.tbSoyadEkle.Location = new System.Drawing.Point(124, 142);
            this.tbSoyadEkle.MaxLength = 10;
            this.tbSoyadEkle.Name = "tbSoyadEkle";
            this.tbSoyadEkle.Size = new System.Drawing.Size(100, 20);
            this.tbSoyadEkle.TabIndex = 6;
            this.tbSoyadEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoyadEkle_KeyPress);
            // 
            // tbKuladEkle
            // 
            this.tbKuladEkle.Location = new System.Drawing.Point(124, 168);
            this.tbKuladEkle.MaxLength = 10;
            this.tbKuladEkle.Name = "tbKuladEkle";
            this.tbKuladEkle.Size = new System.Drawing.Size(100, 20);
            this.tbKuladEkle.TabIndex = 7;
            this.tbKuladEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKuladEkle_KeyPress);
            // 
            // tbSifreEkle
            // 
            this.tbSifreEkle.Location = new System.Drawing.Point(124, 197);
            this.tbSifreEkle.MaxLength = 10;
            this.tbSifreEkle.Name = "tbSifreEkle";
            this.tbSifreEkle.Size = new System.Drawing.Size(100, 20);
            this.tbSifreEkle.TabIndex = 8;
            this.tbSifreEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSifreEkle_KeyPress);
            // 
            // lbSifreEkle
            // 
            this.lbSifreEkle.AutoSize = true;
            this.lbSifreEkle.Location = new System.Drawing.Point(36, 200);
            this.lbSifreEkle.Name = "lbSifreEkle";
            this.lbSifreEkle.Size = new System.Drawing.Size(40, 13);
            this.lbSifreEkle.TabIndex = 9;
            this.lbSifreEkle.Text = "Şifre   :";
            // 
            // lbBaslik
            // 
            this.lbBaslik.AutoSize = true;
            this.lbBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBaslik.ForeColor = System.Drawing.Color.Red;
            this.lbBaslik.Location = new System.Drawing.Point(224, 9);
            this.lbBaslik.Name = "lbBaslik";
            this.lbBaslik.Size = new System.Drawing.Size(147, 24);
            this.lbBaslik.TabIndex = 12;
            this.lbBaslik.Text = "Yönetici İşlemler";
            // 
            // lbetiketekle
            // 
            this.lbetiketekle.AutoSize = true;
            this.lbetiketekle.ForeColor = System.Drawing.Color.Red;
            this.lbetiketekle.Location = new System.Drawing.Point(130, 60);
            this.lbetiketekle.Name = "lbetiketekle";
            this.lbetiketekle.Size = new System.Drawing.Size(83, 13);
            this.lbetiketekle.TabIndex = 14;
            this.lbetiketekle.Text = "DOKTOR EKLE";
            // 
            // lbİDSil
            // 
            this.lbİDSil.AutoSize = true;
            this.lbİDSil.Location = new System.Drawing.Point(272, 145);
            this.lbİDSil.Name = "lbİDSil";
            this.lbİDSil.Size = new System.Drawing.Size(27, 13);
            this.lbİDSil.TabIndex = 15;
            this.lbİDSil.Text = "İD  :";
            // 
            // tbidSil
            // 
            this.tbidSil.Location = new System.Drawing.Point(305, 142);
            this.tbidSil.MaxLength = 5;
            this.tbidSil.Name = "tbidSil";
            this.tbidSil.Size = new System.Drawing.Size(100, 20);
            this.tbidSil.TabIndex = 16;
            this.tbidSil.TextChanged += new System.EventHandler(this.tbidSil_TextChanged);
            this.tbidSil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbidSil_KeyPress);
            // 
            // lbetiketara
            // 
            this.lbetiketara.AutoSize = true;
            this.lbetiketara.ForeColor = System.Drawing.Color.Red;
            this.lbetiketara.Location = new System.Drawing.Point(316, 113);
            this.lbetiketara.Name = "lbetiketara";
            this.lbetiketara.Size = new System.Drawing.Size(78, 13);
            this.lbetiketara.TabIndex = 29;
            this.lbetiketara.Text = "DOKTOR ARA";
            // 
            // tbDoktoridEkle
            // 
            this.tbDoktoridEkle.Location = new System.Drawing.Point(124, 87);
            this.tbDoktoridEkle.MaxLength = 5;
            this.tbDoktoridEkle.Name = "tbDoktoridEkle";
            this.tbDoktoridEkle.Size = new System.Drawing.Size(100, 20);
            this.tbDoktoridEkle.TabIndex = 31;
            this.tbDoktoridEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDoktoridEkle_KeyPress);
            this.tbDoktoridEkle.MouseHover += new System.EventHandler(this.tbDoktoridEkle_MouseHover);
            // 
            // lbDoktoridEkle
            // 
            this.lbDoktoridEkle.AutoSize = true;
            this.lbDoktoridEkle.Location = new System.Drawing.Point(36, 90);
            this.lbDoktoridEkle.Name = "lbDoktoridEkle";
            this.lbDoktoridEkle.Size = new System.Drawing.Size(39, 13);
            this.lbDoktoridEkle.TabIndex = 30;
            this.lbDoktoridEkle.Text = "İD      :";
            this.lbDoktoridEkle.MouseHover += new System.EventHandler(this.lbDoktoridEkle_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            // 
            // dgwListe
            // 
            this.dgwListe.AllowUserToOrderColumns = true;
            this.dgwListe.AutoGenerateColumns = false;
            this.dgwListe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktoridDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.kuladDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.dgwListe.DataSource = this.doktorBindingSource;
            this.dgwListe.Location = new System.Drawing.Point(28, 283);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.ReadOnly = true;
            this.dgwListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwListe.Size = new System.Drawing.Size(544, 150);
            this.dgwListe.TabIndex = 32;
            // 
            // doktoridDataGridViewTextBoxColumn
            // 
            this.doktoridDataGridViewTextBoxColumn.DataPropertyName = "doktorid";
            this.doktoridDataGridViewTextBoxColumn.HeaderText = "doktorid";
            this.doktoridDataGridViewTextBoxColumn.Name = "doktoridDataGridViewTextBoxColumn";
            this.doktoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kuladDataGridViewTextBoxColumn
            // 
            this.kuladDataGridViewTextBoxColumn.DataPropertyName = "kulad";
            this.kuladDataGridViewTextBoxColumn.HeaderText = "kulad";
            this.kuladDataGridViewTextBoxColumn.Name = "kuladDataGridViewTextBoxColumn";
            this.kuladDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorBindingSource
            // 
            this.doktorBindingSource.DataMember = "doktor";
            this.doktorBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorTableAdapter
            // 
            this.doktorTableAdapter.ClearBeforeFill = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(319, 227);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 35);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "Doktor Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pbYoneticiIslem
            // 
            this.pbYoneticiIslem.Image = global::HastaneRandevuSistemi.Properties.Resources.YöneticiGiris;
            this.pbYoneticiIslem.Location = new System.Drawing.Point(458, 45);
            this.pbYoneticiIslem.Name = "pbYoneticiIslem";
            this.pbYoneticiIslem.Size = new System.Drawing.Size(114, 182);
            this.pbYoneticiIslem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbYoneticiIslem.TabIndex = 34;
            this.pbYoneticiIslem.TabStop = false;
            // 
            // FormYoneticiİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(597, 455);
            this.Controls.Add(this.pbYoneticiIslem);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgwListe);
            this.Controls.Add(this.tbDoktoridEkle);
            this.Controls.Add(this.lbDoktoridEkle);
            this.Controls.Add(this.lbetiketara);
            this.Controls.Add(this.tbidSil);
            this.Controls.Add(this.lbİDSil);
            this.Controls.Add(this.lbetiketekle);
            this.Controls.Add(this.lbBaslik);
            this.Controls.Add(this.lbSifreEkle);
            this.Controls.Add(this.tbSifreEkle);
            this.Controls.Add(this.tbKuladEkle);
            this.Controls.Add(this.tbSoyadEkle);
            this.Controls.Add(this.tbAdEkle);
            this.Controls.Add(this.lbKuladEkle);
            this.Controls.Add(this.lbAdEkle);
            this.Controls.Add(this.lbSoyadEkle);
            this.Controls.Add(this.btnEkle);
            this.MaximumSize = new System.Drawing.Size(613, 494);
            this.MinimumSize = new System.Drawing.Size(613, 494);
            this.Name = "FormYoneticiİslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormYoneticiİslem";
            this.Load += new System.EventHandler(this.FormYoneticiİslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYoneticiIslem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lbSoyadEkle;
        private System.Windows.Forms.Label lbAdEkle;
        private System.Windows.Forms.Label lbKuladEkle;
        private System.Windows.Forms.TextBox tbAdEkle;
        private System.Windows.Forms.TextBox tbSoyadEkle;
        private System.Windows.Forms.TextBox tbKuladEkle;
        private System.Windows.Forms.TextBox tbSifreEkle;
        private System.Windows.Forms.Label lbSifreEkle;
        private System.Windows.Forms.Label lbBaslik;
        private System.Windows.Forms.Label lbetiketekle;
        private System.Windows.Forms.Label lbİDSil;
        private System.Windows.Forms.TextBox tbidSil;
        private System.Windows.Forms.Label lbetiketara;
        private System.Windows.Forms.TextBox tbDoktoridEkle;
        private System.Windows.Forms.Label lbDoktoridEkle;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgwListe;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource doktorBindingSource;
        private DataSet1TableAdapters.doktorTableAdapter doktorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pbYoneticiIslem;
    }
}