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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BttnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "")
            {
                MessageBox.Show("Username atau Password tidak boleh kosong");
            }
            else if (TxtUsername.Text == "Admin" && TxtPassword.Text == "admin123")
            {
                MessageBox.Show("Anda Berhasil Login");
                FormMenuUtama formMenuUtama = new FormMenuUtama();
                formMenuUtama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
