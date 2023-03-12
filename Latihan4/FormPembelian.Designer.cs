namespace Latihan4
{
    partial class FormPembelian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembelian));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boksDeskripsiSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boksAlamatSupplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boksNoHpSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boksNamaSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boksKodeSupplier = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boksTotalBarang = new System.Windows.Forms.TextBox();
            this.tombolSimpan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boksNamaBarang = new System.Windows.Forms.TextBox();
            this.boksJumlahBarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boksKodeBarang = new System.Windows.Forms.TextBox();
            this.boksHargaBarang = new System.Windows.Forms.TextBox();
            this.tombolBatal = new System.Windows.Forms.Button();
            this.tombolTambah = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.boksTglFaktur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.boksNoFaktur = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.boksKembali = new System.Windows.Forms.TextBox();
            this.boksBayar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aksi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.boksTotalSemua = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.boksDeskripsiSupplier);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boksAlamatSupplier);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boksNoHpSupplier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boksNamaSupplier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boksKodeSupplier);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(16, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Deskripsi Supplier";
            // 
            // boksDeskripsiSupplier
            // 
            this.boksDeskripsiSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksDeskripsiSupplier.Enabled = false;
            this.boksDeskripsiSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksDeskripsiSupplier.Location = new System.Drawing.Point(20, 178);
            this.boksDeskripsiSupplier.Name = "boksDeskripsiSupplier";
            this.boksDeskripsiSupplier.Size = new System.Drawing.Size(349, 27);
            this.boksDeskripsiSupplier.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(174, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alamat Supplier";
            // 
            // boksAlamatSupplier
            // 
            this.boksAlamatSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksAlamatSupplier.Enabled = false;
            this.boksAlamatSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksAlamatSupplier.Location = new System.Drawing.Point(178, 116);
            this.boksAlamatSupplier.Name = "boksAlamatSupplier";
            this.boksAlamatSupplier.Size = new System.Drawing.Size(191, 27);
            this.boksAlamatSupplier.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "No. Hp Supplier";
            // 
            // boksNoHpSupplier
            // 
            this.boksNoHpSupplier.Enabled = false;
            this.boksNoHpSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNoHpSupplier.Location = new System.Drawing.Point(20, 116);
            this.boksNoHpSupplier.Name = "boksNoHpSupplier";
            this.boksNoHpSupplier.Size = new System.Drawing.Size(152, 27);
            this.boksNoHpSupplier.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(174, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Supplier";
            // 
            // boksNamaSupplier
            // 
            this.boksNamaSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksNamaSupplier.Enabled = false;
            this.boksNamaSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNamaSupplier.Location = new System.Drawing.Point(178, 55);
            this.boksNamaSupplier.Name = "boksNamaSupplier";
            this.boksNamaSupplier.Size = new System.Drawing.Size(191, 27);
            this.boksNamaSupplier.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode Supplier";
            // 
            // boksKodeSupplier
            // 
            this.boksKodeSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksKodeSupplier.Location = new System.Drawing.Point(20, 55);
            this.boksKodeSupplier.Name = "boksKodeSupplier";
            this.boksKodeSupplier.Size = new System.Drawing.Size(152, 27);
            this.boksKodeSupplier.TabIndex = 2;
            this.boksKodeSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boksKodeSupplier_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.boksTotalBarang);
            this.groupBox2.Controls.Add(this.tombolSimpan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.boksNamaBarang);
            this.groupBox2.Controls.Add(this.boksJumlahBarang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.boksKodeBarang);
            this.groupBox2.Controls.Add(this.boksHargaBarang);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(414, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(14, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total Barang";
            // 
            // boksTotalBarang
            // 
            this.boksTotalBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksTotalBarang.Enabled = false;
            this.boksTotalBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksTotalBarang.Location = new System.Drawing.Point(18, 178);
            this.boksTotalBarang.Name = "boksTotalBarang";
            this.boksTotalBarang.Size = new System.Drawing.Size(300, 27);
            this.boksTotalBarang.TabIndex = 20;
            // 
            // tombolSimpan
            // 
            this.tombolSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolSimpan.FlatAppearance.BorderSize = 0;
            this.tombolSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolSimpan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolSimpan.ForeColor = System.Drawing.Color.White;
            this.tombolSimpan.Location = new System.Drawing.Point(324, 178);
            this.tombolSimpan.Name = "tombolSimpan";
            this.tombolSimpan.Size = new System.Drawing.Size(87, 27);
            this.tombolSimpan.TabIndex = 19;
            this.tombolSimpan.Text = "Simpan";
            this.tombolSimpan.UseVisualStyleBackColor = false;
            this.tombolSimpan.Click += new System.EventHandler(this.tombolSimpan_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(168, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Jumlah Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(168, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nama Barang";
            // 
            // boksNamaBarang
            // 
            this.boksNamaBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksNamaBarang.Enabled = false;
            this.boksNamaBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNamaBarang.Location = new System.Drawing.Point(172, 55);
            this.boksNamaBarang.Name = "boksNamaBarang";
            this.boksNamaBarang.Size = new System.Drawing.Size(243, 27);
            this.boksNamaBarang.TabIndex = 14;
            // 
            // boksJumlahBarang
            // 
            this.boksJumlahBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksJumlahBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksJumlahBarang.Location = new System.Drawing.Point(172, 116);
            this.boksJumlahBarang.Name = "boksJumlahBarang";
            this.boksJumlahBarang.Size = new System.Drawing.Size(239, 27);
            this.boksJumlahBarang.TabIndex = 18;
            this.boksJumlahBarang.TextChanged += new System.EventHandler(this.boksJumlahBarang_TextChanged);
            this.boksJumlahBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boksJumlahBarang_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(14, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kode Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(14, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Harga Barang";
            // 
            // boksKodeBarang
            // 
            this.boksKodeBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksKodeBarang.Location = new System.Drawing.Point(18, 55);
            this.boksKodeBarang.Name = "boksKodeBarang";
            this.boksKodeBarang.Size = new System.Drawing.Size(148, 27);
            this.boksKodeBarang.TabIndex = 12;
            this.boksKodeBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boksKodeBarang_KeyPress);
            // 
            // boksHargaBarang
            // 
            this.boksHargaBarang.Enabled = false;
            this.boksHargaBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksHargaBarang.Location = new System.Drawing.Point(18, 116);
            this.boksHargaBarang.Name = "boksHargaBarang";
            this.boksHargaBarang.Size = new System.Drawing.Size(148, 27);
            this.boksHargaBarang.TabIndex = 16;
            // 
            // tombolBatal
            // 
            this.tombolBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolBatal.FlatAppearance.BorderSize = 0;
            this.tombolBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolBatal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBatal.ForeColor = System.Drawing.Color.White;
            this.tombolBatal.Location = new System.Drawing.Point(734, 551);
            this.tombolBatal.Name = "tombolBatal";
            this.tombolBatal.Size = new System.Drawing.Size(111, 39);
            this.tombolBatal.TabIndex = 21;
            this.tombolBatal.Text = "Batal";
            this.tombolBatal.UseVisualStyleBackColor = false;
            this.tombolBatal.Click += new System.EventHandler(this.tombolBatal_Click);
            // 
            // tombolTambah
            // 
            this.tombolTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolTambah.FlatAppearance.BorderSize = 0;
            this.tombolTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTambah.ForeColor = System.Drawing.Color.White;
            this.tombolTambah.Location = new System.Drawing.Point(617, 551);
            this.tombolTambah.Name = "tombolTambah";
            this.tombolTambah.Size = new System.Drawing.Size(111, 39);
            this.tombolTambah.TabIndex = 18;
            this.tombolTambah.Text = "Tambah";
            this.tombolTambah.UseVisualStyleBackColor = false;
            this.tombolTambah.Click += new System.EventHandler(this.tombolTambah_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.boksTglFaktur);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.boksNoFaktur);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 448);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 94);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaksi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.Location = new System.Drawing.Point(174, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tanggal Faktur";
            // 
            // boksTglFaktur
            // 
            this.boksTglFaktur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksTglFaktur.Location = new System.Drawing.Point(178, 50);
            this.boksTglFaktur.Name = "boksTglFaktur";
            this.boksTglFaktur.Size = new System.Drawing.Size(191, 27);
            this.boksTglFaktur.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(11, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "No. Faktur";
            // 
            // boksNoFaktur
            // 
            this.boksNoFaktur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNoFaktur.Location = new System.Drawing.Point(15, 50);
            this.boksNoFaktur.Name = "boksNoFaktur";
            this.boksNoFaktur.Size = new System.Drawing.Size(152, 27);
            this.boksNoFaktur.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.boksKembali);
            this.groupBox4.Controls.Add(this.boksBayar);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(414, 451);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 94);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pembayaran";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(172, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Kembali";
            // 
            // boksKembali
            // 
            this.boksKembali.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksKembali.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksKembali.Location = new System.Drawing.Point(176, 48);
            this.boksKembali.Name = "boksKembali";
            this.boksKembali.Size = new System.Drawing.Size(235, 27);
            this.boksKembali.TabIndex = 18;
            // 
            // boksBayar
            // 
            this.boksBayar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksBayar.Location = new System.Drawing.Point(18, 48);
            this.boksBayar.Name = "boksBayar";
            this.boksBayar.Size = new System.Drawing.Size(152, 27);
            this.boksBayar.TabIndex = 16;
            this.boksBayar.TextChanged += new System.EventHandler(this.boksBayar_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label14.Location = new System.Drawing.Point(14, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Bayar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamaBarang,
            this.HargaBarang,
            this.JumlahBarang,
            this.TotalHarga,
            this.Aksi});
            this.dataGridView1.Location = new System.Drawing.Point(13, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(832, 156);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NamaBarang
            // 
            this.NamaBarang.HeaderText = "NamaBarang";
            this.NamaBarang.MinimumWidth = 6;
            this.NamaBarang.Name = "NamaBarang";
            // 
            // HargaBarang
            // 
            this.HargaBarang.HeaderText = "HargaBarang";
            this.HargaBarang.MinimumWidth = 6;
            this.HargaBarang.Name = "HargaBarang";
            // 
            // JumlahBarang
            // 
            this.JumlahBarang.HeaderText = "JumlahBarang";
            this.JumlahBarang.MinimumWidth = 6;
            this.JumlahBarang.Name = "JumlahBarang";
            // 
            // TotalHarga
            // 
            this.TotalHarga.HeaderText = "TotalHarga";
            this.TotalHarga.MinimumWidth = 6;
            this.TotalHarga.Name = "TotalHarga";
            // 
            // Aksi
            // 
            this.Aksi.HeaderText = "Aksi";
            this.Aksi.MinimumWidth = 6;
            this.Aksi.Name = "Aksi";
            this.Aksi.Text = "Hapus";
            this.Aksi.UseColumnTextForButtonValue = true;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label15.Location = new System.Drawing.Point(562, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Total";
            // 
            // boksTotalSemua
            // 
            this.boksTotalSemua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boksTotalSemua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksTotalSemua.Location = new System.Drawing.Point(610, 418);
            this.boksTotalSemua.Name = "boksTotalSemua";
            this.boksTotalSemua.Size = new System.Drawing.Size(235, 27);
            this.boksTotalSemua.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 602);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boksTotalSemua);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tombolBatal);
            this.Controls.Add(this.tombolTambah);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPembelian";
            this.Text = "Form Pembelian";
            this.Load += new System.EventHandler(this.FormPembelian_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boksDeskripsiSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boksAlamatSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boksNoHpSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boksNamaSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boksKodeSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boksNamaBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boksKodeBarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boksHargaBarang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boksJumlahBarang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boksTotalBarang;
        private System.Windows.Forms.Button tombolSimpan;
        private System.Windows.Forms.Button tombolBatal;
        private System.Windows.Forms.Button tombolTambah;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boksNoFaktur;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox boksTglFaktur;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox boksKembali;
        private System.Windows.Forms.TextBox boksBayar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox boksTotalSemua;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHarga;
        private System.Windows.Forms.DataGridViewButtonColumn Aksi;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}