namespace HastaneRandevuSistemi
{
    partial class FormDoktorİslem
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
            this.lstHastakaydi = new System.Windows.Forms.ListBox();
            this.btnGörüntüle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOku = new System.Windows.Forms.Button();
            this.lstTip = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstHastakaydi
            // 
            this.lstHastakaydi.FormattingEnabled = true;
            this.lstHastakaydi.Location = new System.Drawing.Point(12, 249);
            this.lstHastakaydi.Name = "lstHastakaydi";
            this.lstHastakaydi.Size = new System.Drawing.Size(628, 147);
            this.lstHastakaydi.TabIndex = 0;
            // 
            // btnGörüntüle
            // 
            this.btnGörüntüle.Location = new System.Drawing.Point(264, 183);
            this.btnGörüntüle.Name = "btnGörüntüle";
            this.btnGörüntüle.Size = new System.Drawing.Size(137, 47);
            this.btnGörüntüle.TabIndex = 3;
            this.btnGörüntüle.Text = "Görüntüle";
            this.btnGörüntüle.UseVisualStyleBackColor = true;
            this.btnGörüntüle.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastaneRandevuSistemi.Properties.Resources.DoktorGiris;
            this.pictureBox1.Location = new System.Drawing.Point(231, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(537, 183);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(75, 23);
            this.btnOku.TabIndex = 5;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstTip
            // 
            this.lstTip.FormattingEnabled = true;
            this.lstTip.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.lstTip.Location = new System.Drawing.Point(525, 65);
            this.lstTip.Name = "lstTip";
            this.lstTip.Size = new System.Drawing.Size(100, 95);
            this.lstTip.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Günün Nasıl Geçiyor? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "(Derecelendir)";
            // 
            // FormDoktorİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTip);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGörüntüle);
            this.Controls.Add(this.lstHastakaydi);
            this.Name = "FormDoktorİslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoktorGiris";
            this.Load += new System.EventHandler(this.FormDoktorGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHastakaydi;
        private System.Windows.Forms.Button btnGörüntüle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.ListBox lstTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}