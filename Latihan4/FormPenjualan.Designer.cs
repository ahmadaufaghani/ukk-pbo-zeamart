namespace Latihan4
{
    partial class FormPenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenjualan));
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boksTotalSemua = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.boksKembali = new System.Windows.Forms.TextBox();
            this.boksBayar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tombolBatal = new System.Windows.Forms.Button();
            this.tombolTambah = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tglNota = new System.Windows.Forms.Label();
            this.boksTanggalNota = new System.Windows.Forms.TextBox();
            this.noNota = new System.Windows.Forms.Label();
            this.boksNoNota = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boksTotalBarang = new System.Windows.Forms.TextBox();
            this.tombolPerbarui = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boksNamaBarang = new System.Windows.Forms.TextBox();
            this.boksJumlahBarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boksKodeBarang = new System.Windows.Forms.TextBox();
            this.boksHargaBarang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boksAlamatPembeli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boksNoHpPembeli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boksNamaPembeli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boksKodePembeli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boksTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.boksPromo = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CBKodePromo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.boksNominal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aksi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label15.Location = new System.Drawing.Point(634, 519);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Total Semua";
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
            this.Total,
            this.Aksi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 156);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // boksTotalSemua
            // 
            this.boksTotalSemua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boksTotalSemua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksTotalSemua.Location = new System.Drawing.Point(731, 516);
            this.boksTotalSemua.Name = "boksTotalSemua";
            this.boksTotalSemua.Size = new System.Drawing.Size(235, 27);
            this.boksTotalSemua.TabIndex = 28;
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
            this.groupBox4.Location = new System.Drawing.Point(13, 549);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(953, 94);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pembayaran";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(414, 25);
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
            this.boksKembali.Location = new System.Drawing.Point(418, 48);
            this.boksKembali.Name = "boksKembali";
            this.boksKembali.Size = new System.Drawing.Size(514, 27);
            this.boksKembali.TabIndex = 18;
            // 
            // boksBayar
            // 
            this.boksBayar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksBayar.Location = new System.Drawing.Point(18, 48);
            this.boksBayar.Name = "boksBayar";
            this.boksBayar.Size = new System.Drawing.Size(368, 27);
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
            // tombolBatal
            // 
            this.tombolBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolBatal.FlatAppearance.BorderSize = 0;
            this.tombolBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolBatal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBatal.ForeColor = System.Drawing.Color.White;
            this.tombolBatal.Location = new System.Drawing.Point(855, 649);
            this.tombolBatal.Name = "tombolBatal";
            this.tombolBatal.Size = new System.Drawing.Size(111, 39);
            this.tombolBatal.TabIndex = 30;
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
            this.tombolTambah.Location = new System.Drawing.Point(738, 649);
            this.tombolTambah.Name = "tombolTambah";
            this.tombolTambah.Size = new System.Drawing.Size(111, 39);
            this.tombolTambah.TabIndex = 27;
            this.tombolTambah.Text = "Tambah";
            this.tombolTambah.UseVisualStyleBackColor = false;
            this.tombolTambah.Click += new System.EventHandler(this.tombolTambah_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tglNota);
            this.groupBox3.Controls.Add(this.boksTanggalNota);
            this.groupBox3.Controls.Add(this.noNota);
            this.groupBox3.Controls.Add(this.boksNoNota);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 94);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaksi";
            // 
            // tglNota
            // 
            this.tglNota.AutoSize = true;
            this.tglNota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tglNota.Location = new System.Drawing.Point(174, 25);
            this.tglNota.Name = "tglNota";
            this.tglNota.Size = new System.Drawing.Size(98, 20);
            this.tglNota.TabIndex = 15;
            this.tglNota.Text = "Tanggal Nota";
            // 
            // boksTanggalNota
            // 
            this.boksTanggalNota.Enabled = false;
            this.boksTanggalNota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksTanggalNota.Location = new System.Drawing.Point(178, 50);
            this.boksTanggalNota.Name = "boksTanggalNota";
            this.boksTanggalNota.Size = new System.Drawing.Size(191, 27);
            this.boksTanggalNota.TabIndex = 14;
            // 
            // noNota
            // 
            this.noNota.AutoSize = true;
            this.noNota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.noNota.Location = new System.Drawing.Point(11, 25);
            this.noNota.Name = "noNota";
            this.noNota.Size = new System.Drawing.Size(69, 20);
            this.noNota.TabIndex = 13;
            this.noNota.Text = "No. Nota";
            // 
            // boksNoNota
            // 
            this.boksNoNota.Enabled = false;
            this.boksNoNota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNoNota.Location = new System.Drawing.Point(15, 50);
            this.boksNoNota.Name = "boksNoNota";
            this.boksNoNota.Size = new System.Drawing.Size(152, 27);
            this.boksNoNota.TabIndex = 12;
            this.boksNoNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boksNoNota_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.boksTotalBarang);
            this.groupBox2.Controls.Add(this.tombolPerbarui);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.boksNamaBarang);
            this.groupBox2.Controls.Add(this.boksJumlahBarang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.boksKodeBarang);
            this.groupBox2.Controls.Add(this.boksHargaBarang);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(413, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 258);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(14, 170);
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
            this.boksTotalBarang.Location = new System.Drawing.Point(18, 195);
            this.boksTotalBarang.Name = "boksTotalBarang";
            this.boksTotalBarang.Size = new System.Drawing.Size(421, 27);
            this.boksTotalBarang.TabIndex = 20;
            // 
            // tombolPerbarui
            // 
            this.tombolPerbarui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolPerbarui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolPerbarui.FlatAppearance.BorderSize = 0;
            this.tombolPerbarui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolPerbarui.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolPerbarui.ForeColor = System.Drawing.Color.White;
            this.tombolPerbarui.Location = new System.Drawing.Point(445, 195);
            this.tombolPerbarui.Name = "tombolPerbarui";
            this.tombolPerbarui.Size = new System.Drawing.Size(87, 27);
            this.tombolPerbarui.TabIndex = 19;
            this.tombolPerbarui.Text = "Simpan";
            this.tombolPerbarui.UseVisualStyleBackColor = false;
            this.tombolPerbarui.Click += new System.EventHandler(this.tombolPerbarui_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(168, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Jumlah Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(168, 47);
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
            this.boksNamaBarang.Location = new System.Drawing.Point(172, 72);
            this.boksNamaBarang.Name = "boksNamaBarang";
            this.boksNamaBarang.Size = new System.Drawing.Size(364, 27);
            this.boksNamaBarang.TabIndex = 14;
            // 
            // boksJumlahBarang
            // 
            this.boksJumlahBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksJumlahBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksJumlahBarang.Location = new System.Drawing.Point(172, 133);
            this.boksJumlahBarang.Name = "boksJumlahBarang";
            this.boksJumlahBarang.Size = new System.Drawing.Size(360, 27);
            this.boksJumlahBarang.TabIndex = 18;
            this.boksJumlahBarang.TextChanged += new System.EventHandler(this.boksJumlahBarang_TextChanged);
            this.boksJumlahBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boksJumlahBarang_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(14, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kode Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(14, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Harga Barang";
            // 
            // boksKodeBarang
            // 
            this.boksKodeBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksKodeBarang.Location = new System.Drawing.Point(18, 72);
            this.boksKodeBarang.Name = "boksKodeBarang";
            this.boksKodeBarang.Size = new System.Drawing.Size(148, 27);
            this.boksKodeBarang.TabIndex = 12;
            this.boksKodeBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boksKodeBarang_KeyPress);
            // 
            // boksHargaBarang
            // 
            this.boksHargaBarang.Enabled = false;
            this.boksHargaBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksHargaBarang.Location = new System.Drawing.Point(18, 133);
            this.boksHargaBarang.Name = "boksHargaBarang";
            this.boksHargaBarang.Size = new System.Drawing.Size(148, 27);
            this.boksHargaBarang.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boksAlamatPembeli);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boksNoHpPembeli);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boksNamaPembeli);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boksKodePembeli);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 164);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pembeli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(174, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alamat Pembeli";
            // 
            // boksAlamatPembeli
            // 
            this.boksAlamatPembeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksAlamatPembeli.Enabled = false;
            this.boksAlamatPembeli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksAlamatPembeli.Location = new System.Drawing.Point(178, 116);
            this.boksAlamatPembeli.Name = "boksAlamatPembeli";
            this.boksAlamatPembeli.Size = new System.Drawing.Size(191, 27);
            this.boksAlamatPembeli.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "No. Hp Pembeli";
            // 
            // boksNoHpPembeli
            // 
            this.boksNoHpPembeli.Enabled = false;
            this.boksNoHpPembeli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNoHpPembeli.Location = new System.Drawing.Point(20, 116);
            this.boksNoHpPembeli.Name = "boksNoHpPembeli";
            this.boksNoHpPembeli.Size = new System.Drawing.Size(152, 27);
            this.boksNoHpPembeli.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(174, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Pembeli";
            // 
            // boksNamaPembeli
            // 
            this.boksNamaPembeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksNamaPembeli.Enabled = false;
            this.boksNamaPembeli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNamaPembeli.Location = new System.Drawing.Point(178, 55);
            this.boksNamaPembeli.Name = "boksNamaPembeli";
            this.boksNamaPembeli.Size = new System.Drawing.Size(191, 27);
            this.boksNamaPembeli.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode Pembeli";
            // 
            // boksKodePembeli
            // 
            this.boksKodePembeli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksKodePembeli.Location = new System.Drawing.Point(20, 55);
            this.boksKodePembeli.Name = "boksKodePembeli";
            this.boksKodePembeli.Size = new System.Drawing.Size(152, 27);
            this.boksKodePembeli.TabIndex = 2;
            this.boksKodePembeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boksKodePembeli_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(683, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Total";
            // 
            // boksTotal
            // 
            this.boksTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boksTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksTotal.Location = new System.Drawing.Point(731, 450);
            this.boksTotal.Name = "boksTotal";
            this.boksTotal.Size = new System.Drawing.Size(235, 27);
            this.boksTotal.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label16.Location = new System.Drawing.Point(672, 486);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "Promo";
            // 
            // boksPromo
            // 
            this.boksPromo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boksPromo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksPromo.Location = new System.Drawing.Point(731, 483);
            this.boksPromo.Name = "boksPromo";
            this.boksPromo.Size = new System.Drawing.Size(235, 27);
            this.boksPromo.TabIndex = 36;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CBKodePromo);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.boksNominal);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 450);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(387, 94);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Promo";
            // 
            // CBKodePromo
            // 
            this.CBKodePromo.FormattingEnabled = true;
            this.CBKodePromo.Location = new System.Drawing.Point(16, 48);
            this.CBKodePromo.Name = "CBKodePromo";
            this.CBKodePromo.Size = new System.Drawing.Size(157, 28);
            this.CBKodePromo.TabIndex = 20;
            this.CBKodePromo.Text = "- Silahkan Pilih  -";
            this.CBKodePromo.SelectedIndexChanged += new System.EventHandler(this.CBKodePromo_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label17.Location = new System.Drawing.Point(175, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Nominal";
            // 
            // boksNominal
            // 
            this.boksNominal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNominal.Location = new System.Drawing.Point(179, 48);
            this.boksNominal.Name = "boksNominal";
            this.boksNominal.Size = new System.Drawing.Size(192, 27);
            this.boksNominal.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label18.Location = new System.Drawing.Point(14, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 20);
            this.label18.TabIndex = 17;
            this.label18.Text = "Kode Promo";
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
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // Aksi
            // 
            this.Aksi.HeaderText = "Aksi";
            this.Aksi.MinimumWidth = 6;
            this.Aksi.Name = "Aksi";
            this.Aksi.Text = "Hapus";
            this.Aksi.UseColumnTextForButtonValue = true;
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 701);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.boksPromo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boksTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boksTotalSemua);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tombolBatal);
            this.Controls.Add(this.tombolTambah);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPenjualan";
            this.Text = "Form Penjualan";
            this.Load += new System.EventHandler(this.FormPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox boksTotalSemua;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox boksKembali;
        private System.Windows.Forms.TextBox boksBayar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button tombolBatal;
        private System.Windows.Forms.Button tombolTambah;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label tglNota;
        private System.Windows.Forms.TextBox boksTanggalNota;
        private System.Windows.Forms.Label noNota;
        private System.Windows.Forms.TextBox boksNoNota;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boksTotalBarang;
        private System.Windows.Forms.Button tombolPerbarui;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boksNamaBarang;
        private System.Windows.Forms.TextBox boksJumlahBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boksKodeBarang;
        private System.Windows.Forms.TextBox boksHargaBarang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boksAlamatPembeli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boksNoHpPembeli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boksNamaPembeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boksKodePembeli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boksTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox boksPromo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox CBKodePromo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox boksNominal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn Aksi;
    }
}