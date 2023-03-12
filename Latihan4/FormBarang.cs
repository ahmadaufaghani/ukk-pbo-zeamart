using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan4
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        public FormBarang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void KodeBarang()
        {
            int hitung;
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT KodeBarang FROM tbl_barang WHERE KodeBarang IN(SELECT MAX(KodeBarang) FROM tbl_barang) ORDER BY KodeBarang DESC", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                hitung = Convert.ToInt32(dr["KodeBarang"]) + 1;
                boksKodeBarang.Text = hitung.ToString();
            } else
            {
                boksKodeBarang.Text = "1";
            }
            conn.Close();
        }

       private void LoadData()
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_barang;", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.RowTemplate.Height = 140;
            ((DataGridViewImageColumn)dataGridView1.Columns["GambarBarang"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void tombolTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(boksKodeBarang.Text)) {
                
                MessageBox.Show("Kode harus diisi!");

            }
            else if (string.IsNullOrEmpty(boksNamaBarang.Text)) {
                MessageBox.Show("Nama harus diisi!");
            }
            else if(string.IsNullOrEmpty(boksHargaBarang.Text)) {
                MessageBox.Show("Harga harus diisi!");
            }
            else if(string.IsNullOrEmpty(boksStokBarang.Text)) {
                MessageBox.Show("Stok harus diisi!");
            }
            else if(pictureBox1.Image == null) {
                MessageBox.Show("Gambar harus diisi!");
            }
            else
            {
                SqlConnection conn = koneksi.GetConn();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_barang VALUES(@kode, @nama, @harga, @stok, @gambar);", conn);
                MemoryStream memster = new MemoryStream();
                pictureBox1.Image.Save(memster, pictureBox1.Image.RawFormat);
                conn.Open();
                cmd.Parameters.Add("kode", boksKodeBarang.Text);
                cmd.Parameters.Add("nama", boksNamaBarang.Text);
                cmd.Parameters.Add("harga", boksHargaBarang.Text);
                cmd.Parameters.Add("stok", boksStokBarang.Text);
                cmd.Parameters.Add("gambar", memster.ToArray());
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                Bersihkan();
                KodeBarang();
                MessageBox.Show("Data berhasil ditambahkan!");
            }

        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            LoadData();
            KodeBarang();
        }

        private void tombolPerbarui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(boksKodeBarang.Text))
            {

                MessageBox.Show("Kode harus diisi!");

            }
            else
            {
                if (string.IsNullOrEmpty(boksKodeBarang.Text))
                {

                    MessageBox.Show("Kode harus diisi!");

                }
                else if (string.IsNullOrEmpty(boksNamaBarang.Text))
                {
                    MessageBox.Show("Nama harus diisi!");
                }
                else if (string.IsNullOrEmpty(boksHargaBarang.Text))
                {
                    MessageBox.Show("Harga harus diisi!");
                }
                else if (string.IsNullOrEmpty(boksStokBarang.Text))
                {
                    MessageBox.Show("Stok harus diisi!");
                }
                else if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Gambar harus diisi!");
                }
                else
                {
                    SqlConnection conn = koneksi.GetConn();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_barang SET NamaBarang = @nama, HargaBarang = @harga, StokBarang = @stok, GambarBarang = @gambar WHERE KodeBarang = @kode;", conn);
                    MemoryStream memster = new MemoryStream();
                    pictureBox1.Image.Save(memster, pictureBox1.Image.RawFormat);
                    conn.Open();
                    cmd.Parameters.Add("kode", boksKodeBarang.Text);
                    cmd.Parameters.Add("nama", boksNamaBarang.Text);
                    cmd.Parameters.Add("harga", boksHargaBarang.Text);
                    cmd.Parameters.Add("stok", boksStokBarang.Text);
                    cmd.Parameters.Add("gambar", memster.ToArray());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    Bersihkan();
                    KodeBarang();
                    MessageBox.Show("Data berhasil diperbarui!");
                }
            }
        }

        private void tombolHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(boksKodeBarang.Text))
            {

                MessageBox.Show("Kode harus diisi!");

            }
            else
            {
                if (string.IsNullOrEmpty(boksKodeBarang.Text))
                {
                    MessageBox.Show("Kode harus diisi!");
                } else if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Gambar harus diisi!");
                }
                else
                {
                    SqlConnection conn = koneksi.GetConn();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_barang WHERE KodeBarang = @kode;", conn);
                    MemoryStream memster = new MemoryStream();
                    pictureBox1.Image.Save(memster, pictureBox1.Image.RawFormat);
                    conn.Open();
                    cmd.Parameters.Add("kode", boksKodeBarang.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    MessageBox.Show("Data berhasil dihapus!");
                    Bersihkan();
                    KodeBarang();
                }
            }
        }


        private void Bersihkan()
        {
            boksKodeBarang.Clear();
            boksNamaBarang.Clear();
            boksHargaBarang.Clear();
            boksStokBarang.Clear();
            pictureBox1.Image = null;
        }

        private void cariGambar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.Jpg, *.png, *.Gif)|*.Jpg; *.png; *.Gif";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void tombolBatal_Click(object sender, EventArgs e)
        {
            Bersihkan();
            KodeBarang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            boksKodeBarang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            boksNamaBarang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            boksHargaBarang.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            boksStokBarang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MemoryStream memstr = new MemoryStream(((byte[])dataGridView1.CurrentRow.Cells[4].Value));
            pictureBox1.Image = Image.FromStream(memstr);
        }
    }
}
