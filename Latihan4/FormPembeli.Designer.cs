namespace Latihan4
{
    partial class FormPembeli
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boksAlamatPembeli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boksNoHpPembeli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boksNamaPembeli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boksKodePembeli = new System.Windows.Forms.TextBox();
            this.tombolBatal = new System.Windows.Forms.Button();
            this.tombolHapus = new System.Windows.Forms.Button();
            this.tombolPerbarui = new System.Windows.Forms.Button();
            this.tombolTambah = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 302);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabel Pembeli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boksKodePembeli);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 200);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pembeli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alamat Pembeli";
            // 
            // boksAlamatPembeli
            // 
            this.boksAlamatPembeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksAlamatPembeli.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.boksAlamatPembeli.Location = new System.Drawing.Point(362, 145);
            this.boksAlamatPembeli.Name = "boksAlamatPembeli";
            this.boksAlamatPembeli.Size = new System.Drawing.Size(434, 30);
            this.boksAlamatPembeli.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. Hp Pembeli";
            // 
            // boksNoHpPembeli
            // 
            this.boksNoHpPembeli.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.boksNoHpPembeli.Location = new System.Drawing.Point(36, 145);
            this.boksNoHpPembeli.Name = "boksNoHpPembeli";
            this.boksNoHpPembeli.Size = new System.Drawing.Size(309, 30);
            this.boksNoHpPembeli.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Pembeli";
            // 
            // boksNamaPembeli
            // 
            this.boksNamaPembeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boksNamaPembeli.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.boksNamaPembeli.Location = new System.Drawing.Point(362, 72);
            this.boksNamaPembeli.Name = "boksNamaPembeli";
            this.boksNamaPembeli.Size = new System.Drawing.Size(434, 30);
            this.boksNamaPembeli.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Pembeli";
            // 
            // boksKodePembeli
            // 
            this.boksKodePembeli.Enabled = false;
            this.boksKodePembeli.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.boksKodePembeli.Location = new System.Drawing.Point(36, 72);
            this.boksKodePembeli.Name = "boksKodePembeli";
            this.boksKodePembeli.Size = new System.Drawing.Size(309, 30);
            this.boksKodePembeli.TabIndex = 0;
            // 
            // tombolBatal
            // 
            this.tombolBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolBatal.FlatAppearance.BorderSize = 0;
            this.tombolBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolBatal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBatal.ForeColor = System.Drawing.Color.White;
            this.tombolBatal.Location = new System.Drawing.Point(721, 221);
            this.tombolBatal.Name = "tombolBatal";
            this.tombolBatal.Size = new System.Drawing.Size(111, 39);
            this.tombolBatal.TabIndex = 17;
            this.tombolBatal.Text = "Batal";
            this.tombolBatal.UseVisualStyleBackColor = false;
            this.tombolBatal.Click += new System.EventHandler(this.tombolBatal_Click);
            // 
            // tombolHapus
            // 
            this.tombolHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolHapus.FlatAppearance.BorderSize = 0;
            this.tombolHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolHapus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHapus.ForeColor = System.Drawing.Color.White;
            this.tombolHapus.Location = new System.Drawing.Point(604, 221);
            this.tombolHapus.Name = "tombolHapus";
            this.tombolHapus.Size = new System.Drawing.Size(111, 39);
            this.tombolHapus.TabIndex = 16;
            this.tombolHapus.Text = "Hapus";
            this.tombolHapus.UseVisualStyleBackColor = false;
            this.tombolHapus.Click += new System.EventHandler(this.tombolHapus_Click);
            // 
            // tombolPerbarui
            // 
            this.tombolPerbarui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolPerbarui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolPerbarui.FlatAppearance.BorderSize = 0;
            this.tombolPerbarui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolPerbarui.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolPerbarui.ForeColor = System.Drawing.Color.White;
            this.tombolPerbarui.Location = new System.Drawing.Point(487, 221);
            this.tombolPerbarui.Name = "tombolPerbarui";
            this.tombolPerbarui.Size = new System.Drawing.Size(111, 39);
            this.tombolPerbarui.TabIndex = 15;
            this.tombolPerbarui.Text = "Perbarui";
            this.tombolPerbarui.UseVisualStyleBackColor = false;
            this.tombolPerbarui.Click += new System.EventHandler(this.tombolPerbarui_Click);
            // 
            // tombolTambah
            // 
            this.tombolTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolTambah.FlatAppearance.BorderSize = 0;
            this.tombolTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTambah.ForeColor = System.Drawing.Color.White;
            this.tombolTambah.Location = new System.Drawing.Point(370, 221);
            this.tombolTambah.Name = "tombolTambah";
            this.tombolTambah.Size = new System.Drawing.Size(111, 39);
            this.tombolTambah.TabIndex = 14;
            this.tombolTambah.Text = "Tambah";
            this.tombolTambah.UseVisualStyleBackColor = false;
            this.tombolTambah.Click += new System.EventHandler(this.tombolTambah_Click);
            // 
            // FormPembeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 581);
            this.Controls.Add(this.tombolBatal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tombolHapus);
            this.Controls.Add(this.tombolPerbarui);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tombolTambah);
            this.Name = "FormPembeli";
            this.Text = "FormPembeli";
            this.Load += new System.EventHandler(this.FormPembeli_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boksAlamatPembeli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boksNoHpPembeli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boksNamaPembeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boksKodePembeli;
        private System.Windows.Forms.Button tombolBatal;
        private System.Windows.Forms.Button tombolHapus;
        private System.Windows.Forms.Button tombolPerbarui;
        private System.Windows.Forms.Button tombolTambah;
    }
}