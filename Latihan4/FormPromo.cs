using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan4
{
    public partial class FormPromo : Form
    {
        Koneksi koneksi = new Koneksi();
        public FormPromo()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_promo;", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void tombolTambah_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_promo VALUES(@kode, @nominal, @min)", conn);
            if (string.IsNullOrEmpty(kodePromo.Text)) {
                MessageBox.Show("Kode harus diisi!");
            }
            else if (string.IsNullOrEmpty(nominal.Text)) {
                MessageBox.Show("Nominal harus diisi!");
            }
            else if (string.IsNullOrEmpty(minPembelian.Text)) {
                MessageBox.Show("Pembelian harus diisi!");
            } else
            {
                conn.Open();
                cmd.Parameters.AddWithValue("kode", kodePromo.Text);
                cmd.Parameters.AddWithValue("nominal", nominal.Text);
                cmd.Parameters.AddWithValue("min", minPembelian.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Data berhasil ditambahkan!");
                Bersihkan();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kodePromo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nominal.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            minPembelian.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void tombolPerbarui_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_promo SET Nominal = @nominal, MinPembelian = @min WHERE KodePromo = @kode;", conn);
            if (string.IsNullOrEmpty(kodePromo.Text))
            {
                MessageBox.Show("Kode harus diisi!");
            }
            else
            {
                conn.Open();
                cmd.Parameters.AddWithValue("kode", kodePromo.Text);
                cmd.Parameters.AddWithValue("nominal", nominal.Text);
                cmd.Parameters.AddWithValue("min", minPembelian.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Data berhasil diperbarui!");
                Bersihkan();
            }
        }

        private void tombolHapus_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_promo WHERE KodePromo = @kode;", conn);
            if (string.IsNullOrEmpty(kodePromo.Text))
            {
                MessageBox.Show("Kode harus diisi!");
            }
            else
            {
                conn.Open();
                cmd.Parameters.AddWithValue("kode", kodePromo.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Data berhasil dihapus!");
                Bersihkan();
            }
        }

        private void Bersihkan()
        {
            kodePromo.Clear();
            nominal.Clear();
            minPembelian.Clear();
        }

        private void FormPromo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tombolBatal_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }
    }
}
