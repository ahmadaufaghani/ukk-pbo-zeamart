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
    public partial class FormSupplier : Form
    {
        Koneksi koneksi = new Koneksi();
        public FormSupplier()
        {
            InitializeComponent();
        }

        

        private void KodeSupplier()
        {
            int hitung;
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT KodeSupplier FROM tbl_supplier WHERE KodeSupplier IN(SELECT MAX(KodeSupplier) FROM tbl_supplier) ORDER BY KodeSupplier DESC", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                hitung = Convert.ToInt32(dr["KodeSupplier"]) + 1;
                boksKodeSup.Text = hitung.ToString();
            }
            else
            {
                boksKodeSup.Text = "1";
            }
            conn.Close();
        }
        private void LoadData()
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_supplier;", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridView1.DataSource = data;
           
        }

        private void tombolTambah_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_supplier VALUES(@kode, @nama, @nohp, @alamat, @deskripsi)", conn);
            if (string.IsNullOrEmpty(boksKodeSup.Text)) {
                MessageBox.Show("Kode harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksNamaSup.Text)) {
                MessageBox.Show("Nama harus diisi!");
            }
            else if(string.IsNullOrEmpty(boksNoHpSup.Text)) {
                MessageBox.Show("No Hp harus diisi!");
            }
            else if(string.IsNullOrEmpty(boksAlamatSup.Text)) {
                MessageBox.Show("Alamat harus diisi!");
            }
            else if(string.IsNullOrEmpty(boksDeskripsiSup.Text)) {
                MessageBox.Show("Deskripsi harus diisi!");
            } else
            {
                conn.Open();
                cmd.Parameters.AddWithValue("kode", boksKodeSup.Text);
                cmd.Parameters.AddWithValue("nama", boksNamaSup.Text);
                cmd.Parameters.AddWithValue("nohp", boksNoHpSup.Text);
                cmd.Parameters.AddWithValue("alamat", boksAlamatSup.Text);
                cmd.Parameters.AddWithValue("deskripsi", boksDeskripsiSup.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                KodeSupplier();
                MessageBox.Show("Data berhasil ditambahkan!");
                Bersihkan();
            }
        }


        private void tombolPerbarui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(boksKodeSup.Text))
            {
                MessageBox.Show("Kode harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksNamaSup.Text))
            {
                MessageBox.Show("Nama harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksNoHpSup.Text))
            {
                MessageBox.Show("No Hp harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksAlamatSup.Text))
            {
                MessageBox.Show("Alamat harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksDeskripsiSup.Text))
            {
                MessageBox.Show("Deskripsi harus diisi!");
            }
            else
            {
                SqlConnection conn = koneksi.GetConn();
                SqlCommand cmd = new SqlCommand("UPDATE tbl_supplier SET NamaSupplier = @nama, NoHpSupplier = @nohp, AlamatSupplier = @alamat, DeskripsiSupplier = @deskripsi WHERE KodeSupplier = @kode", conn);
                if (string.IsNullOrEmpty(boksKodeSup.Text))
                {
                    MessageBox.Show("Kode harus diisi!");
                }
                else
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("kode", boksKodeSup.Text);
                    cmd.Parameters.AddWithValue("nama", boksNamaSup.Text);
                    cmd.Parameters.AddWithValue("nohp", boksNoHpSup.Text);
                    cmd.Parameters.AddWithValue("alamat", boksAlamatSup.Text);
                    cmd.Parameters.AddWithValue("deskripsi", boksDeskripsiSup.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    KodeSupplier();
                    MessageBox.Show("Data berhasil diperbarui!");
                    Bersihkan();
                }
            }
        }
        private void tombolBatal_Click(object sender, EventArgs e)
        {
            Bersihkan();
            KodeSupplier();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            LoadData();
            KodeSupplier();
        }

        private void tombolHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(boksKodeSup.Text))
            {
                MessageBox.Show("Kode harus diisi!");
            }
            else
            {
                SqlConnection conn = koneksi.GetConn();
                SqlCommand cmd = new SqlCommand("DELETE FROM tbl_supplier WHERE KodeSupplier = @kode", conn);
                if (string.IsNullOrEmpty(boksKodeSup.Text))
                {
                    MessageBox.Show("Kode harus diisi!");
                }
                else
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("kode", boksKodeSup.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    MessageBox.Show("Data berhasil dihapus!");
                    Bersihkan();
                    KodeSupplier();
                }
            }
        }
        private void Bersihkan()
        {
            boksKodeSup.Clear();
            boksNamaSup.Clear();
            boksNoHpSup.Clear();
            boksAlamatSup.Clear();
            boksDeskripsiSup.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            boksKodeSup.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            boksNamaSup.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            boksNoHpSup.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            boksAlamatSup.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            boksDeskripsiSup.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
