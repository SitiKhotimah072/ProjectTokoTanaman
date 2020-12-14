namespace ProjectTokoTanaman
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pemesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keuanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengeluaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pemasukanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PapayaWhip;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.keuanganToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.pemesananToolStripMenuItem});
            this.dataToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.dataToolStripMenuItem.Text = "Menu";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // pemesananToolStripMenuItem
            // 
            this.pemesananToolStripMenuItem.Name = "pemesananToolStripMenuItem";
            this.pemesananToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pemesananToolStripMenuItem.Text = "Pemesanan";
            this.pemesananToolStripMenuItem.Click += new System.EventHandler(this.pemesananToolStripMenuItem_Click);
            // 
            // keuanganToolStripMenuItem
            // 
            this.keuanganToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.keuanganToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pengeluaranToolStripMenuItem,
            this.pemasukanToolStripMenuItem});
            this.keuanganToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.keuanganToolStripMenuItem.Name = "keuanganToolStripMenuItem";
            this.keuanganToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.keuanganToolStripMenuItem.Text = "Keuangan";
            // 
            // pengeluaranToolStripMenuItem
            // 
            this.pengeluaranToolStripMenuItem.Name = "pengeluaranToolStripMenuItem";
            this.pengeluaranToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pengeluaranToolStripMenuItem.Text = "Pengeluaran";
            this.pengeluaranToolStripMenuItem.Click += new System.EventHandler(this.pengeluaranToolStripMenuItem_Click);
            // 
            // pemasukanToolStripMenuItem
            // 
            this.pemasukanToolStripMenuItem.Name = "pemasukanToolStripMenuItem";
            this.pemasukanToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pemasukanToolStripMenuItem.Text = "Pemasukan";
            this.pemasukanToolStripMenuItem.Click += new System.EventHandler(this.pemasukanToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keuanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengeluaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pemasukanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pemesananToolStripMenuItem;
    }
}