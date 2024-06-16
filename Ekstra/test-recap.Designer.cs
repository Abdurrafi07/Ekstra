namespace Ekstra
{
    partial class test_recap
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ekstraDataSet6 = new Ekstra.EkstraDataSet6();
            this.dataSiswaEkstrakurikulerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSiswaEkstrakurikulerTableAdapter = new Ekstra.EkstraDataSet6TableAdapters.DataSiswaEkstrakurikulerTableAdapter();
            this.statistikJumlahSiswaPerEkstrakurikulerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statistikJumlahSiswaPerEkstrakurikulerTableAdapter = new Ekstra.EkstraDataSet6TableAdapters.StatistikJumlahSiswaPerEkstrakurikulerTableAdapter();
            this.namaekskulDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahsiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikJumlahSiswaPerEkstrakurikulerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaekskulDataGridViewTextBoxColumn1,
            this.jumlahsiswaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.statistikJumlahSiswaPerEkstrakurikulerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(84, 93);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(491, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // ekstraDataSet6
            // 
            this.ekstraDataSet6.DataSetName = "EkstraDataSet6";
            this.ekstraDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSiswaEkstrakurikulerBindingSource
            // 
            this.dataSiswaEkstrakurikulerBindingSource.DataMember = "DataSiswaEkstrakurikuler";
            this.dataSiswaEkstrakurikulerBindingSource.DataSource = this.ekstraDataSet6;
            // 
            // dataSiswaEkstrakurikulerTableAdapter
            // 
            this.dataSiswaEkstrakurikulerTableAdapter.ClearBeforeFill = true;
            // 
            // statistikJumlahSiswaPerEkstrakurikulerBindingSource
            // 
            this.statistikJumlahSiswaPerEkstrakurikulerBindingSource.DataMember = "StatistikJumlahSiswaPerEkstrakurikuler";
            this.statistikJumlahSiswaPerEkstrakurikulerBindingSource.DataSource = this.ekstraDataSet6;
            // 
            // statistikJumlahSiswaPerEkstrakurikulerTableAdapter
            // 
            this.statistikJumlahSiswaPerEkstrakurikulerTableAdapter.ClearBeforeFill = true;
            // 
            // namaekskulDataGridViewTextBoxColumn1
            // 
            this.namaekskulDataGridViewTextBoxColumn1.DataPropertyName = "nama_ekskul";
            this.namaekskulDataGridViewTextBoxColumn1.HeaderText = "nama_ekskul";
            this.namaekskulDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.namaekskulDataGridViewTextBoxColumn1.Name = "namaekskulDataGridViewTextBoxColumn1";
            this.namaekskulDataGridViewTextBoxColumn1.Width = 125;
            // 
            // jumlahsiswaDataGridViewTextBoxColumn
            // 
            this.jumlahsiswaDataGridViewTextBoxColumn.DataPropertyName = "jumlah_siswa";
            this.jumlahsiswaDataGridViewTextBoxColumn.HeaderText = "jumlah_siswa";
            this.jumlahsiswaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahsiswaDataGridViewTextBoxColumn.Name = "jumlahsiswaDataGridViewTextBoxColumn";
            this.jumlahsiswaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Kembali
            // 
            this.Kembali.Location = new System.Drawing.Point(627, 325);
            this.Kembali.Name = "Kembali";
            this.Kembali.Size = new System.Drawing.Size(87, 37);
            this.Kembali.TabIndex = 2;
            this.Kembali.Text = "Kembali";
            this.Kembali.UseVisualStyleBackColor = true;
            this.Kembali.Click += new System.EventHandler(this.Kembali_Click);
            // 
            // test_recap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kembali);
            this.Controls.Add(this.dataGridView2);
            this.Name = "test_recap";
            this.Text = "test_recap";
            this.Load += new System.EventHandler(this.test_recap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikJumlahSiswaPerEkstrakurikulerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private EkstraDataSet6 ekstraDataSet6;
        private System.Windows.Forms.BindingSource dataSiswaEkstrakurikulerBindingSource;
        private EkstraDataSet6TableAdapters.DataSiswaEkstrakurikulerTableAdapter dataSiswaEkstrakurikulerTableAdapter;
        private System.Windows.Forms.BindingSource statistikJumlahSiswaPerEkstrakurikulerBindingSource;
        private EkstraDataSet6TableAdapters.StatistikJumlahSiswaPerEkstrakurikulerTableAdapter statistikJumlahSiswaPerEkstrakurikulerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaekskulDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahsiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Kembali;
    }
}