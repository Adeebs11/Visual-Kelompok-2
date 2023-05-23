﻿using System;
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
            string query = "SELECT jumlah FROM pemasukan ORDER BY jumlah ASC LIMIT 1";
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

    }
}
