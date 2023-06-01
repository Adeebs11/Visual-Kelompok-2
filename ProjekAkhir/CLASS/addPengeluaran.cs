using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekAkhir.CLASS
{
    public class addPengeluaran
    {
        DATABASE.sakukuDB db = new DATABASE.sakukuDB();
        public Boolean addPglr(string kategori, DateTime tanggal, double jumlah, string deskripsi)
        {
            string query = "INSERT INTO `pengeluaran`(`kategori`, `tanggal`, `jumlah`, `deskripsi`) VALUES (@kategori, @tanggal, @jumlah, @deskripsi)";
            MySqlParameter[] parameters = new MySqlParameter[4];

            parameters[0] = new MySqlParameter("@kategori", MySqlDbType.VarChar);
            parameters[0].Value = kategori;

            parameters[1] = new MySqlParameter("@tanggal", MySqlDbType.Date);
            parameters[1].Value = tanggal;

            parameters[2] = new MySqlParameter("@jumlah", MySqlDbType.Double);
            parameters[2].Value = jumlah;

            parameters[3] = new MySqlParameter("@deskripsi", MySqlDbType.VarChar);
            parameters[3].Value = deskripsi;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable transaksiPengeluaran()
        {
            string query = "SELECT `Id_pengeluaran`, `Kategori`, `Tanggal`, `Jumlah`, `Deskripsi` FROM `pengeluaran`";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }
    }
}
