using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan4
{
    public partial class FormPenjualan : Form
    {
        Koneksi koneksi = new Koneksi();
        public FormPenjualan()
        {
            InitializeComponent();
        }
        private void NoNota()
        {
            long hitung;
            string urutan;
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("SELECT NoNota FROM tbl_penjualan WHERE NoNota IN (SELECT MAX(NoNota) FROM tbl_penjualan) ORDER BY NoNota DESC", conn);
            SqlDataReader da;
            conn.Open();
            da = cmd.ExecuteReader();
            da.Read();
            if (da.HasRows)
            {
                hitung = Convert.ToInt64(da["NoNota"]) + 1;
                string kodeurutan = "000" + hitung;
                urutan = DateTime.Now.ToString("ddMMyyyy") + kodeurutan.Substring(kodeurutan.Length - 4, 4);
                boksNoNota.Text = urutan;
            }
            else
            {
                boksNoNota.Text = DateTime.Now.ToString("ddMMyyyy") + "0001";
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
            }
            catch
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
                boksTotal.Text = hitung.ToString();
            }
            catch
            {
                boksTotalSemua.Text = "0";
            }
        }

        private void GrandTotal()
        {
            try
            {
                int hitung;
                hitung = Convert.ToInt32(boksTotal.Text) - Convert.ToInt32(boksPromo.Text);
                boksTotalSemua.Text = hitung.ToString();    
            } catch
            {
                boksTotalSemua.Text = "0";
            }
        }

        private void boksNoNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_pembeli WHERE KodePembeli = '" + boksKodePembeli.Text + "'", conn);
                SqlDataReader da;
                da = cmd.ExecuteReader();
                da.Read();
                if (da.HasRows)
                {
                    boksNamaPembeli.Text = da["NamaPembeli"].ToString();
                    boksNoHpPembeli.Text = da["NoHpPembeli"].ToString();
                    boksAlamatPembeli.Text = da["AlamatPembeli"].ToString();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan!");
                }
                conn.Close();

            }
        }

        private void boksKodeBarang_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FormPenjualan_Load(object sender, EventArgs e)
        {
            NoNota();
            TampilPromo();
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

        private void tombolPerbarui_Click(object sender, EventArgs e)
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


        private void TampilPromo()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_promo;", conn);
            SqlDataReader da;
            da = cmd.ExecuteReader();
            while (da.Read())
            {
                CBKodePromo.Items.Add(da["KodePromo"]);
            }
            conn.Close();
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

        private void boksBayar_TextChanged(object sender, EventArgs e)
        {
            Kembalian();
        }

        private void CBKodePromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlDataReader da;
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_promo WHERE KodePromo = @kode;", conn);
            cmd.Parameters.AddWithValue("kode", CBKodePromo.GetItemText(CBKodePromo.SelectedItem));
            da = cmd.ExecuteReader();
            
            while (da.Read())
            {
                if (Convert.ToInt32(boksTotal.Text) <= Convert.ToInt32(da["MinPembelian"]))
                {
                    MessageBox.Show("Min. Pembelian " + da["MinPembelian"]);
                }
                else
                {
                    boksNominal.Text = da["Nominal"].ToString();
                    boksPromo.Text = da["Nominal"].ToString();
                    GrandTotal();
                }
            }
            conn.Close();
            
        }

        private void boksKodePembeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_pembeli WHERE KodePembeli = '" + boksKodePembeli.Text + "'", conn);
                SqlDataReader da;
                da = cmd.ExecuteReader();
                da.Read();
                if (da.HasRows)
                {
                    boksNamaPembeli.Text = da["NamaPembeli"].ToString();
                    boksNoHpPembeli.Text = da["NoHpPembeli"].ToString();
                    boksAlamatPembeli.Text = da["AlamatPembeli"].ToString();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan!");
                }
                conn.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            TotalSemua();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            boksTanggalNota.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private int KodePenjualan()
        {
            int urutan;
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT KodePenjualan FROM tbl_penjualan WHERE KodePenjualan IN (SELECT MAX(KodePenjualan) FROM tbl_penjualan) ORDER BY KodePenjualan DESC", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                urutan = Convert.ToInt32(dr["KodePenjualan"]) + 1;
            }
            else
            {
                urutan = 1;
            }
            conn.Close();
            return urutan;
        }

        private void tombolTambah_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_penjualan VALUES(@kode, @no, @tgl, @kd_barang, @kd_supplier, @kd_pengguna, @kd_promo, @jumlah, @harga);", conn);
                cmd.Parameters.AddWithValue("kode", KodePenjualan());
                cmd.Parameters.AddWithValue("no", boksNoNota.Text);
                cmd.Parameters.AddWithValue("tgl", boksTanggalNota.Text);
                cmd.Parameters.AddWithValue("kd_barang", boksKodeBarang.Text);
                cmd.Parameters.AddWithValue("kd_supplier", boksKodePembeli.Text);
                cmd.Parameters.AddWithValue("kd_pengguna", Form1.menu.kodePengguna.Text);
                cmd.Parameters.AddWithValue("kd_promo", CBKodePromo.GetItemText(CBKodePromo.SelectedItem));
                cmd.Parameters.AddWithValue("jumlah", dataGridView1.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("harga", dataGridView1.Rows[i].Cells[1].Value);
                cmd.ExecuteNonQuery();
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            conn.Close();
            NoNota();
        }

        private void Bersihkan()
        {
            boksKodePembeli.Clear();
            boksNamaPembeli.Clear();
            boksNoHpPembeli.Clear();
            boksAlamatPembeli.Clear();
            boksKodeBarang.Clear();
            boksNamaBarang.Clear();
            boksHargaBarang.Clear();
            boksJumlahBarang.Clear();
            dataGridView1.Rows.Clear();
            boksTotalBarang.Clear();
            boksTotal.Clear();
            boksPromo.Clear();
            boksTotalSemua.Clear();
            boksNominal.Clear();
            boksBayar.Clear();
            boksKembali.Clear();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NOTA ZEAMART", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 0));
            e.Graphics.DrawString("Nama Pembeli : " + boksNamaBarang.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 80));
            e.Graphics.DrawString("Kasir : " + Form1.menu.namaPengguna.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, 80));
            e.Graphics.DrawString("Alamat Pembeli : " + boksAlamatPembeli.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString("No. Hp Pembeli : " + boksNoHpPembeli.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 120));

            e.Graphics.DrawString("No. Faktur : " + boksNoNota.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString(boksTanggalNota.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, 160));


            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("NAMA", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(80, 260));
            e.Graphics.DrawString("HARGA", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(280, 260));
            e.Graphics.DrawString("JUMLAH", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, 260));
            e.Graphics.DrawString("TOTAL", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, 260));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 290));

            int ypos = 310;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(80, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(280, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, ypos));
                ypos += 20;
            }
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, ypos));
            e.Graphics.DrawString("Promo", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, ypos + 30));
            e.Graphics.DrawString(boksPromo.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, ypos + 30)); 
            e.Graphics.DrawString("Total", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, ypos + 60));
            e.Graphics.DrawString(boksTotalSemua.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, ypos + 60));
            e.Graphics.DrawString("Bayar", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, ypos + 90));
            e.Graphics.DrawString(boksBayar.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, ypos + 90));
            e.Graphics.DrawString("Kembali", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(480, ypos + 120));
            e.Graphics.DrawString(boksKembali.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, ypos + 120));

        }

        private void tombolBatal_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }
    }
}
