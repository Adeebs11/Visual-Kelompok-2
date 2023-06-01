using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekAkhir.CLASS
{
    public class pemasukan
    {
        DATABASE.sakukuDB db = new DATABASE.sakukuDB();

        // function to return table of pemasukan
        public string jmlPemasukan()
        {
            string query = "SELECT SUM(jumlah) FROM pemasukan";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string jmlTransaksi()
        {
            string query = "SELECT COUNT(id_pemasukan) FROM pemasukan";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }

        public string tglPemasukan()
        {
            string query = "SELECT tanggal FROM pemasukan ORDER BY tanggal ASC LIMIT 1";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }

        public string maxPemasukan()
        {
            string query = "SELECT MAX(jumlah) FROM pemasukan";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }

        public string minPemasukan()
        {
            string query = "SELECT MIN(jumlah) FROM pemasukan";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string lastPemasukan()
        {
            string query = "SELECT jumlah FROM pemasukan ORDER BY id_pemasukan DESC LIMIT 1";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }

        public string totalBalance()
        {
            string query = "SELECT (SELECT SUM(jumlah) FROM pemasukan) - (SELECT SUM(jumlah) FROM pengeluaran) AS saldo;";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }

        public Boolean editPemasukan(int id, string kategori, DateTime tanggal, double jumlah, string deskripsi)
        {
            string query = "UPDATE `pemasukan` SET `kategori`=@Kategori,`tanggal`=@Tanggal,`jumlah`=@Jumlah,`deskripsi`=@Deskripsi WHERE `id_pemasukan` = @Id_pemasukan";
            MySqlParameter[] parameters = new MySqlParameter[5];

            parameters[0] = new MySqlParameter("@Kategori", MySqlDbType.VarChar);
            parameters[0].Value = kategori;

            parameters[1] = new MySqlParameter("@Tanggal", MySqlDbType.Date);
            parameters[1].Value = tanggal;

            parameters[2] = new MySqlParameter("@Jumlah", MySqlDbType.Double);
            parameters[2].Value = jumlah;

            parameters[3] = new MySqlParameter("@Deskripsi", MySqlDbType.VarChar);
            parameters[3].Value = deskripsi;

            parameters[4] = new MySqlParameter("@Id_pemasukan", MySqlDbType.Int32);
            parameters[4].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean removePemasukan(int id)
        {
            string query = "DELETE FROM pemasukan WHERE id_pemasukan = @id_pemasukan";
            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@id_pemasukan", MySqlDbType.Int32);
            parameters[0].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
