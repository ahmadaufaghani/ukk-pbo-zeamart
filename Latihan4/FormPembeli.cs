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
    public partial class FormPembeli : Form
    {
        Koneksi koneksi = new Koneksi();
        public FormPembeli()
        {
            InitializeComponent();
        }

        private void KodePembeli()
        {
            int hitung;
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT KodePembeli FROM tbl_pembeli WHERE KodePembeli IN(SELECT MAX(KodePembeli) FROM tbl_pembeli) ORDER BY KodePembeli DESC", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                hitung = Convert.ToInt32(dr["KodePembeli"]) + 1;
                boksKodePembeli.Text = hitung.ToString();
            }
            else
            {
                boksKodePembeli.Text = "1";
            }
            conn.Close();
        }

        private void LoadData()
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_pembeli;", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridView1.DataSource = data;

        }

        private void tombolHapus_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_pembeli WHERE KodePembeli = @kode", conn);
            if (string.IsNullOrEmpty(boksKodePembeli.Text))
            {
                MessageBox.Show("Kode harus diisi!");
            }
            else
            {
                conn.Open();
                cmd.Parameters.AddWithValue("kode", boksKodePembeli.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Data berhasil dihapus!");
                Bersihkan();
                KodePembeli();
            }
        }

        private void tombolPerbarui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(boksKodePembeli.Text))
            {
                MessageBox.Show("Kode harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksNamaPembeli.Text))
            {
                MessageBox.Show("Nama harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksNoHpPembeli.Text))
            {
                MessageBox.Show("No Hp harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksAlamatPembeli.Text))
            {
                MessageBox.Show("Alamat harus diisi!");
            }
            else
            {
                SqlConnection conn = koneksi.GetConn();
                SqlCommand cmd = new SqlCommand("UPDATE tbl_pembeli SET NamaPembeli = @nama, NoHpPembeli = @nohp, AlamatPembeli = @alamat WHERE KodePembeli = @kode", conn);
                if (string.IsNullOrEmpty(boksKodePembeli.Text))
                {
                    MessageBox.Show("Kode harus diisi!");
                }
                else
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("kode", boksKodePembeli.Text);
                    cmd.Parameters.AddWithValue("nama", boksNamaPembeli.Text);
                    cmd.Parameters.AddWithValue("nohp", boksNoHpPembeli.Text);
                    cmd.Parameters.AddWithValue("alamat", boksAlamatPembeli.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    MessageBox.Show("Data berhasil diperbarui!");
                    Bersihkan();
                    KodePembeli();
                }
            }
        }

        private void tombolTambah_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_pembeli VALUES(@kode, @nama, @nohp, @alamat)", conn);
            if (string.IsNullOrEmpty(boksKodePembeli.Text))
            {
                MessageBox.Show("Kode harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksNamaPembeli.Text))
            {
                MessageBox.Show("Nama harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksNoHpPembeli.Text))
            {
                MessageBox.Show("No Hp harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksAlamatPembeli.Text))
            {
                MessageBox.Show("Alamat harus diisi!");
            } else
            {
                conn.Open();
                cmd.Parameters.AddWithValue("kode", boksKodePembeli.Text);
                cmd.Parameters.AddWithValue("nama", boksNamaPembeli.Text);
                cmd.Parameters.AddWithValue("nohp", boksNoHpPembeli.Text);
                cmd.Parameters.AddWithValue("alamat", boksAlamatPembeli.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Data berhasil ditambahkan!");
                Bersihkan();
                KodePembeli();
            }
        }

        private void tombolBatal_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void Bersihkan()
        {
            boksKodePembeli.Clear();
            boksNamaPembeli.Clear();
            boksNoHpPembeli.Clear();
            boksAlamatPembeli.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            boksKodePembeli.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            boksNamaPembeli.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            boksNoHpPembeli.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            boksAlamatPembeli.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void FormPembeli_Load(object sender, EventArgs e)
        {
            LoadData();
            KodePembeli();
        }
    }
}
