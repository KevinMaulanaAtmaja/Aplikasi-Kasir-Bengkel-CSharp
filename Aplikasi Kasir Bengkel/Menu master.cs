using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Aplikasi_Kasir_Bengkel
{
    public partial class Menu_master : Form
    {

        public MySqlCommand cmd;
        public string idIdentitas;

        public Menu_master()
        {
            InitializeComponent();
        }

        void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM 'tblidentitas'", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }


        private void Menu_master_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Ini Muncul Saat FOrm dipanggil");

            //Koneksi.conn.Open(); //ini membuka koneksi database

            //ini digunakan untuk mengambil data di tabel siswa
            //MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tbl_identitas`",Koneksi.conn);

            //membuat objek Dasa Set Baru
            //DataSet ds = new DataSet();
            //ini digunakan untuk mengisi dataset dari Data Adapter
            //adapter.Fill(ds);

            //Mengisi DataGrid Siswa dengan DataSet
            //abdulKhalim.DataSource = ds.Tables[0];
            //Koneksi.conn.Close();

            
         tampil();



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO 'tblidentitas' ('id_identitas', 'nama_bengkel', 'no_telp_bengkel', 'alamat_bengkel', 'caption_pertama', 'caption_kedua', 'caption_ketiga');");
            Koneksi.conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1.Rows[baris].Cells[0].Value.ToString();
            //MessageBox.Show(id);
            textBox3.Text = dataGridView1.Rows[baris].Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.Rows[baris].Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.Rows[baris].Cells[3].Value.ToString();
            textBox10.Text = dataGridView1.Rows[baris].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.Rows[baris].Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.Rows[baris].Cells[6].Value.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                //cmd = new MySqlCommand("UPDATE `tbidentitas` SET `nama_bengkel` = '" + textBox3.Text + "', `no_telp_bengkel` = '" + textBox5.Text + "', `alamat_bengkel` = '" + textBox9.Text + "' WHERE `tbidentitas`.`id` = '" + textBox6.Text + "';", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Siswa");
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Update Gagal");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_Kategori kategori = new Menu_Kategori();
            this.Hide();
            kategori.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_Barang barang = new Menu_Barang();
            this.Hide();
            barang.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu_Jasa jasa = new Menu_Jasa();
            this.Hide();
            jasa.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu_Pelanggan pelanggan = new Menu_Pelanggan();
            this.Hide();
            pelanggan.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu_Teknisi teknisi = new Menu_Teknisi();
            this.Hide();
            teknisi.Show(this);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 keluar = new Form1();
            this.Hide();
            keluar.Show(this);
        }
    }
}
