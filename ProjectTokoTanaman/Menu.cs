using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTokoTanaman
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

      

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
       

        private void pengeluaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pengeluaran dm = new Pengeluaran();
            dm.Show();
            this.Hide();
        }

        private void pemasukanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pemasukan dm = new Pemasukan();
            dm.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home dm = new Home();
            dm.Show();
            this.Hide();
        }

        private void pemesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pemesanan dm = new Pemesanan();
            dm.Show();
            this.Hide();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
