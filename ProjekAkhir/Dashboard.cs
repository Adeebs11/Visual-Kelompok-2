using MySql.Data.MySqlClient;
using ProjekAkhir.CLASS;
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

namespace ProjekAkhir
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        CLASS.pemasukan pmsk = new CLASS.pemasukan();
        CLASS.pengeluaran pglr = new CLASS.pengeluaran();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Pemasukan
            gunaLabelJmlPemasukan.Text ="Rp." + pmsk.jmlPemasukan();
            gunaLabelTransPemasukan.Text = pmsk.jmlTransaksi();
            gunaLabelTglPemasukan.Text = pmsk.tglPemasukan();
            gunaLabelPemasukanMax.Text = "Rp." + pmsk.maxPemasukan();
            gunaLabelPemasukanMin.Text = "Rp." + pmsk.minPemasukan();
            gunaLabelLastPmsk.Text = "Rp." + pmsk.lastPemasukan();

            //Pengeluaran
            gunaLabelJmlPengeluaran.Text = "Rp." + pglr.jmlPengeluaran();
            gunaLabelTransPengeluaran.Text = pglr.jmlTransaksi();
            gunaLabelTglPengeluaran.Text = pglr.tglPengeluaran();
            gunaLabelPengeluaranMax.Text = "Rp." + pglr.maxPengeluaran();
            gunaLabelPengeluaranMin.Text = "Rp." + pglr.minPengeluaran();
            gunaLabelLastPengeluaran.Text = "Rp." + pglr.lastPengeluaran();

            //Total
            gunaLabelTotal.Text = "Rp." + pmsk.totalBalance();
        }
    }
}
