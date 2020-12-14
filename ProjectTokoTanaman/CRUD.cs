using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTokoTanaman
{
    class CRUD
    {
        string strKoneksi = "Data Source=DESKTOP-49O9H5E;Initial Catalog=projecttoko; user ID=sa;Password=25";

        public void insert(string idd, string namaa, string hargaa, string stokk, string btnTambah)
        {

            string str = "";

            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (btnTambah == "Simpan") str = "insert into input_data_tanaman (idTanam, namaTanam, hargaTanam, stokTanam)"
                    + " values(@ID,@NAMA,@HARGA,@STOK)";
            if (btnTambah == "Edit") str = "update input_data_tanaman set namaTanam=@NAMA," +
                    "hargaTanam=@HARGA,stokTanam=@STOK where idTanam=@ID ";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("ID", idd));
            cmd.Parameters.Add(new SqlParameter("NAMA", namaa));
            cmd.Parameters.Add(new SqlParameter("HARGA", hargaa));
            cmd.Parameters.Add(new SqlParameter("STOK", stokk));
            cmd.ExecuteNonQuery();

            koneksi.Close();

        }

        public DataTable viewdata()
        {
            DataTable datatable;

            string strKoneksi = "Data Source=DESKTOP-49O9H5E;Initial Catalog=projecttoko;Persist Security Info=True;User ID=sa;Password=25";
            string query = "select * from input_data_tanaman";

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

                string str = "select*from input_data_tanaman where idTanam=@dd";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("@dd", idd));

                string hasil = "";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    hasil = dr["idTanam"].ToString();
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

        public void delete(string idd)
        {
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            string str = "delete from input_data_tanaman where idTanam = @ID";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("ID", idd));
            cmd.ExecuteNonQuery();
            koneksi.Close();
        }
    }
}
