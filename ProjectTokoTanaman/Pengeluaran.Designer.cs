namespace ProjectTokoTanaman
{
    partial class Pengeluaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pengeluaran));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.PilihTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtJumlahPengeluaran = new System.Windows.Forms.NumericUpDown();
            this.btnCariPengeluaran = new System.Windows.Forms.Button();
            this.txtCariPengeluaran = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefreshPengeluaran = new System.Windows.Forms.Button();
            this.txtIdPengeluaran = new System.Windows.Forms.TextBox();
            this.btnDeletePengeluaran = new System.Windows.Forms.Button();
            this.txtNamaPengeluaran = new System.Windows.Forms.TextBox();
            this.btnTambahPengeluaran = new System.Windows.Forms.Button();
            this.txtHargaPengeluaran = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahPengeluaran)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 270);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.PilihTanggal);
            this.groupBox1.Controls.Add(this.txtJumlahPengeluaran);
            this.groupBox1.Controls.Add(this.btnCariPengeluaran);
            this.groupBox1.Controls.Add(this.txtCariPengeluaran);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnRefreshPengeluaran);
            this.groupBox1.Controls.Add(this.txtIdPengeluaran);
            this.groupBox1.Controls.Add(this.btnDeletePengeluaran);
            this.groupBox1.Controls.Add(this.txtNamaPengeluaran);
            this.groupBox1.Controls.Add(this.btnTambahPengeluaran);
            this.groupBox1.Controls.Add(this.txtHargaPengeluaran);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 357);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data  Pengeluaran";
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
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(655, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 45);
            this.btnClose.TabIndex = 16;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PilihTanggal
            // 
            this.PilihTanggal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PilihTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PilihTanggal.Location = new System.Drawing.Point(205, 43);
            this.PilihTanggal.Name = "PilihTanggal";
            this.PilihTanggal.Size = new System.Drawing.Size(248, 22);
            this.PilihTanggal.TabIndex = 15;
            this.PilihTanggal.ValueChanged += new System.EventHandler(this.PilihTanggal_ValueChanged);
            this.PilihTanggal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PilihTanggal_KeyPress);
            // 
            // txtJumlahPengeluaran
            // 
            this.txtJumlahPengeluaran.Location = new System.Drawing.Point(205, 208);
            this.txtJumlahPengeluaran.Name = "txtJumlahPengeluaran";
            this.txtJumlahPengeluaran.Size = new System.Drawing.Size(123, 27);
            this.txtJumlahPengeluaran.TabIndex = 14;
            this.txtJumlahPengeluaran.ValueChanged += new System.EventHandler(this.txtJumlahPengeluaran_ValueChanged);
            this.txtJumlahPengeluaran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahPengeluaran_KeyPress);
            // 
            // btnCariPengeluaran
            // 
            this.btnCariPengeluaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCariPengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariPengeluaran.ForeColor = System.Drawing.Color.White;
            this.btnCariPengeluaran.Location = new System.Drawing.Point(610, 311);
            this.btnCariPengeluaran.Name = "btnCariPengeluaran";
            this.btnCariPengeluaran.Size = new System.Drawing.Size(62, 31);
            this.btnCariPengeluaran.TabIndex = 5;
            this.btnCariPengeluaran.Text = "Cari";
            this.btnCariPengeluaran.UseVisualStyleBackColor = false;
            this.btnCariPengeluaran.Click += new System.EventHandler(this.btnCariPengeluaran_Click);
            // 
            // txtCariPengeluaran
            // 
            this.txtCariPengeluaran.Location = new System.Drawing.Point(446, 313);
            this.txtCariPengeluaran.Name = "txtCariPengeluaran";
            this.txtCariPengeluaran.Size = new System.Drawing.Size(158, 27);
            this.txtCariPengeluaran.TabIndex = 4;
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
            // btnRefreshPengeluaran
            // 
            this.btnRefreshPengeluaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefreshPengeluaran.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshPengeluaran.BackgroundImage")));
            this.btnRefreshPengeluaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshPengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPengeluaran.Location = new System.Drawing.Point(353, 254);
            this.btnRefreshPengeluaran.Name = "btnRefreshPengeluaran";
            this.btnRefreshPengeluaran.Size = new System.Drawing.Size(42, 43);
            this.btnRefreshPengeluaran.TabIndex = 13;
            this.btnRefreshPengeluaran.UseVisualStyleBackColor = false;
            this.btnRefreshPengeluaran.Click += new System.EventHandler(this.btnRefreshPengeluaran_Click);
            // 
            // txtIdPengeluaran
            // 
            this.txtIdPengeluaran.Location = new System.Drawing.Point(205, 85);
            this.txtIdPengeluaran.Name = "txtIdPengeluaran";
            this.txtIdPengeluaran.Size = new System.Drawing.Size(248, 27);
            this.txtIdPengeluaran.TabIndex = 5;
            this.txtIdPengeluaran.TextChanged += new System.EventHandler(this.txtIdPengeluaran_TextChanged);
            this.txtIdPengeluaran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPengeluaran_KeyPress);
            // 
            // btnDeletePengeluaran
            // 
            this.btnDeletePengeluaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeletePengeluaran.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePengeluaran.BackgroundImage")));
            this.btnDeletePengeluaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePengeluaran.Location = new System.Drawing.Point(277, 253);
            this.btnDeletePengeluaran.Name = "btnDeletePengeluaran";
            this.btnDeletePengeluaran.Size = new System.Drawing.Size(51, 44);
            this.btnDeletePengeluaran.TabIndex = 12;
            this.btnDeletePengeluaran.UseVisualStyleBackColor = false;
            this.btnDeletePengeluaran.Click += new System.EventHandler(this.btnDeletePengeluaran_Click);
            // 
            // txtNamaPengeluaran
            // 
            this.txtNamaPengeluaran.Location = new System.Drawing.Point(205, 126);
            this.txtNamaPengeluaran.Name = "txtNamaPengeluaran";
            this.txtNamaPengeluaran.Size = new System.Drawing.Size(248, 27);
            this.txtNamaPengeluaran.TabIndex = 6;
            this.txtNamaPengeluaran.TextChanged += new System.EventHandler(this.txtNamaPengeluaran_TextChanged);
            this.txtNamaPengeluaran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaPengeluaran_KeyPress);
            // 
            // btnTambahPengeluaran
            // 
            this.btnTambahPengeluaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTambahPengeluaran.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTambahPengeluaran.BackgroundImage")));
            this.btnTambahPengeluaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTambahPengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPengeluaran.Location = new System.Drawing.Point(207, 253);
            this.btnTambahPengeluaran.Name = "btnTambahPengeluaran";
            this.btnTambahPengeluaran.Size = new System.Drawing.Size(45, 44);
            this.btnTambahPengeluaran.TabIndex = 11;
            this.btnTambahPengeluaran.UseVisualStyleBackColor = false;
            this.btnTambahPengeluaran.Click += new System.EventHandler(this.btnTambahPengeluaran_Click);
            // 
            // txtHargaPengeluaran
            // 
            this.txtHargaPengeluaran.Location = new System.Drawing.Point(205, 166);
            this.txtHargaPengeluaran.Name = "txtHargaPengeluaran";
            this.txtHargaPengeluaran.Size = new System.Drawing.Size(248, 27);
            this.txtHargaPengeluaran.TabIndex = 7;
            this.txtHargaPengeluaran.TextChanged += new System.EventHandler(this.txtHargaPengeluaran_TextChanged);
            this.txtHargaPengeluaran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaPengeluaran_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 21;
            // 
            // Pengeluaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(790, 689);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pengeluaran";
            this.Text = "Pengeluaran";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahPengeluaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtJumlahPengeluaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefreshPengeluaran;
        private System.Windows.Forms.TextBox txtIdPengeluaran;
        private System.Windows.Forms.Button btnDeletePengeluaran;
        private System.Windows.Forms.TextBox txtNamaPengeluaran;
        private System.Windows.Forms.Button btnTambahPengeluaran;
        private System.Windows.Forms.TextBox txtHargaPengeluaran;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCariPengeluaran;
        private System.Windows.Forms.Button btnCariPengeluaran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker PilihTanggal;
    }
}