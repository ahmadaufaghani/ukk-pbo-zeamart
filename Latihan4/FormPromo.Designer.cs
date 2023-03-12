namespace Latihan4
{
    partial class FormPromo
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
            this.label5 = new System.Windows.Forms.Label();
            this.minPembelian = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nominal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kodePromo = new System.Windows.Forms.TextBox();
            this.tombolBatal = new System.Windows.Forms.Button();
            this.tombolHapus = new System.Windows.Forms.Button();
            this.tombolPerbarui = new System.Windows.Forms.Button();
            this.tombolTambah = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.minPembelian);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nominal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kodePromo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 119);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min. Pembelian";
            // 
            // minPembelian
            // 
            this.minPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minPembelian.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.minPembelian.Location = new System.Drawing.Point(469, 59);
            this.minPembelian.Name = "minPembelian";
            this.minPembelian.Size = new System.Drawing.Size(275, 30);
            this.minPembelian.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nominal";
            // 
            // nominal
            // 
            this.nominal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nominal.Location = new System.Drawing.Point(252, 59);
            this.nominal.Name = "nominal";
            this.nominal.Size = new System.Drawing.Size(200, 30);
            this.nominal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Promo";
            // 
            // kodePromo
            // 
            this.kodePromo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kodePromo.Location = new System.Drawing.Point(29, 59);
            this.kodePromo.Name = "kodePromo";
            this.kodePromo.Size = new System.Drawing.Size(201, 30);
            this.kodePromo.TabIndex = 0;
            // 
            // tombolBatal
            // 
            this.tombolBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tombolBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tombolBatal.FlatAppearance.BorderSize = 0;
            this.tombolBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolBatal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBatal.ForeColor = System.Drawing.Color.White;
            this.tombolBatal.Location = new System.Drawing.Point(676, 138);
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
            this.tombolHapus.Location = new System.Drawing.Point(559, 138);
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
            this.tombolPerbarui.Location = new System.Drawing.Point(442, 138);
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
            this.tombolTambah.Location = new System.Drawing.Point(325, 138);
            this.tombolTambah.Name = "tombolTambah";
            this.tombolTambah.Size = new System.Drawing.Size(111, 39);
            this.tombolTambah.TabIndex = 14;
            this.tombolTambah.Text = "Tambah";
            this.tombolTambah.UseVisualStyleBackColor = false;
            this.tombolTambah.Click += new System.EventHandler(this.tombolTambah_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 316);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabel Promo";
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
            this.dataGridView1.Size = new System.Drawing.Size(739, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tombolBatal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tombolHapus);
            this.Controls.Add(this.tombolPerbarui);
            this.Controls.Add(this.tombolTambah);
            this.Name = "FormPromo";
            this.Text = "FormPromo";
            this.Load += new System.EventHandler(this.FormPromo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minPembelian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nominal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kodePromo;
        private System.Windows.Forms.Button tombolBatal;
        private System.Windows.Forms.Button tombolHapus;
        private System.Windows.Forms.Button tombolPerbarui;
        private System.Windows.Forms.Button tombolTambah;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}