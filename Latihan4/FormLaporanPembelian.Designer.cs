namespace Latihan4
{
    partial class FormLaporanPembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporanPembelian));
            this.pencarianFaktur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NoFaktur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boksDeskripsiSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boksAlamatSupplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boksNoHpSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boksNamaSupplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boksKodeSupplier = new System.Windows.Forms.TextBox();
            this.tombolBatal = new System.Windows.Forms.Button();
            this.tombolCetak = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pencarianFaktur
            // 
            this.pencarianFaktur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pencarianFaktur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarianFaktur.Location = new System.Drawing.Point(96, 22);
            this.pencarianFaktur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pencarianFaktur.Name = "pencarianFaktur";
            this.pencarianFaktur.Size = new System.Drawing.Size(788, 27);
            this.pencarianFaktur.TabIndex = 0;
            this.pencarianFaktur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pencarianFaktur_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari Faktur";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoFaktur,
            this.NamaBarang,
            this.NamaSupplier,
            this.JumlahBeli,
            this.HargaBeli});
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 352);
            this.dataGridView1.TabIndex = 2;
            // 
            // NoFaktur
            // 
            this.NoFaktur.HeaderText = "NoFaktur";
            this.NoFaktur.MinimumWidth = 6;
            this.NoFaktur.Name = "NoFaktur";
            // 
            // NamaBarang
            // 
            this.NamaBarang.HeaderText = "NamaBarang";
            this.NamaBarang.MinimumWidth = 6;
            this.NamaBarang.Name = "NamaBarang";
            // 
            // NamaSupplier
            // 
            this.NamaSupplier.HeaderText = "NamaSupplier";
            this.NamaSupplier.MinimumWidth = 6;
            this.NamaSupplier.Name = "NamaSupplier";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.boksDeskripsiSupplier);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boksAlamatSupplier);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boksNoHpSupplier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boksNamaSupplier);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.boksKodeSupplier);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 417);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(871, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Deskripsi Supplier";
            // 
            // boksDeskripsiSupplier
            // 
            this.boksDeskripsiSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksDeskripsiSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksDeskripsiSupplier.Location = new System.Drawing.Point(16, 177);
            this.boksDeskripsiSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boksDeskripsiSupplier.Name = "boksDeskripsiSupplier";
            this.boksDeskripsiSupplier.Size = new System.Drawing.Size(837, 27);
            this.boksDeskripsiSupplier.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(338, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Alamat Supplier";
            // 
            // boksAlamatSupplier
            // 
            this.boksAlamatSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksAlamatSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksAlamatSupplier.Location = new System.Drawing.Point(342, 111);
            this.boksAlamatSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boksAlamatSupplier.Name = "boksAlamatSupplier";
            this.boksAlamatSupplier.Size = new System.Drawing.Size(511, 27);
            this.boksAlamatSupplier.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "No. Hp Supplier";
            // 
            // boksNoHpSupplier
            // 
            this.boksNoHpSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNoHpSupplier.Location = new System.Drawing.Point(16, 111);
            this.boksNoHpSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boksNoHpSupplier.Name = "boksNoHpSupplier";
            this.boksNoHpSupplier.Size = new System.Drawing.Size(309, 27);
            this.boksNoHpSupplier.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(338, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama Supplier";
            // 
            // boksNamaSupplier
            // 
            this.boksNamaSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksNamaSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksNamaSupplier.Location = new System.Drawing.Point(342, 49);
            this.boksNamaSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boksNamaSupplier.Name = "boksNamaSupplier";
            this.boksNamaSupplier.Size = new System.Drawing.Size(511, 27);
            this.boksNamaSupplier.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kode Supplier";
            // 
            // boksKodeSupplier
            // 
            this.boksKodeSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boksKodeSupplier.Location = new System.Drawing.Point(16, 50);
            this.boksKodeSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boksKodeSupplier.Name = "boksKodeSupplier";
            this.boksKodeSupplier.Size = new System.Drawing.Size(309, 27);
            this.boksKodeSupplier.TabIndex = 10;
            // 
            // tombolBatal
            // 
            this.tombolBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolBatal.FlatAppearance.BorderSize = 0;
            this.tombolBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolBatal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBatal.ForeColor = System.Drawing.Color.White;
            this.tombolBatal.Location = new System.Drawing.Point(772, 647);
            this.tombolBatal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tombolBatal.Name = "tombolBatal";
            this.tombolBatal.Size = new System.Drawing.Size(111, 37);
            this.tombolBatal.TabIndex = 19;
            this.tombolBatal.Text = "Batal";
            this.tombolBatal.UseVisualStyleBackColor = false;
            this.tombolBatal.Click += new System.EventHandler(this.tombolBatal_Click);
            // 
            // tombolCetak
            // 
            this.tombolCetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolCetak.FlatAppearance.BorderSize = 0;
            this.tombolCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolCetak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolCetak.ForeColor = System.Drawing.Color.White;
            this.tombolCetak.Location = new System.Drawing.Point(655, 647);
            this.tombolCetak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tombolCetak.Name = "tombolCetak";
            this.tombolCetak.Size = new System.Drawing.Size(111, 37);
            this.tombolCetak.TabIndex = 18;
            this.tombolCetak.Text = "Cetak";
            this.tombolCetak.UseVisualStyleBackColor = false;
            this.tombolCetak.Click += new System.EventHandler(this.tombolCetak_Click);
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
            // FormLaporanPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 698);
            this.Controls.Add(this.tombolBatal);
            this.Controls.Add(this.tombolCetak);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pencarianFaktur);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLaporanPembelian";
            this.Text = "Laporan Pembelian";
            this.Load += new System.EventHandler(this.FormLaporanPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pencarianFaktur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boksDeskripsiSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boksAlamatSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boksNoHpSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boksNamaSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boksKodeSupplier;
        private System.Windows.Forms.Button tombolBatal;
        private System.Windows.Forms.Button tombolCetak;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoFaktur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaBeli;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}