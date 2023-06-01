using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekAkhir
{
    public partial class TambahPemasukan : Form
    {
        CLASS.addPemasukan addpmsk = new CLASS.addPemasukan();
        public TambahPemasukan()
        {
            InitializeComponent();
        }

        private void gunaBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButtonMulai_Click(object sender, EventArgs e)
        {
            string kategori = gunaComboKategoriPmsk.Text;
            DateTime tanggal = gunaDateTimePickerPmsk.Value;
            double jumlah = Convert.ToDouble(gunaTextBoxJmlPmsk.Text);
            string deskripsi = gunaTextBoxDeskPmsk.Text;

            addpmsk.addPmsk(kategori, tanggal, jumlah, deskripsi);
            this.Close();

            MessageBox.Show("Transaksi Berhasil Dilakukan!");

        }
    }
}
