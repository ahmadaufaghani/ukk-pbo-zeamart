namespace Latihan4
{
    partial class FormDaftar
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
            this.tombolDaftar = new System.Windows.Forms.Button();
            this.boksKataSandi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boksKataPengguna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tombolDaftar
            // 
            this.tombolDaftar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.tombolDaftar.FlatAppearance.BorderSize = 0;
            this.tombolDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolDaftar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolDaftar.ForeColor = System.Drawing.Color.White;
            this.tombolDaftar.Location = new System.Drawing.Point(439, 278);
            this.tombolDaftar.Name = "tombolDaftar";
            this.tombolDaftar.Size = new System.Drawing.Size(97, 40);
            this.tombolDaftar.TabIndex = 14;
            this.tombolDaftar.Text = "Daftar";
            this.tombolDaftar.UseVisualStyleBackColor = false;
            this.tombolDaftar.Click += new System.EventHandler(this.tombolDaftar_Click);
            // 
            // boksKataSandi
            // 
            this.boksKataSandi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.boksKataSandi.Location = new System.Drawing.Point(244, 231);
            this.boksKataSandi.Name = "boksKataSandi";
            this.boksKataSandi.PasswordChar = '•';
            this.boksKataSandi.Size = new System.Drawing.Size(293, 30);
            this.boksKataSandi.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(240, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kata Sandi";
            // 
            // boksKataPengguna
            // 
            this.boksKataPengguna.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.boksKataPengguna.Location = new System.Drawing.Point(244, 153);
            this.boksKataPengguna.Name = "boksKataPengguna";
            this.boksKataPengguna.Size = new System.Drawing.Size(293, 30);
            this.boksKataPengguna.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(240, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nama Pengguna";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 450);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Latihan4.Properties.Resources.Group_2__4_;
            this.pictureBox1.Location = new System.Drawing.Point(18, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Latihan4.Properties.Resources.icons8_shutdown_32;
            this.button1.Location = new System.Drawing.Point(548, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 47);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDaftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tombolDaftar);
            this.Controls.Add(this.boksKataSandi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boksKataPengguna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "FormDaftar";
            this.Text = "Daftar";
            this.Load += new System.EventHandler(this.FormDaftar_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolDaftar;
        private System.Windows.Forms.TextBox boksKataSandi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boksKataPengguna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}