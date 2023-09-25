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
    public partial class Menu_Transaksi : Form
    {
        public Menu_Transaksi()
        {
            InitializeComponent();
        }

        private void Menu_Transaksi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Jual_Onderdil jual_onderdil = new Menu_Jual_Onderdil();
            jual_onderdil.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_Servis servis = new Menu_Servis();
            servis.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_bayar_Tambah bayar_atau_tambah = new Menu_bayar_Tambah();
            bayar_atau_tambah.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu_Pembayaran_Hutang pembayaran_hutang = new Menu_Pembayaran_Hutang();
            pembayaran_hutang.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 keluar = new Form1();
            this.Hide();
            keluar.Show(this);
        }
    }
}
