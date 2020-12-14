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
    public partial class Pemasukan : Form
    {
        public Pemasukan()
        {
            InitializeComponent();
            //refreshform();
            view();
        }

        private void view()
        {
            dataGridView1.DataSource = viewdata();
        }

        private void btnCariPemasuk_Click(object sender, EventArgs e)
        {
            string strKoneksi = "Data Source=DESKTOP-49O9H5E;Initial Catalog=projecttoko;Persist Security Info=True;User ID=sa;Password=25";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Pesanan where idPesan='" + txtCariPemasuk.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

            koneksi.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public DataTable viewdata()
        {
            DataTable datatable;

            string strKoneksi = "Data Source=DESKTOP-49O9H5E;Initial Catalog=projecttoko;Persist Security Info=True;User ID=sa;Password=25";
            string query = "select * from Pesanan";

            SqlDataAdapter adapter = new SqlDataAdapter(query, strKoneksi);
            datatable = new DataTable();
            adapter.Fill(datatable);

            return datatable;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }
    }
}
