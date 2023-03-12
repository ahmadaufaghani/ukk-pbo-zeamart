using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan4
{
    public partial class Form1 : Form
    {
        public static Form1 menu;
        private Form formAktif;
        private Button tombolSekarang;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1067, 841);
            FormBarang form_barang = new FormBarang();
            BukaFormTurunan(form_barang, tombolBarang);
            this.WindowState = FormWindowState.Maximized;
            menu = this;
            FormMasuk form_masuk = new FormMasuk();
            form_masuk.ShowDialog();
        }

        private void AktifkanTombol(object pengirimTombol)
        {
            if (pengirimTombol != null)
            {
                if (tombolSekarang != (Button)pengirimTombol)
                {
                    MatikanTombol();
                    Color warna = Color.FromArgb(0, 150, 136);
                    tombolSekarang = (Button)pengirimTombol;
                    tombolSekarang.BackColor = warna;
                    tombolSekarang.ForeColor = Color.White;
                }
            }
        }

        private void MatikanTombol()
        {
            foreach (Control tombolSebelumnya in panel1.Controls)
            {
                if (tombolSebelumnya.GetType() == typeof(Button))
                {
                    tombolSebelumnya.BackColor = Color.FromArgb(50, 50, 76);
                    tombolSebelumnya.ForeColor = Color.White;
                }
            }
        }

        private void BukaFormTurunan(Form formTurunan, object pengirimTombol)
        {
            if (formAktif != null)
            {
                formAktif.Close();
            }
            AktifkanTombol(pengirimTombol);
            formAktif = formTurunan;
            formTurunan.TopLevel = false;
            formTurunan.FormBorderStyle = FormBorderStyle.None;
            formTurunan.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(formTurunan);
            this.panel4.Tag = formTurunan;
            formTurunan.BringToFront();
            formTurunan.Show();
            labelForm.Text = formTurunan.Text;
        }

        private void tombolBarang_Click(object sender, EventArgs e)
        {
            FormBarang form_Barang = new FormBarang();
            BukaFormTurunan(form_Barang, tombolBarang);
        }

        private void tombolSupplier_Click(object sender, EventArgs e)
        {
            FormSupplier f_sup = new FormSupplier();
            BukaFormTurunan(f_sup, tombolSupplier);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPembeli f_pem = new FormPembeli();
            BukaFormTurunan(f_pem, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPromo f_promo = new FormPromo();
            BukaFormTurunan(f_promo, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPembelian f_pembelian = new FormPembelian();
            BukaFormTurunan(f_pembelian, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPenjualan f_penjualan = new FormPenjualan();
            BukaFormTurunan(f_penjualan, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormLaporanPenjualan f_lap_penjualan = new FormLaporanPenjualan();
            BukaFormTurunan(f_lap_penjualan, button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormLaporanPembelian f_lap_pembelian = new FormLaporanPembelian();
            BukaFormTurunan(f_lap_pembelian, button6);
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            FormMasuk form_masuk = new FormMasuk();
            form_masuk.ShowDialog();
        }
    }
}