using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Kasir_Bengkel
{
    public partial class Menu_Barang : Form
    {
        public Menu_Barang()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 keluar = new Form1();
            this.Hide();
            keluar.Show(this);
        }
    }
}
