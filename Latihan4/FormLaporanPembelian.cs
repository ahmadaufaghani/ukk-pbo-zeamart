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
    public partial class FormLaporanPembelian : Form
    {
        Koneksi koneksi = new Koneksi();
        public FormLaporanPembelian()
        {
            InitializeComponent();
        }

        private void TampilData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT tbl_pembelian.NoFaktur, tbl_barang.NamaBarang, tbl_supplier.NamaSupplier, tbl_pembelian.JumlahPembelian, tbl_pembelian.HargaPembelian FROM tbl_pembelian LEFT JOIN tbl_barang ON tbl_barang.KodeBarang = tbl_pembelian.KodeBarang LEFT JOIN tbl_supplier ON tbl_supplier.KodeSupplier = tbl_pembelian.KodeSupplier;", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);
            foreach(DataRow item in data.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["NoFaktur"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["NamaBarang"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["NamaSupplier"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["JumlahPembelian"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["HargaPembelian"].ToString();
            }
            conn.Close();

        }

        private void CariData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT tbl_pembelian.NoFaktur, tbl_barang.NamaBarang, tbl_supplier.NamaSupplier, tbl_pembelian.JumlahPembelian, tbl_pembelian.HargaPembelian FROM tbl_pembelian LEFT JOIN tbl_barang ON tbl_barang.KodeBarang = tbl_pembelian.KodeBarang LEFT JOIN tbl_supplier ON tbl_supplier.KodeSupplier = tbl_pembelian.KodeSupplier WHERE tbl_pembelian.NoFaktur = '"+pencarianFaktur.Text+"';", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);
            foreach (DataRow item in data.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["NoFaktur"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["NamaBarang"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["NamaSupplier"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["JumlahPembelian"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["HargaPembelian"].ToString();
            }
            conn.Close();
        }

        private void pencarianFaktur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT tbl_supplier.* FROM tbl_pembelian LEFT JOIN tbl_barang ON tbl_barang.KodeBarang = tbl_pembelian.KodeBarang LEFT JOIN tbl_supplier ON tbl_supplier.KodeSupplier = tbl_pembelian.KodeSupplier WHERE tbl_pembelian.NoFaktur = '" + pencarianFaktur.Text + "';", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    dataGridView1.Rows.Clear();
                    CariData();
                    boksKodeSupplier.Text = dr["KodeSupplier"].ToString();
                    boksNamaSupplier.Text = dr["NamaSupplier"].ToString();
                    boksAlamatSupplier.Text = dr["alamatSupplier"].ToString();
                    boksNoHpSupplier.Text = dr["noHpSupplier"].ToString();
                    boksDeskripsiSupplier.Text = dr["deskripsiSupplier"].ToString();
                } else
                {
                    MessageBox.Show("Data tidak ditemukan!");
                    dataGridView1.Rows.Clear();
                    TampilData();
                }
            }
        }

        private void FormLaporanPembelian_Load(object sender, EventArgs e)
        {
            TampilData();   
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("LAPORAN ZEAMART", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 0));
            e.Graphics.DrawString("Kasir : " + Form1.menu.namaPengguna.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 80));
            e.Graphics.DrawString("No. Faktur : " + pencarianFaktur.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 120));
            e.Graphics.DrawString("Jenis. Lap : Pembelian", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 160));
        


            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("NO. FAKTUR", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(80, 260));
            e.Graphics.DrawString("BARANG", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(280, 260));
            e.Graphics.DrawString("SUPPLIER", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, 260));
            e.Graphics.DrawString("JUMLAH", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, 260));
            e.Graphics.DrawString("HARGA", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(700, 260));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 290));

            int ypos = 310;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(80, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(280, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(620, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(700, ypos));
                ypos += 20;
            }
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, ypos));
            

        }

        private void tombolCetak_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            Bersihkan();
            TampilData();
        }

        private void Bersihkan()
        {
            pencarianFaktur.Clear();
            dataGridView1.Rows.Clear();
            boksKodeSupplier.Clear();
            boksAlamatSupplier.Clear();
            boksNoHpSupplier.Clear();
            boksAlamatSupplier.Clear();
            boksDeskripsiSupplier.Clear();
        }

        private void tombolBatal_Click(object sender, EventArgs e)
        {
            Bersihkan();
            TampilData();
        }
    }
}
