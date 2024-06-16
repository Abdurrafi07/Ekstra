namespace Ekstra
{
    partial class FormDaftarSiswa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekstraDataSet = new Ekstra.EkstraDataSet();
            this.siswaTableAdapter = new Ekstra.EkstraDataSetTableAdapters.SiswaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pendaftaranTableAdapter = new Ekstra.EkstraDataSetTableAdapters.PendaftaranTableAdapter();
            this.ekstraDataSet1 = new Ekstra.EkstraDataSet1();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siswaTableAdapter1 = new Ekstra.EkstraDataSet1TableAdapters.SiswaTableAdapter();
            this.nISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nISDataGridViewTextBoxColumn,
            this.namasiswaDataGridViewTextBoxColumn,
            this.jKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siswaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(196, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ekstraDataSet
            // 
            this.ekstraDataSet.DataSetName = "EkstraDataSet";
            this.ekstraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siswaTableAdapter
            // 
            this.siswaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daftar Siswa";
            // 
            // pendaftaranTableAdapter
            // 
            this.pendaftaranTableAdapter.ClearBeforeFill = true;
            // 
            // ekstraDataSet1
            // 
            this.ekstraDataSet1.DataSetName = "EkstraDataSet1";
            this.ekstraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataMember = "Siswa";
            this.siswaBindingSource.DataSource = this.ekstraDataSet1;
            // 
            // siswaTableAdapter1
            // 
            this.siswaTableAdapter1.ClearBeforeFill = true;
            // 
            // nISDataGridViewTextBoxColumn
            // 
            this.nISDataGridViewTextBoxColumn.DataPropertyName = "NIS";
            this.nISDataGridViewTextBoxColumn.HeaderText = "NIS";
            this.nISDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nISDataGridViewTextBoxColumn.Name = "nISDataGridViewTextBoxColumn";
            this.nISDataGridViewTextBoxColumn.Width = 125;
            // 
            // namasiswaDataGridViewTextBoxColumn
            // 
            this.namasiswaDataGridViewTextBoxColumn.DataPropertyName = "nama_siswa";
            this.namasiswaDataGridViewTextBoxColumn.HeaderText = "nama_siswa";
            this.namasiswaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namasiswaDataGridViewTextBoxColumn.Name = "namasiswaDataGridViewTextBoxColumn";
            this.namasiswaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jKDataGridViewTextBoxColumn
            // 
            this.jKDataGridViewTextBoxColumn.DataPropertyName = "JK";
            this.jKDataGridViewTextBoxColumn.HeaderText = "JK";
            this.jKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jKDataGridViewTextBoxColumn.Name = "jKDataGridViewTextBoxColumn";
            this.jKDataGridViewTextBoxColumn.Width = 125;
            // 
            // kembali
            // 
            this.kembali.Location = new System.Drawing.Point(655, 381);
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(75, 23);
            this.kembali.TabIndex = 2;
            this.kembali.Text = "Kembali";
            this.kembali.UseVisualStyleBackColor = true;
            this.kembali.Click += new System.EventHandler(this.kembali_Click);
            // 
            // FormDaftarSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kembali);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDaftarSiswa";
            this.Text = "FormDaftarSiswa";
            this.Load += new System.EventHandler(this.FormDaftarSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EkstraDataSet ekstraDataSet;
        private EkstraDataSetTableAdapters.SiswaTableAdapter siswaTableAdapter;
        private System.Windows.Forms.Label label1;
        private EkstraDataSetTableAdapters.PendaftaranTableAdapter pendaftaranTableAdapter;
        private EkstraDataSet1 ekstraDataSet1;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private EkstraDataSet1TableAdapters.SiswaTableAdapter siswaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jKDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button kembali;
    }
}