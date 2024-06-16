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
    public partial class FormDaftarEkstrakurikuler : Form
    {
        public FormDaftarEkstrakurikuler()
        {
            InitializeComponent();
        }

        private void FormDaftarEkstrakurikuler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ekstraDataSet.Ekstrakurikuler' table. You can move, or remove it, as needed.
            this.ekstrakurikulerTableAdapter.Fill(this.ekstraDataSet.Ekstrakurikuler);

        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            FormMenuUtama formMenuUtama = new FormMenuUtama();

            formMenuUtama.Show();
            this.Hide();
        }
    }
}
