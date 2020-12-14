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
    public partial class Pengeluaran : Form
    {
        public Pengeluaran()
        {
            InitializeComponent();
            view();
            refreshform();
        }

        void view()
        {
            keluar cek = new keluar();
            dataGridView1.DataSource = cek.viewdata();
        }

        private void refreshform()
        {
            PilihTanggal.Text = "";
            txtCariPengeluaran.Text = "";
            txtIdPengeluaran.Text = "";
            txtNamaPengeluaran.Text = "";
            txtHargaPengeluaran.Text = "";
            txtJumlahPengeluaran.Text = "";
            PilihTanggal.Enabled = true;
            txtIdPengeluaran.Enabled = false;
            txtNamaPengeluaran.Enabled = false;
            txtHargaPengeluaran.Enabled = false;
            txtJumlahPengeluaran.Enabled = false;
            //txtId.Select();
            btnTambahPengeluaran.Name = "Simpan";
            btnTambahPengeluaran.Enabled = false;
            btnDeletePengeluaran.Enabled = false;
            btnRefreshPengeluaran.Enabled = false;


        }




        

        private void btnCariPengeluaran_Click(object sender, EventArgs e)
        {
            string strKoneksi = "Data Source=DESKTOP-49O9H5E;Initial Catalog=projecttoko;Persist Security Info=True;User ID=sa;Password=25";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Pengeluaran_Keuangan where id='" + txtCariPengeluaran.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

            koneksi.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnTambahPengeluaran.Text.Equals("Simpan"))
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string g = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string i = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string b = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string j = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            string jj = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

            PilihTanggal.Text = g;
            txtIdPengeluaran.Text = i;
            txtNamaPengeluaran.Text = b;
            txtHargaPengeluaran.Text = j;
            txtJumlahPengeluaran.Text = jj;

            
            txtIdPengeluaran.Enabled = false;
            txtNamaPengeluaran.Enabled = true;
            txtHargaPengeluaran.Enabled = true;
            txtJumlahPengeluaran.Enabled = true;
            btnTambahPengeluaran.Name = "Edit";
        }

        private void btnTambahPengeluaran_Click(object sender, EventArgs e)
        {
            string tg = PilihTanggal.Text;
            string idd = txtIdPengeluaran.Text;
            string namaa = txtNamaPengeluaran.Text;
            string hargaa = txtHargaPengeluaran.Text;
            string jumlahh = txtJumlahPengeluaran.Text;
            string btn = btnTambahPengeluaran.Name;

            keluar tambah = new keluar();
            tambah.insert(tg, idd, namaa, hargaa, jumlahh, btn);

            view();
            refreshform();
        }

        private void btnDeletePengeluaran_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show(this, "Are You Sure?", "Confirm Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                keluar del = new keluar();
                del.delete(txtIdPengeluaran.Text);
                view();
                refreshform();
            }
        }

        private void txtNamaPengeluaran_TextChanged(object sender, EventArgs e)
        {
            
            keluar crud = new keluar();

            if (btnTambahPengeluaran.Name == "Simpan")
            {
                if (txtNamaPengeluaran.Text.Length > 0)
                {
                    if (crud.cek(txtIdPengeluaran.Text) == true)
                    {
                        //MessageBox.Show("id yang sama sudah ada!!!!");
                        refreshform();
                        //DialogResult dlg = MessageBox.Show("id yang sama sudah ada!!!!",
                        //    "Informasi", MessageBoxButtons.OK);
                    }
                    else
                    {
                        txtHargaPengeluaran.Enabled = true;
                    }
                }
            }
        }

        private void txtHargaPengeluaran_TextChanged(object sender, EventArgs e)
        {
            txtJumlahPengeluaran.Enabled = true;
        }

        private void txtJumlahPengeluaran_ValueChanged(object sender, EventArgs e)
        {
            btnTambahPengeluaran.Enabled = true;
            btnTambahPengeluaran.BackColor = Color.Transparent;
            btnRefreshPengeluaran.Enabled = true;
            btnRefreshPengeluaran.BackColor = Color.Transparent;
        }

       

        private void txtIdPengeluaran_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ?
                false : true;
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Masukkan angka!!");
            }
            if (txtIdPengeluaran.Text.Length >= 15)
            {
                if (e.KeyChar != (char)8 && e.KeyChar != 13 && e.KeyChar != 32)
                {
                    MessageBox.Show("Tidak boleh lebih dari 15 karakter");
                    e.KeyChar = (char)0;
                }
            }
            if (e.KeyChar == 13)
            {
                txtNamaPengeluaran.Select();
            }
        }

        private void txtNamaPengeluaran_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                txtHargaPengeluaran.Select();
            }
        }

        private void txtHargaPengeluaran_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                txtJumlahPengeluaran.Select();
            }
        }

        private void txtJumlahPengeluaran_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == 13)
            {
                btnTambahPengeluaran.Select();
            }
        }

        private void btnRefreshPengeluaran_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void txtIdPengeluaran_TextChanged(object sender, EventArgs e)
        {
            txtNamaPengeluaran.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void PilihTanggal_ValueChanged(object sender, EventArgs e)
        {
            
            PilihTanggal.CustomFormat = "dd/MM/yyyy";
            txtIdPengeluaran.Enabled = true;
        }

        private void PilihTanggal_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                txtIdPengeluaran.Select();
            }
        }
    }
}
