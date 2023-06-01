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
    public partial class TambahPengeluaran : Form
    {
        CLASS.addPengeluaran addpglr = new CLASS.addPengeluaran();
        public TambahPengeluaran()
        {
            InitializeComponent();
        }

        private void gunaBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButtonMulai_Click(object sender, EventArgs e)
        {
            string kategori = gunaComboKategoriPglr.Text;
            DateTime tanggal = gunaDateTimePickerPglr.Value;
            double jumlah = Convert.ToDouble(gunaTextBoxJmlPglr.Text);
            string deskripsi = gunaTextBoxDeskPglr.Text;

            addpglr.addPglr(kategori, tanggal, jumlah, deskripsi);
            this.Close();

            MessageBox.Show("Transaksi Berhasil Dilakukan!");
        }
    }
}
