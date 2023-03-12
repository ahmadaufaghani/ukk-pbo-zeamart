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
    public partial class FormDaftar : Form
    {
        Koneksi koneksi = new Koneksi();
        public FormDaftar()
        {
            InitializeComponent();
        }

        private int KodePengguna()
        {
            int hitung;
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT KodePengguna FROM tbl_pengguna WHERE KodePengguna IN (SELECT MAX(KodePengguna) FROM tbl_pengguna) ORDER BY KodePengguna DESC", conn); ;
            SqlDataReader da;
            da = cmd.ExecuteReader();
            da.Read();
            if(da.HasRows)
            {
                hitung = Convert.ToInt32(da["KodePengguna"]) + 1;
            } else
            {
                hitung =  1;
            }
            conn.Close();
            return hitung;
        }

        private void tombolDaftar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_pengguna VALUES(@kode, @nama, @ks)",conn);
            Hash hc = new Hash();
            if(string.IsNullOrEmpty(boksKataPengguna.Text))
            {
                MessageBox.Show("Nama pengguna harus diisi!");
            } else if (string.IsNullOrEmpty(boksKataSandi.Text))
            {
                MessageBox.Show("Kata sandi harus diisi!");
            } else { 
                conn.Open();
                cmd.Parameters.AddWithValue("kode", KodePengguna());
                cmd.Parameters.AddWithValue("nama", boksKataPengguna.Text);
                cmd.Parameters.AddWithValue("ks", hc.HashPass(boksKataSandi.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Daftar berhasil silahkan login!");
                this.Hide();
                FormMasuk form_masuk = new FormMasuk();
                form_masuk.ShowDialog();
            }
        }

        private void FormDaftar_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
