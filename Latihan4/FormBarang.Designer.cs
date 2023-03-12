namespace Latihan4
{
    partial class FormBarang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cariGambar = new System.Windows.Forms.Button();
            this.boksHargaBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boksNamaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boksKodeBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boksStokBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tombolTambah = new System.Windows.Forms.Button();
            this.tombolPerbarui = new System.Windows.Forms.Button();
            this.tombolHapus = new System.Windows.Forms.Button();
            this.tombolBatal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cariGambar);
            this.groupBox1.Controls.Add(this.boksHargaBarang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boksNamaBarang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.boksKodeBarang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barang";
            // 
            // cariGambar
            // 
            this.cariGambar.Location = new System.Drawing.Point(23, 172);
            this.cariGambar.Name = "cariGambar";
            this.cariGambar.Size = new System.Drawing.Size(123, 39);
            this.cariGambar.TabIndex = 9;
            this.cariGambar.Text = "Browse...";
            this.cariGambar.UseVisualStyleBackColor = true;
            this.cariGambar.Click += new System.EventHandler(this.cariGambar_Click);
            // 
            // boksHargaBarang
            // 
            this.boksHargaBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksHargaBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksHargaBarang.Location = new System.Drawing.Point(172, 172);
            this.boksHargaBarang.Name = "boksHargaBarang";
            this.boksHargaBarang.Size = new System.Drawing.Size(582, 27);
            this.boksHargaBarang.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Harga Barang";
            // 
            // boksNamaBarang
            // 
            this.boksNamaBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksNamaBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNamaBarang.Location = new System.Drawing.Point(172, 111);
            this.boksNamaBarang.Name = "boksNamaBarang";
            this.boksNamaBarang.Size = new System.Drawing.Size(582, 27);
            this.boksNamaBarang.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Barang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(23, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // boksKodeBarang
            // 
            this.boksKodeBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksKodeBarang.Enabled = false;
            this.boksKodeBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksKodeBarang.Location = new System.Drawing.Point(172, 49);
            this.boksKodeBarang.Name = "boksKodeBarang";
            this.boksKodeBarang.Size = new System.Drawing.Size(582, 27);
            this.boksKodeBarang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // boksStokBarang
            // 
            this.boksStokBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksStokBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksStokBarang.Location = new System.Drawing.Point(185, 250);
            this.boksStokBarang.Name = "boksStokBarang";
            this.boksStokBarang.Size = new System.Drawing.Size(582, 27);
            this.boksStokBarang.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stok Barang";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tombolTambah
            // 
            this.tombolTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolTambah.FlatAppearance.BorderSize = 0;
            this.tombolTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolTambah.ForeColor = System.Drawing.Color.White;
            this.tombolTambah.Location = new System.Drawing.Point(326, 315);
            this.tombolTambah.Name = "tombolTambah";
            this.tombolTambah.Size = new System.Drawing.Size(111, 39);
            this.tombolTambah.TabIndex = 10;
            this.tombolTambah.Text = "Tambah";
            this.tombolTambah.UseVisualStyleBackColor = false;
            this.tombolTambah.Click += new System.EventHandler(this.tombolTambah_Click);
            // 
            // tombolPerbarui
            // 
            this.tombolPerbarui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolPerbarui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolPerbarui.FlatAppearance.BorderSize = 0;
            this.tombolPerbarui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolPerbarui.ForeColor = System.Drawing.Color.White;
            this.tombolPerbarui.Location = new System.Drawing.Point(443, 315);
            this.tombolPerbarui.Name = "tombolPerbarui";
            this.tombolPerbarui.Size = new System.Drawing.Size(111, 39);
            this.tombolPerbarui.TabIndex = 11;
            this.tombolPerbarui.Text = "Perbarui";
            this.tombolPerbarui.UseVisualStyleBackColor = false;
            this.tombolPerbarui.Click += new System.EventHandler(this.tombolPerbarui_Click);
            // 
            // tombolHapus
            // 
            this.tombolHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolHapus.FlatAppearance.BorderSize = 0;
            this.tombolHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolHapus.ForeColor = System.Drawing.Color.White;
            this.tombolHapus.Location = new System.Drawing.Point(560, 315);
            this.tombolHapus.Name = "tombolHapus";
            this.tombolHapus.Size = new System.Drawing.Size(111, 39);
            this.tombolHapus.TabIndex = 12;
            this.tombolHapus.Text = "Hapus";
            this.tombolHapus.UseVisualStyleBackColor = false;
            this.tombolHapus.Click += new System.EventHandler(this.tombolHapus_Click);
            // 
            // tombolBatal
            // 
            this.tombolBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolBatal.FlatAppearance.BorderSize = 0;
            this.tombolBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolBatal.ForeColor = System.Drawing.Color.White;
            this.tombolBatal.Location = new System.Drawing.Point(677, 315);
            this.tombolBatal.Name = "tombolBatal";
            this.tombolBatal.Size = new System.Drawing.Size(111, 39);
            this.tombolBatal.TabIndex = 13;
            this.tombolBatal.Text = "Batal";
            this.tombolBatal.UseVisualStyleBackColor = false;
            this.tombolBatal.Click += new System.EventHandler(this.tombolBatal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 194);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabel Barang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tombolBatal);
            this.Controls.Add(this.boksStokBarang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tombolHapus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tombolPerbarui);
            this.Controls.Add(this.tombolTambah);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cariGambar;
        private System.Windows.Forms.TextBox boksStokBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boksHargaBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boksNamaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox boksKodeBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tombolTambah;
        private System.Windows.Forms.Button tombolPerbarui;
        private System.Windows.Forms.Button tombolHapus;
        private System.Windows.Forms.Button tombolBatal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}