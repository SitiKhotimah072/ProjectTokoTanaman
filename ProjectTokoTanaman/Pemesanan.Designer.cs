namespace ProjectTokoTanaman
{
    partial class Pemesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pemesanan));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtStokPemesanan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PilihTanggalPemesanan = new System.Windows.Forms.DateTimePicker();
            this.btnCariPemesanan = new System.Windows.Forms.Button();
            this.txtJumlahPemesanan = new System.Windows.Forms.NumericUpDown();
            this.txtCariPemesanan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefreshPemesanan = new System.Windows.Forms.Button();
            this.txtIdPemesanan = new System.Windows.Forms.TextBox();
            this.btnDeletePemesanan = new System.Windows.Forms.Button();
            this.txtNamaPemesanan = new System.Windows.Forms.TextBox();
            this.btnTambahPemesanan = new System.Windows.Forms.Button();
            this.txtHargaPemesanan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahPemesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtStokPemesanan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.l);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PilihTanggalPemesanan);
            this.groupBox1.Controls.Add(this.btnCariPemesanan);
            this.groupBox1.Controls.Add(this.txtJumlahPemesanan);
            this.groupBox1.Controls.Add(this.txtCariPemesanan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnRefreshPemesanan);
            this.groupBox1.Controls.Add(this.txtIdPemesanan);
            this.groupBox1.Controls.Add(this.btnDeletePemesanan);
            this.groupBox1.Controls.Add(this.txtNamaPemesanan);
            this.groupBox1.Controls.Add(this.btnTambahPemesanan);
            this.groupBox1.Controls.Add(this.txtHargaPemesanan);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(92, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 431);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data  Pemesanan";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(205, 296);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(138, 27);
            this.txtTotal.TabIndex = 29;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // txtStokPemesanan
            // 
            this.txtStokPemesanan.Location = new System.Drawing.Point(205, 254);
            this.txtStokPemesanan.Name = "txtStokPemesanan";
            this.txtStokPemesanan.Size = new System.Drawing.Size(138, 27);
            this.txtStokPemesanan.TabIndex = 28;
            this.txtStokPemesanan.TextChanged += new System.EventHandler(this.txtStokPemesanan_TextChanged);
            this.txtStokPemesanan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStokPemesanan_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Total";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(48, 257);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(42, 20);
            this.l.TabIndex = 26;
            this.l.Text = "Stok";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(626, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 45);
            this.btnClose.TabIndex = 25;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tanggal";
            // 
            // PilihTanggalPemesanan
            // 
            this.PilihTanggalPemesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PilihTanggalPemesanan.Location = new System.Drawing.Point(205, 43);
            this.PilihTanggalPemesanan.Name = "PilihTanggalPemesanan";
            this.PilihTanggalPemesanan.Size = new System.Drawing.Size(252, 22);
            this.PilihTanggalPemesanan.TabIndex = 15;
            this.PilihTanggalPemesanan.ValueChanged += new System.EventHandler(this.PilihTanggalPemesanan_ValueChanged);
            this.PilihTanggalPemesanan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PilihTanggalPemesanan_KeyPress);
            // 
            // btnCariPemesanan
            // 
            this.btnCariPemesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCariPemesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariPemesanan.ForeColor = System.Drawing.Color.White;
            this.btnCariPemesanan.Location = new System.Drawing.Point(604, 394);
            this.btnCariPemesanan.Name = "btnCariPemesanan";
            this.btnCariPemesanan.Size = new System.Drawing.Size(66, 30);
            this.btnCariPemesanan.TabIndex = 23;
            this.btnCariPemesanan.Text = "Cari";
            this.btnCariPemesanan.UseVisualStyleBackColor = false;
            this.btnCariPemesanan.Click += new System.EventHandler(this.btnCariPemesanan_Click);
            // 
            // txtJumlahPemesanan
            // 
            this.txtJumlahPemesanan.Location = new System.Drawing.Point(205, 208);
            this.txtJumlahPemesanan.Name = "txtJumlahPemesanan";
            this.txtJumlahPemesanan.Size = new System.Drawing.Size(138, 27);
            this.txtJumlahPemesanan.TabIndex = 14;
            this.txtJumlahPemesanan.ValueChanged += new System.EventHandler(this.txtJumlahPemesanan_ValueChanged);
            this.txtJumlahPemesanan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahPemesanan_KeyPress);
            // 
            // txtCariPemesanan
            // 
            this.txtCariPemesanan.Location = new System.Drawing.Point(413, 394);
            this.txtCariPemesanan.Name = "txtCariPemesanan";
            this.txtCariPemesanan.Size = new System.Drawing.Size(185, 27);
            this.txtCariPemesanan.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Tanaman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Tanaman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jumlah";
            // 
            // btnRefreshPemesanan
            // 
            this.btnRefreshPemesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefreshPemesanan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshPemesanan.BackgroundImage")));
            this.btnRefreshPemesanan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshPemesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPemesanan.Location = new System.Drawing.Point(375, 350);
            this.btnRefreshPemesanan.Name = "btnRefreshPemesanan";
            this.btnRefreshPemesanan.Size = new System.Drawing.Size(42, 43);
            this.btnRefreshPemesanan.TabIndex = 13;
            this.btnRefreshPemesanan.UseVisualStyleBackColor = false;
            this.btnRefreshPemesanan.Click += new System.EventHandler(this.btnRefreshPemesanan_Click);
            // 
            // txtIdPemesanan
            // 
            this.txtIdPemesanan.Location = new System.Drawing.Point(205, 85);
            this.txtIdPemesanan.Name = "txtIdPemesanan";
            this.txtIdPemesanan.Size = new System.Drawing.Size(252, 27);
            this.txtIdPemesanan.TabIndex = 5;
            this.txtIdPemesanan.TextChanged += new System.EventHandler(this.txtIdPemesanan_TextChanged);
            this.txtIdPemesanan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPemesanan_KeyPress);
            // 
            // btnDeletePemesanan
            // 
            this.btnDeletePemesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeletePemesanan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePemesanan.BackgroundImage")));
            this.btnDeletePemesanan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePemesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePemesanan.Location = new System.Drawing.Point(299, 349);
            this.btnDeletePemesanan.Name = "btnDeletePemesanan";
            this.btnDeletePemesanan.Size = new System.Drawing.Size(51, 44);
            this.btnDeletePemesanan.TabIndex = 12;
            this.btnDeletePemesanan.UseVisualStyleBackColor = false;
            this.btnDeletePemesanan.Click += new System.EventHandler(this.btnDeletePemesanan_Click);
            // 
            // txtNamaPemesanan
            // 
            this.txtNamaPemesanan.Location = new System.Drawing.Point(205, 126);
            this.txtNamaPemesanan.Name = "txtNamaPemesanan";
            this.txtNamaPemesanan.Size = new System.Drawing.Size(252, 27);
            this.txtNamaPemesanan.TabIndex = 6;
            this.txtNamaPemesanan.TextChanged += new System.EventHandler(this.txtNamaPemesanan_TextChanged);
            this.txtNamaPemesanan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaPemesanan_KeyPress);
            // 
            // btnTambahPemesanan
            // 
            this.btnTambahPemesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTambahPemesanan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTambahPemesanan.BackgroundImage")));
            this.btnTambahPemesanan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTambahPemesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPemesanan.Location = new System.Drawing.Point(229, 349);
            this.btnTambahPemesanan.Name = "btnTambahPemesanan";
            this.btnTambahPemesanan.Size = new System.Drawing.Size(45, 44);
            this.btnTambahPemesanan.TabIndex = 11;
            this.btnTambahPemesanan.UseVisualStyleBackColor = false;
            this.btnTambahPemesanan.Click += new System.EventHandler(this.btnTambahPemesanan_Click);
            // 
            // txtHargaPemesanan
            // 
            this.txtHargaPemesanan.Location = new System.Drawing.Point(205, 166);
            this.txtHargaPemesanan.Name = "txtHargaPemesanan";
            this.txtHargaPemesanan.Size = new System.Drawing.Size(252, 27);
            this.txtHargaPemesanan.TabIndex = 7;
            this.txtHargaPemesanan.TextChanged += new System.EventHandler(this.txtHargaPemesanan_TextChanged);
            this.txtHargaPemesanan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaPemesanan_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 483);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 247);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Pemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(853, 713);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pemesanan";
            this.Text = "Pemesanan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahPemesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker PilihTanggalPemesanan;
        private System.Windows.Forms.NumericUpDown txtJumlahPemesanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefreshPemesanan;
        private System.Windows.Forms.TextBox txtIdPemesanan;
        private System.Windows.Forms.Button btnDeletePemesanan;
        private System.Windows.Forms.TextBox txtNamaPemesanan;
        private System.Windows.Forms.Button btnTambahPemesanan;
        private System.Windows.Forms.TextBox txtHargaPemesanan;
        private System.Windows.Forms.Button btnCariPemesanan;
        private System.Windows.Forms.TextBox txtCariPemesanan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtStokPemesanan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l;
    }
}