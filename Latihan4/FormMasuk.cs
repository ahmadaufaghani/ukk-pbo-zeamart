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
    public partial class FormMasuk : Form
    {
        Koneksi koneksi = new Koneksi();
        public FormMasuk()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormDaftar form_daftar = new FormDaftar();
            form_daftar.ShowDialog();
        }

        private void tombolMasuk_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            SqlCommand cmd = new SqlCommand("SELECT KodePengguna, NamaPengguna, KataSandiPengguna FROM tbl_pengguna WHERE NamaPengguna = @nama AND KataSandiPengguna = @ks", conn);
            SqlDataReader dr;
            Hash hc = new Hash();
            if (string.IsNullOrEmpty(boksKataPengguna.Text))
            {
                MessageBox.Show("Nama pengguna harus diisi!");
            }
            else if (string.IsNullOrEmpty(boksKataSandi.Text))
            {
                MessageBox.Show("Kata sandi harus diisi!");
            }
            else 
            {
                conn.Open();
                cmd.Parameters.AddWithValue("nama", boksKataPengguna.Text);
                cmd.Parameters.AddWithValue("ks", hc.HashPass(boksKataSandi.Text));
                dr = cmd.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    Form1.menu.namaPengguna.Text = (string)dr["NamaPengguna"];
                    Form1.menu.kodePengguna.Text = dr["KodePengguna"].ToString();
                    MessageBox.Show("Login berhasil!");
                    this.Hide();
                } else
                {
                    MessageBox.Show("Nama pengguna dan kata sandi tidak ditemukan!");
                }
                conn.Close();
            }
        }

        private void FormMasuk_Load(object sender, EventArgs e)
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
