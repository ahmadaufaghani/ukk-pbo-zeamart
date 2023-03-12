namespace Latihan4
{
    partial class FormLaporanPenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporanPenjualan));
            this.tombolBatal = new System.Windows.Forms.Button();
            this.tombolTambah = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boksAlamatPembeli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boksNoHpPembeli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boksNamaPembeli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boksKodePembeli = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pencarianNota = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.NoNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPembeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePromo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tombolBatal
            // 
            this.tombolBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolBatal.FlatAppearance.BorderSize = 0;
            this.tombolBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolBatal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBatal.ForeColor = System.Drawing.Color.White;
            this.tombolBatal.Location = new System.Drawing.Point(773, 592);
            this.tombolBatal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tombolBatal.Name = "tombolBatal";
            this.tombolBatal.Size = new System.Drawing.Size(111, 37);
            this.tombolBatal.TabIndex = 25;
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
            this.tombolTambah.Location = new System.Drawing.Point(653, 592);
            this.tombolTambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tombolTambah.Name = "tombolTambah";
            this.tombolTambah.Size = new System.Drawing.Size(111, 37);
            this.tombolTambah.TabIndex = 24;
            this.tombolTambah.Text = "Cetak";
            this.tombolTambah.UseVisualStyleBackColor = false;
            this.tombolTambah.Click += new System.EventHandler(this.tombolTambah_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boksAlamatPembeli);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boksNoHpPembeli);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boksNamaPembeli);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.boksKodePembeli);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 424);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(871, 160);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pembeli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(338, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Alamat Pembeli";
            // 
            // boksAlamatPembeli
            // 
            this.boksAlamatPembeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksAlamatPembeli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksAlamatPembeli.Location = new System.Drawing.Point(342, 111);
            this.boksAlamatPembeli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boksAlamatPembeli.Name = "boksAlamatPembeli";
            this.boksAlamatPembeli.Size = new System.Drawing.Size(511, 27);
            this.boksAlamatPembeli.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "No. Hp Pembeli";
            // 
            // boksNoHpPembeli
            // 
            this.boksNoHpPembeli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNoHpPembeli.Location = new System.Drawing.Point(16, 111);
            this.boksNoHpPembeli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boksNoHpPembeli.Name = "boksNoHpPembeli";
            this.boksNoHpPembeli.Size = new System.Drawing.Size(309, 27);
            this.boksNoHpPembeli.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(338, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama Pembeli";
            // 
            // boksNamaPembeli
            // 
            this.boksNamaPembeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksNamaPembeli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNamaPembeli.Location = new System.Drawing.Point(342, 49);
            this.boksNamaPembeli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boksNamaPembeli.Name = "boksNamaPembeli";
            this.boksNamaPembeli.Size = new System.Drawing.Size(511, 27);
            this.boksNamaPembeli.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kode Pembeli";
            // 
            // boksKodePembeli
            // 
            this.boksKodePembeli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksKodePembeli.Location = new System.Drawing.Point(16, 50);
            this.boksKodePembeli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boksKodePembeli.Name = "boksKodePembeli";
            this.boksKodePembeli.Size = new System.Drawing.Size(309, 27);
            this.boksKodePembeli.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoNota,
            this.NamaBarang,
            this.NamaPembeli,
            this.JumlahBeli,
            this.HargaBeli,
            this.KodePromo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 368);
            this.dataGridView1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cari Nota";
            // 
            // pencarianNota
            // 
            this.pencarianNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pencarianNota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarianNota.Location = new System.Drawing.Point(96, 13);
            this.pencarianNota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pencarianNota.Name = "pencarianNota";
            this.pencarianNota.Size = new System.Drawing.Size(788, 27);
            this.pencarianNota.TabIndex = 20;
            this.pencarianNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pencarianNota_KeyPress);
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
            // NoNota
            // 
            this.NoNota.HeaderText = "NoNota";
            this.NoNota.MinimumWidth = 6;
            this.NoNota.Name = "NoNota";
            // 
            // NamaBarang
            // 
            this.NamaBarang.HeaderText = "NamaBarang";
            this.NamaBarang.MinimumWidth = 6;
            this.NamaBarang.Name = "NamaBarang";
            // 
            // NamaPembeli
            // 
            this.NamaPembeli.HeaderText = "NamaPembeli";
            this.NamaPembeli.MinimumWidth = 6;
            this.NamaPembeli.Name = "NamaPembeli";
            // 
            // JumlahBeli
            // 
            this.JumlahBeli.HeaderText = "JumlahBeli";
            this.JumlahBeli.MinimumWidth = 6;
            this.JumlahBeli.Name = "JumlahBeli";
            // 
            // HargaBeli
            // 
            this.HargaBeli.HeaderText = "HargaBeli";
            this.HargaBeli.MinimumWidth = 6;
            this.HargaBeli.Name = "HargaBeli";
            // 
            // KodePromo
            // 
            this.KodePromo.HeaderText = "KodePromo";
            this.KodePromo.MinimumWidth = 6;
            this.KodePromo.Name = "KodePromo";
            // 
            // FormLaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 642);
            this.Controls.Add(this.tombolBatal);
            this.Controls.Add(this.tombolTambah);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pencarianNota);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLaporanPenjualan";
            this.Text = "FormLaporanPenjualan";
            this.Load += new System.EventHandler(this.FormLaporanPenjualan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolBatal;
        private System.Windows.Forms.Button tombolTambah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boksAlamatPembeli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boksNoHpPembeli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boksNamaPembeli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boksKodePembeli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pencarianNota;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPembeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePromo;
    }
}