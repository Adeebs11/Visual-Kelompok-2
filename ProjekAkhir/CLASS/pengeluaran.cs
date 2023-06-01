using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekAkhir.CLASS
{
    public class pengeluaran
    {
        DATABASE.sakukuDB db = new DATABASE.sakukuDB();

        public string jmlPengeluaran()
        {
            string query = "SELECT SUM(jumlah) FROM pengeluaran";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string jmlTransaksi()
        {
            string query = "SELECT COUNT(id_pengeluaran) FROM pengeluaran";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }

        public string tglPengeluaran()
        {
            string query = "SELECT tanggal FROM pengeluaran ORDER BY tanggal ASC LIMIT 1";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }

        public string maxPengeluaran()
        {
            string query = "SELECT MAX(jumlah) FROM pengeluaran";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }

        public string minPengeluaran()
        {
            string query = "SELECT MIN(jumlah) FROM pengeluaran";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string lastPengeluaran()
        {
            string query = "SELECT jumlah FROM pengeluaran ORDER BY id_pengeluaran DESC LIMIT 1";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }

        public Boolean editPengeluaran(int id, string kategori, DateTime tanggal, double jumlah, string deskripsi)
        {
            string query = "UPDATE `pengeluaran` SET `kategori`=@Kategori,`tanggal`=@Tanggal,`jumlah`=@Jumlah,`deskripsi`=@Deskripsi WHERE `id_pengeluaran` = @Id_pengeluaran";
            MySqlParameter[] parameters = new MySqlParameter[5];

            parameters[0] = new MySqlParameter("@Kategori", MySqlDbType.VarChar);
            parameters[0].Value = kategori;

            parameters[1] = new MySqlParameter("@Tanggal", MySqlDbType.Date);
            parameters[1].Value = tanggal;

            parameters[2] = new MySqlParameter("@Jumlah", MySqlDbType.Double);
            parameters[2].Value = jumlah;

            parameters[3] = new MySqlParameter("@Deskripsi", MySqlDbType.VarChar);
            parameters[3].Value = deskripsi;

            parameters[4] = new MySqlParameter("@Id_pengeluaran", MySqlDbType.Int32);
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

        public Boolean removePengeluaran(int id)
        {
            string query = "DELETE FROM pengeluaran WHERE id_pengeluaran = @id_pengeluaran";
            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@id_pengeluaran", MySqlDbType.Int32);
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
