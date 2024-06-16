namespace Ekstra
{
    partial class FormMenuUtama
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
            this.Judul = new System.Windows.Forms.Label();
            this.BttnOut = new System.Windows.Forms.Button();
            this.BttnRekap = new System.Windows.Forms.Button();
            this.BttnDaftar = new System.Windows.Forms.Button();
            this.BttnEkskul = new System.Windows.Forms.Button();
            this.BttnSiswa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Location = new System.Drawing.Point(357, 103);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(83, 16);
            this.Judul.TabIndex = 11;
            this.Judul.Text = "Menu Utama";
            // 
            // BttnOut
            // 
            this.BttnOut.Location = new System.Drawing.Point(225, 325);
            this.BttnOut.Name = "BttnOut";
            this.BttnOut.Size = new System.Drawing.Size(351, 23);
            this.BttnOut.TabIndex = 10;
            this.BttnOut.Text = "Keluar";
            this.BttnOut.UseVisualStyleBackColor = true;
            this.BttnOut.Click += new System.EventHandler(this.BttnOut_Click);
            // 
            // BttnRekap
            // 
            this.BttnRekap.Location = new System.Drawing.Point(225, 280);
            this.BttnRekap.Name = "BttnRekap";
            this.BttnRekap.Size = new System.Drawing.Size(351, 23);
            this.BttnRekap.TabIndex = 9;
            this.BttnRekap.Text = "Rekap Pendaftaran";
            this.BttnRekap.UseVisualStyleBackColor = true;
            this.BttnRekap.Click += new System.EventHandler(this.BttnRekap_Click);
            // 
            // BttnDaftar
            // 
            this.BttnDaftar.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.BttnDaftar.Location = new System.Drawing.Point(225, 235);
            this.BttnDaftar.Name = "BttnDaftar";
            this.BttnDaftar.Size = new System.Drawing.Size(351, 23);
            this.BttnDaftar.TabIndex = 8;
            this.BttnDaftar.Text = "Pendaftaran";
            this.BttnDaftar.UseVisualStyleBackColor = true;
            this.BttnDaftar.Click += new System.EventHandler(this.BttnDaftar_Click);
            // 
            // BttnEkskul
            // 
            this.BttnEkskul.Location = new System.Drawing.Point(225, 154);
            this.BttnEkskul.Name = "BttnEkskul";
            this.BttnEkskul.Size = new System.Drawing.Size(351, 23);
            this.BttnEkskul.TabIndex = 7;
            this.BttnEkskul.Text = "Daftar Ekstrakurikuler";
            this.BttnEkskul.UseVisualStyleBackColor = true;
            this.BttnEkskul.Click += new System.EventHandler(this.BttnEkskul_Click);
            // 
            // BttnSiswa
            // 
            this.BttnSiswa.Location = new System.Drawing.Point(225, 193);
            this.BttnSiswa.Name = "BttnSiswa";
            this.BttnSiswa.Size = new System.Drawing.Size(351, 23);
            this.BttnSiswa.TabIndex = 6;
            this.BttnSiswa.Text = "Daftar Siswa";
            this.BttnSiswa.UseVisualStyleBackColor = true;
            this.BttnSiswa.Click += new System.EventHandler(this.BttnSiswa_Click);
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.BttnOut);
            this.Controls.Add(this.BttnRekap);
            this.Controls.Add(this.BttnDaftar);
            this.Controls.Add(this.BttnEkskul);
            this.Controls.Add(this.BttnSiswa);
            this.Name = "FormMenuUtama";
            this.Text = "FormMenuUtama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Button BttnOut;
        private System.Windows.Forms.Button BttnRekap;
        private System.Windows.Forms.Button BttnDaftar;
        private System.Windows.Forms.Button BttnEkskul;
        private System.Windows.Forms.Button BttnSiswa;
    }
}