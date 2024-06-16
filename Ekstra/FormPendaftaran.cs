using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekstra
{
    public partial class FormPendaftaran : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        int bttn;
        public FormPendaftaran()
        {
            InitializeComponent();
        }

        private void FormPendaftaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ekstraDataSet.Pendaftaran' table. You can move, or remove it, as needed.
            this.pendaftaranTableAdapter.Fill(this.ekstraDataSet.Pendaftaran);
            ID.Enabled = false;
            NIS.Enabled = false;
            KD.Enabled = false;
            Date.Enabled = false;

        }

        private void BttnKembali_Click(object sender, EventArgs e)
        {
            FormMenuUtama formMenuUtama = new FormMenuUtama();

            formMenuUtama.Show();
            this.Hide();
        }

        private void BttnDaftar_Click(object sender, EventArgs e)
        {
            bttn = 1;
            tambah();
        }

        public void tambah()
        {

                BttnSave.Enabled = true;
                ID.Enabled = true;
                NIS.Enabled = true;
                KD.Enabled = true;
                Date.Enabled = true;

                ID.Text = "";
                NIS.Text = "";
                KD.Text = "";
                Date.Text = "";

                BttnDaftar.Enabled = false;
                BttnEdit.Enabled = false;
                BttnHapus.Enabled = false;
        }

        private void BttnSave_Click(object sender, EventArgs e)
        {
            if (bttn == 1)
            {
                dt = ekstraDataSet.Tables["Pendaftaran"];
                //Menyimpan
                dr = dt.NewRow();
                dr[0] = ID.Text;
                dr[1] = NIS.Text;
                dr[2] = KD.Text;
                dr[3] = DateTime.Now;
                dt.Rows.Add(dr);
            }
            else
            {
                dt = ekstraDataSet.Tables["Pendaftaran"];
                //Menacari Primary KEY yang akan diubah datanya
                dr = dt.Rows.Find(ID.Text);

                //Mengubah
                dr.BeginEdit();
                dr["id_pendaftaran"] = ID.Text;
                dr["NIS"] = NIS.Text;
                dr["kode_ekskul"] = KD.Text;
                dr["Tanggal"] =   Date.Text;
                dr.EndEdit();
            }

            pendaftaranTableAdapter.Update(ekstraDataSet);
            ID.Enabled= false;
            NIS.Enabled = false;
            KD.Enabled = false;
            Date.Enabled = false;

            this.pendaftaranTableAdapter.Fill
                (this.ekstraDataSet.Pendaftaran);
            BttnDaftar.Enabled = true;
            BttnEdit.Enabled = true;
            BttnHapus.Enabled = true;
            BttnSave.Enabled = false;
        }

        private void BttnEdit_Click(object sender, EventArgs e)
        {
            bttn = 2;

            BttnSave.Enabled = true;
            NIS.Enabled = true;
            KD.Enabled = true;
            Date.Enabled = true;

            BttnDaftar.Enabled = false;
            BttnEdit.Enabled = false;
            BttnHapus.Enabled = false;
        }

        private void BttnHapus_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show(this, "Apakah anda ingin menghapus data ini?", "Konfirmasi Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                hapus();
            }
        }

        public void hapus()
        {
            string code;
            code = ID.Text;
            // Mencari data yang akan dihapus berdasarkan primary KEY
            dr = ekstraDataSet.Tables["Pendaftaran"].Rows.Find(code);
            // Menghapus data
            dr.Delete();
            pendaftaranTableAdapter.Update(ekstraDataSet);
        }
    }
}

