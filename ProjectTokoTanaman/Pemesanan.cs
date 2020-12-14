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
    public partial class Pemesanan : Form
    {

        static int jumlah = 0, harga = 0;
        public Pemesanan()
        {
            InitializeComponent();
            view();
            refreshform();
        }

        private void refreshform()
        {
            PilihTanggalPemesanan.Text = "";
            txtCariPemesanan.Text = "";
            txtIdPemesanan.Text = "";
            txtNamaPemesanan.Text = "";
            txtHargaPemesanan.Text = "";
            txtJumlahPemesanan.Text = "";
            PilihTanggalPemesanan.Enabled = true;
            txtIdPemesanan.Enabled = false;
            txtNamaPemesanan.Enabled = false;
            txtHargaPemesanan.Enabled = false;
            txtJumlahPemesanan.Enabled = false;
            txtStokPemesanan.Enabled = false;
            txtTotal.Enabled = false;
            //txtId.Select();
            btnTambahPemesanan.Name = "Simpan";
            btnTambahPemesanan.Enabled = false;
            btnDeletePemesanan.Enabled = false;
            btnRefreshPemesanan.Enabled = false;
        }

        private void view()
        {
            Pesan cek = new Pesan();
            dataGridView1.DataSource = cek.viewdata();
        }

        private void btnCariPemesanan_Click(object sender, EventArgs e)
        {
            string strKoneksi = "Data Source=DESKTOP-49O9H5E;Initial Catalog=projecttoko;Persist Security Info=True;User ID=sa;Password=25";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Pesanan where idPesan='" + txtCariPemesanan.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

            koneksi.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnTambahPemesanan.Text.Equals("Simpan"))
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string g = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string i = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string b = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string j = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            string jj = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            string a = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            string c = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);

            PilihTanggalPemesanan.Text = g;
            txtIdPemesanan.Text = i;
            txtNamaPemesanan.Text = b;
            txtHargaPemesanan.Text = j;
            txtJumlahPemesanan.Text = jj;
            txtStokPemesanan.Text = a;
            txtTotal.Text = c;


            txtIdPemesanan.Enabled = false;
            txtNamaPemesanan.Enabled = true;
            txtHargaPemesanan.Enabled = true;
            txtJumlahPemesanan.Enabled = true;
            btnTambahPemesanan.Name = "Edit";
        }

        private void btnTambahPemesanan_Click(object sender, EventArgs e)
        {
            string tg = PilihTanggalPemesanan.Text;
            string idd = txtIdPemesanan.Text;
            string namaa = txtNamaPemesanan.Text;
            string hargaa = txtHargaPemesanan.Text;
            string jumlahh = txtJumlahPemesanan.Text;
            string stok = txtStokPemesanan.Text;
            string total = txtTotal.Text;
            string btn = btnTambahPemesanan.Name;

            Pesan tambah = new Pesan();
            tambah.insert(tg, idd, namaa, hargaa, jumlahh, stok, total, btn);

            view();
            refreshform();
        }

        private void btnDeletePemesanan_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show(this, "Are You Sure?", "Confirm Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                Pesan del = new Pesan();
                del.delete(txtIdPemesanan.Text);
                view();
                refreshform();
            }
        }

        private void btnRefreshPemesanan_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void PilihTanggalPemesanan_ValueChanged(object sender, EventArgs e)
        {
            PilihTanggalPemesanan.CustomFormat = "dd/MM/yyyy";
            txtIdPemesanan.Enabled = true;
        }

        private void PilihTanggalPemesanan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtIdPemesanan.Select();
            }
        }

        private void txtIdPemesanan_TextChanged(object sender, EventArgs e)
        {
            txtNamaPemesanan.Enabled = true;
        }

        private void txtIdPemesanan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ?
                false : true;
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Masukkan angka!!");
            }
            if (txtIdPemesanan.Text.Length >= 15)
            {
                if (e.KeyChar != (char)8 && e.KeyChar != 13 && e.KeyChar != 32)
                {
                    MessageBox.Show("Tidak boleh lebih dari 15 karakter");
                    e.KeyChar = (char)0;
                }
            }
            if (e.KeyChar == 13)
            {
                txtNamaPemesanan.Select();
            }
        }

        private void txtNamaPemesanan_TextChanged(object sender, EventArgs e)
        {
            Pesan crud = new Pesan();

            if (btnTambahPemesanan.Name == "Simpan")
            {
                if (txtNamaPemesanan.Text.Length > 0)
                {
                    if (crud.cek(txtIdPemesanan.Text) == true)
                    {
                        //MessageBox.Show("id yang sama sudah ada!!!!");
                        refreshform();
                        //DialogResult dlg = MessageBox.Show("id yang sama sudah ada!!!!",
                        //    "Informasi", MessageBoxButtons.OK);
                    }
                    else
                    {
                        txtHargaPemesanan.Enabled = true;
                    }
                }
            }
        }

        private void txtNamaPemesanan_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                txtHargaPemesanan.Select();
            }
        }

        private void txtHargaPemesanan_TextChanged(object sender, EventArgs e)
        {
            txtJumlahPemesanan.Enabled = true;
        }

        private void txtHargaPemesanan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtJumlahPemesanan.Select();
            }
        }

        private void txtJumlahPemesanan_ValueChanged(object sender, EventArgs e)
        {
            if(Int32.TryParse(txtJumlahPemesanan.Text, out jumlah) && Int32.TryParse(txtHargaPemesanan.Text, out harga))
            {
                txtTotal.Text = (jumlah *  harga).ToString();
                txtStokPemesanan.Enabled = true;
            }


        }

        private void txtJumlahPemesanan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtStokPemesanan.Select();
            }
        }

        private void txtStokPemesanan_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Enabled = true;
        }

        private void txtStokPemesanan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTotal.Select();
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            btnTambahPemesanan.Enabled = true;
            btnTambahPemesanan.BackColor = Color.Transparent;
            btnRefreshPemesanan.Enabled = true;
            btnRefreshPemesanan.BackColor = Color.Transparent;
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTambahPemesanan.Select();
            }
        }
    }
}
