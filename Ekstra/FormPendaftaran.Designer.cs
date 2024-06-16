namespace Ekstra
{
    partial class FormPendaftaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPendaftaran));
            this.BttnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pendaftaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ekstraDataSet = new Ekstra.EkstraDataSet();
            this.BttnKembali = new System.Windows.Forms.Button();
            this.BttnHapus = new System.Windows.Forms.Button();
            this.BttnEdit = new System.Windows.Forms.Button();
            this.BttnDaftar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.KD = new System.Windows.Forms.TextBox();
            this.NIS = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.dataSiswaEkstrakurikulerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSiswaEkstrakurikulerTableAdapter = new Ekstra.EkstraDataSetTableAdapters.DataSiswaEkstrakurikulerTableAdapter();
            this.addPendaftaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addPendaftaranTableAdapter = new Ekstra.EkstraDataSetTableAdapters.AddPendaftaranTableAdapter();
            this.pendaftaranTableAdapter = new Ekstra.EkstraDataSetTableAdapters.PendaftaranTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPendaftaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BttnSave
            // 
            this.BttnSave.Location = new System.Drawing.Point(706, 231);
            this.BttnSave.Name = "BttnSave";
            this.BttnSave.Size = new System.Drawing.Size(75, 23);
            this.BttnSave.TabIndex = 35;
            this.BttnSave.Text = "Simpan";
            this.BttnSave.UseVisualStyleBackColor = true;
            this.BttnSave.Click += new System.EventHandler(this.BttnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tanggal Pendaftaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kode Ekstrakurikuler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "NIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // pendaftaranBindingSource
            // 
            this.pendaftaranBindingSource.DataMember = "Pendaftaran";
            this.pendaftaranBindingSource.DataSource = this.ekstraDataSet;
            // 
            // ekstraDataSet
            // 
            this.ekstraDataSet.DataSetName = "EkstraDataSet";
            this.ekstraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BttnKembali
            // 
            this.BttnKembali.Location = new System.Drawing.Point(806, 444);
            this.BttnKembali.Name = "BttnKembali";
            this.BttnKembali.Size = new System.Drawing.Size(75, 23);
            this.BttnKembali.TabIndex = 28;
            this.BttnKembali.Text = "Kembali";
            this.BttnKembali.UseVisualStyleBackColor = true;
            this.BttnKembali.Click += new System.EventHandler(this.BttnKembali_Click);
            // 
            // BttnHapus
            // 
            this.BttnHapus.Location = new System.Drawing.Point(706, 313);
            this.BttnHapus.Name = "BttnHapus";
            this.BttnHapus.Size = new System.Drawing.Size(75, 23);
            this.BttnHapus.TabIndex = 27;
            this.BttnHapus.Text = "Hapus";
            this.BttnHapus.UseVisualStyleBackColor = true;
            this.BttnHapus.Click += new System.EventHandler(this.BttnHapus_Click);
            // 
            // BttnEdit
            // 
            this.BttnEdit.Location = new System.Drawing.Point(706, 277);
            this.BttnEdit.Name = "BttnEdit";
            this.BttnEdit.Size = new System.Drawing.Size(75, 23);
            this.BttnEdit.TabIndex = 26;
            this.BttnEdit.Text = "Edit";
            this.BttnEdit.UseVisualStyleBackColor = true;
            this.BttnEdit.Click += new System.EventHandler(this.BttnEdit_Click);
            // 
            // BttnDaftar
            // 
            this.BttnDaftar.Location = new System.Drawing.Point(706, 187);
            this.BttnDaftar.Name = "BttnDaftar";
            this.BttnDaftar.Size = new System.Drawing.Size(75, 23);
            this.BttnDaftar.TabIndex = 25;
            this.BttnDaftar.Text = "Daftar";
            this.BttnDaftar.UseVisualStyleBackColor = true;
            this.BttnDaftar.Click += new System.EventHandler(this.BttnDaftar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Form Pendaftaran";
            // 
            // Date
            // 
            this.Date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pendaftaranBindingSource, "tanggal", true));
            this.Date.Location = new System.Drawing.Point(357, 313);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(302, 22);
            this.Date.TabIndex = 23;
            // 
            // KD
            // 
            this.KD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pendaftaranBindingSource, "kode_ekskul", true));
            this.KD.Location = new System.Drawing.Point(357, 268);
            this.KD.Name = "KD";
            this.KD.Size = new System.Drawing.Size(302, 22);
            this.KD.TabIndex = 22;
            // 
            // NIS
            // 
            this.NIS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pendaftaranBindingSource, "NIS", true));
            this.NIS.Location = new System.Drawing.Point(357, 219);
            this.NIS.Name = "NIS";
            this.NIS.Size = new System.Drawing.Size(302, 22);
            this.NIS.TabIndex = 21;
            // 
            // ID
            // 
            this.ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pendaftaranBindingSource, "id_pendaftaran", true));
            this.ID.Location = new System.Drawing.Point(357, 169);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(302, 22);
            this.ID.TabIndex = 20;
            // 
            // dataSiswaEkstrakurikulerBindingSource
            // 
            this.dataSiswaEkstrakurikulerBindingSource.DataMember = "DataSiswaEkstrakurikuler";
            this.dataSiswaEkstrakurikulerBindingSource.DataSource = this.ekstraDataSet;
            // 
            // dataSiswaEkstrakurikulerTableAdapter
            // 
            this.dataSiswaEkstrakurikulerTableAdapter.ClearBeforeFill = true;
            // 
            // addPendaftaranBindingSource
            // 
            this.addPendaftaranBindingSource.DataMember = "AddPendaftaran";
            this.addPendaftaranBindingSource.DataSource = this.ekstraDataSet;
            // 
            // addPendaftaranTableAdapter
            // 
            this.addPendaftaranTableAdapter.ClearBeforeFill = true;
            // 
            // pendaftaranTableAdapter
            // 
            this.pendaftaranTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.pendaftaranBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1016, 27);
            this.bindingNavigator1.TabIndex = 36;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // FormPendaftaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 626);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.BttnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttnKembali);
            this.Controls.Add(this.BttnHapus);
            this.Controls.Add(this.BttnEdit);
            this.Controls.Add(this.BttnDaftar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.KD);
            this.Controls.Add(this.NIS);
            this.Controls.Add(this.ID);
            this.Name = "FormPendaftaran";
            this.Text = "FormPendaftaran";
            this.Load += new System.EventHandler(this.FormPendaftaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaEkstrakurikulerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPendaftaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BttnKembali;
        private System.Windows.Forms.Button BttnHapus;
        private System.Windows.Forms.Button BttnEdit;
        private System.Windows.Forms.Button BttnDaftar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox KD;
        private System.Windows.Forms.TextBox NIS;
        private System.Windows.Forms.TextBox ID;
        private EkstraDataSet ekstraDataSet;
        private System.Windows.Forms.BindingSource dataSiswaEkstrakurikulerBindingSource;
        private EkstraDataSetTableAdapters.DataSiswaEkstrakurikulerTableAdapter dataSiswaEkstrakurikulerTableAdapter;
        private System.Windows.Forms.BindingSource addPendaftaranBindingSource;
        private EkstraDataSetTableAdapters.AddPendaftaranTableAdapter addPendaftaranTableAdapter;
        private System.Windows.Forms.BindingSource pendaftaranBindingSource;
        private EkstraDataSetTableAdapters.PendaftaranTableAdapter pendaftaranTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}