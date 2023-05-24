using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekAkhir.CLASS
{
    public class budget
    {
        DATABASE.sakukuDB db = new DATABASE.sakukuDB();

        // function to return table of pengeluaran
        public string totBudgetPengeluaran()
        {
            string query = "SELECT SUM(jumlah) FROM pengeluaran";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }

        public string totMakanan()
        {
            string query = "SELECT SUM(jumlah) FROM pengeluaran WHERE kategori = 'Makanan dan Minuman'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string totTransportasi()
        {
            string query = "SELECT SUM(jumlah) FROM pengeluaran WHERE kategori = 'Transportasi'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string totKRumah()
        {
            string query = "SELECT SUM(jumlah) FROM pengeluaran WHERE kategori = 'Kebutuhan Rumah'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string totPPribadi()
        {
            string query = "SELECT SUM(jumlah) FROM pengeluaran WHERE kategori = 'Perawatan Pribadi'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string totBelanja()
        {
            string query = "SELECT SUM(jumlah) FROM pengeluaran WHERE kategori = 'Belanja'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string totKesehatan()
        {
            string query = "SELECT SUM(jumlah) FROM pengeluaran WHERE kategori = 'Kesehatan'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string totPendidikan()
        {
            string query = "SELECT SUM(jumlah) FROM pengeluaran WHERE kategori = 'Pendidikan'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string totPengeluaranLainnya()
        {
            string query = "SELECT SUM(jumlah) FROM pengeluaran WHERE kategori = 'Lainnya'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        // function to return table of pemasukan
        public string totBudgetPemasukan()
        {
            string query = "SELECT SUM(jumlah) FROM pemasukan";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }

        public string totGaji()
        {
            string query = "SELECT SUM(jumlah) FROM pemasukan WHERE kategori = 'Gaji'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string totInvestasi()
        {
            string query = "SELECT SUM(jumlah) FROM pemasukan WHERE kategori = 'Investasi'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
        public string totPemasukanLainnya()
        {
            string query = "SELECT SUM(jumlah) FROM pemasukan WHERE kategori = 'Lainnya'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table.Rows[0][0].ToString();
        }
    }
}
