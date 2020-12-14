using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTokoTanaman
{
    class Pesan
    {

        string strKoneksi = "Data Source=DESKTOP-49O9H5E;Initial Catalog=projecttoko; user ID=sa;Password=25";
        public void insert(string tg, string idd, string namaa, string hargaa, string jumlahh, string stok, string total, string btn)
        {
            string str = "";

            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (btn == "Simpan") str = "insert into Pesanan (tglPesan,idPesan, namaPesan, hargaPesan, jumlahPesan, stokPesan, Total)"
                    + " values(@TGL,@ID,@NAMA,@HARGA,@JUMLAH,@STOK,@TOTAL)";
            if (btn == "Edit") str = "update Pesanan set tglPesan=@TGL," +
                    "namaPesan=@NAMA,hargaPesan=@HARGA,jumlahPesan=@JUMLAH,stokPesan=@STOK,Total=@TOTAL where idPesan=@ID ";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("TGL", tg));
            cmd.Parameters.Add(new SqlParameter("ID", idd));
            cmd.Parameters.Add(new SqlParameter("NAMA", namaa));
            cmd.Parameters.Add(new SqlParameter("HARGA", hargaa));
            cmd.Parameters.Add(new SqlParameter("JUMLAH", jumlahh));
            cmd.Parameters.Add(new SqlParameter("STOK", stok));
            cmd.Parameters.Add(new SqlParameter("TOTAL", total));
            cmd.ExecuteNonQuery();

            koneksi.Close();
        }

        public bool cek(string idd)
        {
            bool result = false;
            try
            {
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();

                string str = "select*from Pesanan where idPesan=@dd";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("@dd", idd));

                string hasil = "";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    hasil = dr["idPesan"].ToString();
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

        public void delete(string idd)
        {
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            string str = "delete from Pesanan where idPesan = @ID";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("ID", idd));
            cmd.ExecuteNonQuery();
            koneksi.Close();
        }
    }
}
