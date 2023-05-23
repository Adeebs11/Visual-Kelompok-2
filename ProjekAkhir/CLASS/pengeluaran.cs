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
            string query = "SELECT jumlah FROM pengeluaran ORDER BY jumlah ASC LIMIT 1";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
    }
}
