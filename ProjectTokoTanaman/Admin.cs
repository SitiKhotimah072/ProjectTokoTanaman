using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTokoTanaman
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-49O9H5E;Initial Catalog=projecttoko;user " + "ID=sa;Password=25");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Admin where username='" + txtUsername.Text + "' and password='" + txtPass.Text + "'", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Menu nw = new Menu();
                nw.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("cek lagi username dan password!!!");

            }

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
