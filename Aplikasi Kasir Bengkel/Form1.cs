using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_master master = new Menu_master();
            this.Hide();
            master.Show(this);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Koneksi.conn.Open();
            //MessageBox.Show("koneksi");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_Transaksi transaksi = new Menu_Transaksi();
            this.Hide();
            transaksi.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_Laporan laporan = new Menu_Laporan();
            this.Hide();
            laporan.Show(this);
        }
    }
}
