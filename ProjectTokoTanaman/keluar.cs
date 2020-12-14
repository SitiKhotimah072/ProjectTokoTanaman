using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTokoTanaman
{
    class keluar
    {
        string strKoneksi = "Data Source=DESKTOP-49O9H5E;Initial Catalog=projecttoko; user ID=sa;Password=25";
        public DataTable viewdata()
        {
            DataTable datatable;

            string strKoneksi = "Data Source=DESKTOP-49O9H5E;Initial Catalog=projecttoko;Persist Security Info=True;User ID=sa;Password=25";
            string query = "select * from Pengeluaran_Keuangan";

            SqlDataAdapter adapter = new SqlDataAdapter(query, strKoneksi);
            datatable = new DataTable();
            adapter.Fill(datatable);

            return datatable;
        }

        public bool cek(string idd)
        {
            bool result = false;
            try
            {
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();

                string str = "select*from Pengeluaran_Keuangan where id=@dd";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("@dd", idd));

                string hasil = "";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    hasil = dr["id"].ToString();
                }
                dr.Close();
                koneksi.Close();
                if (hasil.Equals(idd))
                {
                    result = true;
                }
            }
            catch (Exception)
            {

            }
            return result;
        }


        public void insert(string tg, string idd, string namaa, string hargaa, string jumlah, string btnTambah)
        {

            string str = "";

            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (btnTambah == "Simpan") str = "insert into Pengeluaran_Keuangan (tgl, id, nama, harga, jumlah)"
                    + " values(@TGL,@ID,@NAMA,@HARGA,@JUMLAH)";
            if (btnTambah == "Edit") str = "update Pengeluaran_Keuangan set tgl=@TGL," +
                    "nama = @NAMA,harga=@HARGA,jumlah=@JUMLAH where id=@ID ";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("TGL", tg));
            cmd.Parameters.Add(new SqlParameter("ID", idd));
            cmd.Parameters.Add(new SqlParameter("NAMA", namaa));
            cmd.Parameters.Add(new SqlParameter("HARGA", hargaa));
            cmd.Parameters.Add(new SqlParameter("JUMLAH", jumlah));
            cmd.ExecuteNonQuery();

            koneksi.Close();
        }

        public void delete(string idd)
        {
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            string str = "delete from Pengeluaran_Keuangan where id = @ID";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("ID", idd));
            cmd.ExecuteNonQuery();
            koneksi.Close();
        }
    }
}
