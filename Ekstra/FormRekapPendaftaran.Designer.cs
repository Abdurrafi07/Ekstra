namespace Ekstra
{
    partial class FormRekapPendaftaran
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
            this.dataSiswaEkstrakurikulerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ekstraDataSet = new Ekstra.EkstraDataSet();
            this.dataSiswaEkstrakurikulerTableAdapter = new Ekstra.EkstraDataSetTableAdapters.DataSiswaEkstrakurikulerTableAdapter();
            this.statistikJumlahSiswaPerEkstrakurikulerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statistikJumlahSiswaPerEkstrakurikulerTableAdapter = new Ekstra.EkstraDataSetTableAdapters.StatistikJumlahSiswaPerEkstrakurikulerTableAdapter();
            this.statistikJumlahSiswaPerEkstrakurikulerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.namaekskulDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahsiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kembali = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSiswaEkstrakurikulerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ekstraDataSet4 = new Ekstra.EkstraDataSet4();
            this.dataSiswaEkstrakurikulerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSiswaEkstrakurikulerTableAdapter1 = new Ekstra.EkstraDataSet4TableAdapters.DataSiswaEkstrakurikulerTableAdapter();
            this.dataSiswaEkstrakurikulerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ekstraDataSet5 = new Ekstra.EkstraDataSet5();
            this.dataSiswaEkstrakurikulerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSiswaEkstrakurikulerTableAdapter2 = new Ekstra.EkstraDataSet5TableAdapters.DataSiswaEkstrakurikulerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikJumlahSiswaPerEkstrakurikulerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikJumlahSiswaPerEkstrakurikulerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSiswaEkstrakurikulerBindingSource
            // 
            this.dataSiswaEkstrakurikulerBindingSource.DataMember = "DataSiswaEkstrakurikuler";
            this.dataSiswaEkstrakurikulerBindingSource.DataSource = this.ekstraDataSet;
            // 
            // ekstraDataSet
            // 
            this.ekstraDataSet.DataSetName = "EkstraDataSet";
            this.ekstraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSiswaEkstrakurikulerTableAdapter
            // 
            this.dataSiswaEkstrakurikulerTableAdapter.ClearBeforeFill = true;
            // 
            // statistikJumlahSiswaPerEkstrakurikulerBindingSource
            // 
            this.statistikJumlahSiswaPerEkstrakurikulerBindingSource.DataMember = "StatistikJumlahSiswaPerEkstrakurikuler";
            this.statistikJumlahSiswaPerEkstrakurikulerBindingSource.DataSource = this.ekstraDataSet;
            // 
            // statistikJumlahSiswaPerEkstrakurikulerTableAdapter
            // 
            this.statistikJumlahSiswaPerEkstrakurikulerTableAdapter.ClearBeforeFill = true;
            // 
            // statistikJumlahSiswaPerEkstrakurikulerBindingSource1
            // 
            this.statistikJumlahSiswaPerEkstrakurikulerBindingSource1.DataMember = "StatistikJumlahSiswaPerEkstrakurikuler";
            this.statistikJumlahSiswaPerEkstrakurikulerBindingSource1.DataSource = this.ekstraDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaekskulDataGridViewTextBoxColumn1,
            this.jumlahsiswaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.statistikJumlahSiswaPerEkstrakurikulerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(75, 233);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(321, 150);
            this.dataGridView2.TabIndex = 1;
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
            this.Kembali.Location = new System.Drawing.Point(675, 359);
            this.Kembali.Name = "Kembali";
            this.Kembali.Size = new System.Drawing.Size(75, 23);
            this.Kembali.TabIndex = 2;
            this.Kembali.Text = "Kembali";
            this.Kembali.UseVisualStyleBackColor = true;
            this.Kembali.Click += new System.EventHandler(this.Kembali_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.dataSiswaEkstrakurikulerBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(75, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(321, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nama_ekskul";
            this.dataGridViewTextBoxColumn1.HeaderText = "nama_ekskul";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataSiswaEkstrakurikulerBindingSource1
            // 
            this.dataSiswaEkstrakurikulerBindingSource1.DataMember = "DataSiswaEkstrakurikuler";
            this.dataSiswaEkstrakurikulerBindingSource1.DataSource = this.ekstraDataSet;
            // 
            // ekstraDataSet4
            // 
            this.ekstraDataSet4.DataSetName = "EkstraDataSet4";
            this.ekstraDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSiswaEkstrakurikulerBindingSource2
            // 
            this.dataSiswaEkstrakurikulerBindingSource2.DataMember = "DataSiswaEkstrakurikuler";
            this.dataSiswaEkstrakurikulerBindingSource2.DataSource = this.ekstraDataSet4;
            // 
            // dataSiswaEkstrakurikulerTableAdapter1
            // 
            this.dataSiswaEkstrakurikulerTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSiswaEkstrakurikulerBindingSource3
            // 
            this.dataSiswaEkstrakurikulerBindingSource3.DataMember = "DataSiswaEkstrakurikuler";
            this.dataSiswaEkstrakurikulerBindingSource3.DataSource = this.ekstraDataSet4;
            // 
            // ekstraDataSet5
            // 
            this.ekstraDataSet5.DataSetName = "EkstraDataSet5";
            this.ekstraDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSiswaEkstrakurikulerBindingSource4
            // 
            this.dataSiswaEkstrakurikulerBindingSource4.DataMember = "DataSiswaEkstrakurikuler";
            this.dataSiswaEkstrakurikulerBindingSource4.DataSource = this.ekstraDataSet5;
            // 
            // dataSiswaEkstrakurikulerTableAdapter2
            // 
            this.dataSiswaEkstrakurikulerTableAdapter2.ClearBeforeFill = true;
            // 
            // FormRekapPendaftaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Kembali);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormRekapPendaftaran";
            this.Text = "FormRekapPendaftaran";
            this.Load += new System.EventHandler(this.FormRekapPendaftaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikJumlahSiswaPerEkstrakurikulerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikJumlahSiswaPerEkstrakurikulerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EkstraDataSet ekstraDataSet;
        private System.Windows.Forms.BindingSource dataSiswaEkstrakurikulerBindingSource;
        private EkstraDataSetTableAdapters.DataSiswaEkstrakurikulerTableAdapter dataSiswaEkstrakurikulerTableAdapter;
        private System.Windows.Forms.BindingSource statistikJumlahSiswaPerEkstrakurikulerBindingSource;
        private EkstraDataSetTableAdapters.StatistikJumlahSiswaPerEkstrakurikulerTableAdapter statistikJumlahSiswaPerEkstrakurikulerTableAdapter;
        private System.Windows.Forms.BindingSource statistikJumlahSiswaPerEkstrakurikulerBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaekskulDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahsiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Kembali;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource dataSiswaEkstrakurikulerBindingSource1;
        private EkstraDataSet4 ekstraDataSet4;
        private System.Windows.Forms.BindingSource dataSiswaEkstrakurikulerBindingSource2;
        private EkstraDataSet4TableAdapters.DataSiswaEkstrakurikulerTableAdapter dataSiswaEkstrakurikulerTableAdapter1;
        private System.Windows.Forms.BindingSource dataSiswaEkstrakurikulerBindingSource3;
        private EkstraDataSet5 ekstraDataSet5;
        private System.Windows.Forms.BindingSource dataSiswaEkstrakurikulerBindingSource4;
        private EkstraDataSet5TableAdapters.DataSiswaEkstrakurikulerTableAdapter dataSiswaEkstrakurikulerTableAdapter2;
    }
}