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
    public partial class FormLaporanPenjualan : Form
    {
        Koneksi koneksi = new Koneksi();
        public FormLaporanPenjualan()
        {
            InitializeComponent();
        }

        private void TampilData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT tbl_penjualan.NoNota, tbl_barang.NamaBarang, tbl_pembeli.NamaPembeli, tbl_penjualan.JumlahPenjualan, tbl_penjualan.HargaPenjualan, tbl_promo.KodePromo FROM tbl_penjualan LEFT JOIN tbl_barang ON tbl_barang.KodeBarang = tbl_penjualan.KodeBarang LEFT JOIN tbl_pembeli ON tbl_pembeli.KodePembeli = tbl_penjualan.KodePembeli LEFT JOIN tbl_promo ON tbl_promo.KodePromo = tbl_penjualan.KodePromo;", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);
            foreach (DataRow item in data.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["NoNota"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["NamaBarang"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["NamaPembeli"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["JumlahPenjualan"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["HargaPenjualan"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["KodePromo"].ToString();
            }
            conn.Close();

        }

        private void CariData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT tbl_penjualan.NoNota, tbl_barang.NamaBarang, tbl_pembeli.NamaPembeli, tbl_penjualan.JumlahPenjualan, tbl_penjualan.HargaPenjualan, tbl_promo.KodePromo FROM tbl_penjualan LEFT JOIN tbl_barang ON tbl_barang.KodeBarang = tbl_penjualan.KodeBarang LEFT JOIN tbl_pembeli ON tbl_pembeli.KodePembeli = tbl_penjualan.KodePembeli LEFT JOIN tbl_promo ON tbl_promo.KodePromo = tbl_penjualan.KodePromo WHERE tbl_penjualan.NoNota= '" + pencarianNota.Text + "';", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);
            foreach (DataRow item in data.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["NoNota"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["NamaBarang"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["NamaPembeli"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["JumlahPenjualan"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["HargaPenjualan"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["KodePromo"].ToString();
            }
            conn.Close();
        }
        private void FormLaporanPenjualan_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void pencarianNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT tbl_pembeli.* FROM tbl_penjualan LEFT JOIN tbl_barang ON tbl_barang.KodeBarang = tbl_penjualan.KodeBarang LEFT JOIN tbl_pembeli ON tbl_pembeli.KodePembeli = tbl_penjualan.KodePembeli LEFT JOIN tbl_promo ON tbl_promo.KodePromo = tbl_penjualan.KodePromo WHERE tbl_penjualan.NoNota= '" + pencarianNota.Text + "';", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    dataGridView1.Rows.Clear();
                    CariData();
                    boksKodePembeli.Text = dr["KodePembeli"].ToString();
                    boksNamaPembeli.Text = dr["NamaPembeli"].ToString();
                    boksAlamatPembeli.Text = dr["alamatPembeli"].ToString();
                    boksNoHpPembeli.Text = dr["noHpPembeli"].ToString();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan!");
                    dataGridView1.Rows.Clear();
                    TampilData();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("LAPORAN ZEAMART", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 0));
            e.Graphics.DrawString("Kasir : " + Form1.menu.namaPengguna.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 80));
            e.Graphics.DrawString("No. Nota : " + pencarianNota.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 120));
            e.Graphics.DrawString("Jenis. Lap : Penjualan", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 160));



            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("NO. NOTA", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(30, 260));
            e.Graphics.DrawString("BARANG", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(230, 260));
            e.Graphics.DrawString("PEMBELI", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(400, 260));
            e.Graphics.DrawString("JMLH.", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(530, 260));
            e.Graphics.DrawString("HARGA", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, 260));
            e.Graphics.DrawString("KODE", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(700, 260));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 290));

            int ypos = 310;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(30, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(230, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(430, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(530, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(700, ypos));
                ypos += 20;
            }
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, ypos));

        }

        private void tombolTambah_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            Bersihkan();
            TampilData();
        }

        private void Bersihkan()
        {
            pencarianNota.Clear();
            dataGridView1.Rows.Clear();
            boksKodePembeli.Clear();
            boksAlamatPembeli.Clear();
            boksNoHpPembeli.Clear();
        }

        private void tombolBatal_Click(object sender, EventArgs e)
        {
            Bersihkan();
            TampilData();
        }
    }
}
