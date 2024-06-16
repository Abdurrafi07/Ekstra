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
    public partial class FormMenuUtama : Form
    {
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void BttnEkskul_Click(object sender, EventArgs e)
        {
           
            FormDaftarEkstrakurikuler formDaftarEkstrakurikuler = new FormDaftarEkstrakurikuler();
            formDaftarEkstrakurikuler.Show();
            this.Hide();
        }

        private void BttnSiswa_Click(object sender, EventArgs e)
        {
            FormDaftarSiswa formDaftarSiswa = new FormDaftarSiswa();

            formDaftarSiswa.Show();
            this.Hide();
        }

        private void BttnDaftar_Click(object sender, EventArgs e)
        {

            FormPendaftaran formPendaftaran = new FormPendaftaran();
            formPendaftaran.Show();
            this.Hide();
        }

        private void BttnRekap_Click(object sender, EventArgs e)
        {
            BttnRekap.Enabled = true;
            test_recap  testrecap = new test_recap();
            testrecap.Show();
        }

        private void BttnOut_Click(object sender, EventArgs e)
        {
            BttnOut.Enabled = true;
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }


    }
}
