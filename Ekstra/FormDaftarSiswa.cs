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
    public partial class FormDaftarSiswa : Form
    {
        public FormDaftarSiswa()
        {
            InitializeComponent();
        }

        private void FormDaftarSiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ekstraDataSet1.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter1.Fill(this.ekstraDataSet1.Siswa);
            // TODO: This line of code loads data into the 'ekstraDataSet.Pendaftaran' table. You can move, or remove it, as needed.
            this.pendaftaranTableAdapter.Fill(this.ekstraDataSet.Pendaftaran);
            // TODO: This line of code loads data into the 'ekstraDataSet.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.ekstraDataSet.Siswa);

        }

        private void kembali_Click(object sender, EventArgs e)
        {
            FormMenuUtama formMenuUtama = new FormMenuUtama();

            formMenuUtama.Show();
            this.Hide();
        }
    }
}
