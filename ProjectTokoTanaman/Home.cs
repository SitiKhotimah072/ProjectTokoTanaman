
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            refreshform();
            view();
        }


        private void btnTambah_Click(object sender, EventArgs e)
        {
            string idd = txtId.Text;
            string namaa = txtNama.Text;
            string hargaa = txtHarga.Text;
            string stokk = txtStok.Text;
            string btn = btnTambah.Name;

            CRUD tambah = new CRUD();
            tambah.insert(idd, namaa, hargaa, stokk, btn);

            view();
            refreshform();
        }

        private void view()
        {
            CRUD cek = new CRUD();
            dataGridView1.DataSource = cek.viewdata();
        }

        private void refreshform()
        {
            txtId.Text = "";
            txtNama.Text = "";
            txtHarga.Text = "";
            txtStok.Text = "";
            txtId.Enabled = true;
            txtNama.Enabled = false;
            txtHarga.Enabled = false;
            txtStok.Enabled = false;
            //txtId.Select();
            btnTambah.Name = "Simpan";
            btnTambah.Enabled = false;
            btnDelete.Enabled = false;
            btnRefresh.Enabled = false;
        }

      

       

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            txtNama.Enabled = true;
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            txtHarga.Enabled = true;
            CRUD crud = new CRUD();

            if (btnTambah.Name == "Simpan")
            {
                if (txtNama.Text.Length > 0)
                {
                    if (crud.cek(txtId.Text) == true)
                    {
                        //MessageBox.Show("id yang sama sudah ada!!!!");
                        refreshform();
                        //DialogResult dlg = MessageBox.Show("id yang sama sudah ada!!!!",
                        //    "Informasi", MessageBoxButtons.OK);
                    }
                    else
                    {
                        txtHarga.Enabled = true;
                    }
                }
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            txtStok.Enabled = true;
        }

     

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string strKoneksi = "Data Source=DESKTOP-49O9H5E;Initial Catalog=projecttoko;Persist Security Info=True;User ID=sa;Password=25";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from input_data_tanaman where idTanam='" + txtCari.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

            koneksi.Close();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ?
                false : true;
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Masukkan angka!!");
            }
            if (txtId.Text.Length >= 15)
            {
                if (e.KeyChar != (char)8 && e.KeyChar != 13 && e.KeyChar != 32)
                {
                    MessageBox.Show("Tidak boleh lebih dari 15 karakter");
                    e.KeyChar = (char)0;
                }
            }
            if (e.KeyChar == 13)
            {
                txtNama.Select();
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHarga.Select();
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtStok.Select();
            }
        }

       

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            refreshform();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (btnTambah.Text.Equals("Simpan")) btnTambah.Text = "Edit";

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string ib = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string nb = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string db = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string d = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            txtId.Text = ib;
            txtNama.Text = nb;
            txtHarga.Text = db;
            txtStok.Text = d;


            txtId.Enabled = false;
            txtNama.Enabled = true;
            txtHarga.Enabled = true;
            //txtStok.Enabled = true;
            btnTambah.Name = "Edit";
            btnTambah.Enabled = true;
            btnDelete.Enabled = true;
            btnRefresh.Enabled = true;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show(this, "Are You Sure?", "Confirm Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                CRUD del = new CRUD();
                del.delete(txtId.Text);
                view();
                refreshform();
            }
        }

        private void txtStok_ValueChanged(object sender, EventArgs e)
        {
            btnTambah.Enabled = true;
            btnTambah.BackColor = Color.Transparent;
            btnRefresh.Enabled = true;
            btnRefresh.BackColor = Color.Transparent;
        }

        private void txtStok_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                btnTambah.Select();
            }
        }
    }
}
