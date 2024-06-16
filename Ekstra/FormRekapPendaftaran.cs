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
    public partial class FormRekapPendaftaran : Form
    {
        public FormRekapPendaftaran()
        {
            InitializeComponent();
        }

        private void FormRekapPendaftaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ekstraDataSet5.DataSiswaEkstrakurikuler' table. You can move, or remove it, as needed.
            this.dataSiswaEkstrakurikulerTableAdapter2.Fill(this.ekstraDataSet5.DataSiswaEkstrakurikuler);
            // TODO: This line of code loads data into the 'ekstraDataSet4.DataSiswaEkstrakurikuler' table. You can move, or remove it, as needed.
            this.dataSiswaEkstrakurikulerTableAdapter1.Fill(this.ekstraDataSet4.DataSiswaEkstrakurikuler);
            // TODO: This line of code loads data into the 'ekstraDataSet.StatistikJumlahSiswaPerEkstrakurikuler' table. You can move, or remove it, as needed.
            this.statistikJumlahSiswaPerEkstrakurikulerTableAdapter.Fill(this.ekstraDataSet.StatistikJumlahSiswaPerEkstrakurikuler);


        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            FormMenuUtama formMenuUtama = new FormMenuUtama();

            formMenuUtama.Show();
            this.Hide();
        }
    }
}
