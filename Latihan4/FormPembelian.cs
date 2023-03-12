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
    public partial class FormPembelian : Form
    {
        Koneksi koneksi = new Koneksi();
        public FormPembelian()
        {
            InitializeComponent();
        }

        private void NoFaktur()
        {
            long hitung;
            string urutan;
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("SELECT NoFaktur FROM tbl_pembelian WHERE NoFaktur IN (SELECT MAX(NoFaktur) FROM tbl_pembelian) ORDER BY NoFaktur DESC", conn);
            SqlDataReader da;
            conn.Open();
            da = cmd.ExecuteReader();
            da.Read();
            if(da.HasRows)
            {
                hitung = Convert.ToInt64(da["NoFaktur"]) + 1;
                string kodeurutan = "000" + hitung;
                urutan = DateTime.Now.ToString("ddMMyyyy") + kodeurutan.Substring(kodeurutan.Length - 4, 4);
                boksNoFaktur.Text = urutan;
            } else
            {
                boksNoFaktur.Text = DateTime.Now.ToString("ddMMyyyy") + "0001";
            }
            conn.Close();
        }

        private void HitungTotal()
        {
            try
            {
                int hitung;
                hitung = Convert.ToInt32(boksJumlahBarang.Text) * Convert.ToInt32(boksHargaBarang.Text);
                boksTotalBarang.Text = hitung.ToString();
            } catch
            {
                boksTotalBarang.Text = "0";
            }
        }

        private void TotalSemua()
        {
            try
            {
                int hitung = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    hitung += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }
                boksTotalSemua.Text = hitung.ToString();
            } catch
            {
                boksTotalSemua.Text= "0";
            }
        }

        private void Kembalian()
        {
            try
            {
                int hitung;
                hitung = Convert.ToInt32(boksBayar.Text) - Convert.ToInt32(boksTotalSemua.Text);
                boksKembali.Text = hitung.ToString();
            } catch
            {
                boksKembali.Text = "0";
            }
        }

       

        private void FormPembelian_Load(object sender, EventArgs e)
        {
            this.boksNoFaktur.Enabled = false;
            this.boksTglFaktur.Enabled = false;
            NoFaktur();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            boksTglFaktur.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Bersihkan()
        {
            boksKodeSupplier.Clear();
            boksNamaSupplier.Clear();
            boksAlamatSupplier.Clear();
            boksNoHpSupplier.Clear();
            boksDeskripsiSupplier.Clear();
            boksKodeBarang.Clear();
            boksNamaBarang.Clear();
            boksHargaBarang.Clear();
            boksJumlahBarang.Clear();
            boksTotalBarang.Clear();
            dataGridView1.Rows.Clear();
            boksTotalSemua.Clear();
            boksBayar.Clear();
            boksKembali.Clear();
        }

        private void boksKodeSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_supplier WHERE KodeSupplier = '" + boksKodeSupplier.Text + "'", conn);
                SqlDataReader da;
                da = cmd.ExecuteReader();
                da.Read();
                if(da.HasRows)
                {
                    boksNamaSupplier.Text = da["NamaSupplier"].ToString();
                    boksNoHpSupplier.Text = da["NoHpSupplier"].ToString();
                    boksAlamatSupplier.Text = da["AlamatSupplier"].ToString();
                    boksDeskripsiSupplier.Text = da["DeskripsiSupplier"].ToString();
                } else
                {
                    MessageBox.Show("Data tidak ditemukan!");
                }
                conn.Close();

            }
        }

        private void boksKodeBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_barang WHERE KodeBarang = '" + boksKodeBarang.Text + "'", conn);
                SqlDataReader da;
                da = cmd.ExecuteReader();
                da.Read();
                if (da.HasRows)
                {
                    boksNamaBarang.Text = da["NamaBarang"].ToString();
                    boksHargaBarang.Text = da["HargaBarang"].ToString();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan!");
                }
                conn.Close();
            }
        }

        private void boksJumlahBarang_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }


        private void boksJumlahBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_barang WHERE KodeBarang = '" + boksKodeBarang.Text + "'", conn);
                SqlDataReader da;
                da = cmd.ExecuteReader();
                da.Read();
                if (da.HasRows)
                {
                    if (Convert.ToInt32(boksJumlahBarang.Text) > Convert.ToInt32(da["StokBarang"]))
                    {
                        MessageBox.Show("Stok barang hanya " + da["StokBarang"]);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(boksNamaBarang.Text, boksHargaBarang.Text, boksJumlahBarang.Text, boksTotalBarang.Text);
                        TotalSemua();
                    }
                }
            }
        }

        private int KodePembelian()
        {
            int urutan;
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT KodePembelian FROM tbl_pembelian WHERE KodePembelian IN (SELECT MAX(KodePembelian) FROM tbl_pembelian) ORDER BY KodePembelian DESC", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                urutan = Convert.ToInt32(dr["KodePembelian"]) + 1; 
            } else
            {
                urutan =  1;
            }
            conn.Close(); 
            return urutan;
        }

        private void tombolSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_barang WHERE KodeBarang = '" + boksKodeBarang.Text + "'", conn);
            SqlDataReader da;
            da = cmd.ExecuteReader();
            da.Read();
            if (da.HasRows)
            {
                if (Convert.ToInt32(boksJumlahBarang.Text) >= Convert.ToInt32(da["StokBarang"]))
                {
                    MessageBox.Show("Stok barang hanya " + da["StokBarang"]);
                }
                else
                {
                    dataGridView1.Rows.Add(boksNamaBarang.Text, boksHargaBarang.Text, boksJumlahBarang.Text, boksTotalBarang.Text);
                    TotalSemua();
                }
            }
        }

        private void boksBayar_TextChanged(object sender, EventArgs e)
        {
            Kembalian();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            TotalSemua();  
        }

        private void tombolBatal_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void tombolTambah_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            for(int i = 0; i < dataGridView1.Rows.Count; i ++)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_pembelian VALUES(@kode, @no, @tgl, @kd_barang, @kd_supplier, @kd_pengguna, @jumlah, @harga);", conn);
                cmd.Parameters.AddWithValue("kode", KodePembelian());
                cmd.Parameters.AddWithValue("no", boksNoFaktur.Text);
                cmd.Parameters.AddWithValue("tgl", boksTglFaktur.Text);
                cmd.Parameters.AddWithValue("kd_barang", boksKodeBarang.Text);
                cmd.Parameters.AddWithValue("kd_supplier", boksKodeSupplier.Text);
                cmd.Parameters.AddWithValue("kd_pengguna", Form1.menu.kodePengguna.Text);
                cmd.Parameters.AddWithValue("jumlah", dataGridView1.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("harga", dataGridView1.Rows[i].Cells[1].Value);
                cmd.ExecuteNonQuery();
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            conn.Close();
            NoFaktur();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NOTA ZEAMART", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 0));
            e.Graphics.DrawString("Nama Supplier : "+boksNamaBarang.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 80));
            e.Graphics.DrawString("Kasir : "+Form1.menu.namaPengguna.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, 80));
            e.Graphics.DrawString("Aalamat Supplier : "+boksAlamatSupplier.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString("No. Hp Supplier : " + boksNoHpSupplier.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 120));

            e.Graphics.DrawString("No. Faktur : " + boksNoFaktur.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString(boksTglFaktur.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, 160));
            
            
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("NAMA", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(80, 260));
            e.Graphics.DrawString("HARGA", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(280, 260));
            e.Graphics.DrawString("JUMLAH", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, 260));
            e.Graphics.DrawString("TOTAL", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, 260));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 290));

            int ypos = 310;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(80, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(280, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, ypos));
                ypos += 20;
            }
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, ypos));
            e.Graphics.DrawString("Total", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, ypos+30));
            e.Graphics.DrawString(boksTotalSemua.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, ypos+30));
            e.Graphics.DrawString("Bayar", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, ypos+60));
            e.Graphics.DrawString(boksBayar.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, ypos+60));
            e.Graphics.DrawString("Kembali", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, ypos+90));
            e.Graphics.DrawString(boksKembali.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, ypos+90));


        }
    }
}
