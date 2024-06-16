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
    public partial class test_recap : Form
    {
        public test_recap()
        {
            InitializeComponent();
        }

        private void test_recap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ekstraDataSet6.StatistikJumlahSiswaPerEkstrakurikuler' table. You can move, or remove it, as needed.
            this.statistikJumlahSiswaPerEkstrakurikulerTableAdapter.Fill(this.ekstraDataSet6.StatistikJumlahSiswaPerEkstrakurikuler);

        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            FormMenuUtama formMenuUtama = new FormMenuUtama();

            formMenuUtama.Show();
            this.Hide();
        }
    }
}
