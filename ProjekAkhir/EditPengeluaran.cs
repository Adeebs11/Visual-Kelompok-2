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
    public partial class EditPengeluaran : Form
    {
        CLASS.pengeluaran pglr = new CLASS.pengeluaran();
        TransaksiPengeluaran transaksiPengeluaran = new TransaksiPengeluaran();
        CLASS.addPengeluaran addpglr = new CLASS.addPengeluaran();


        int Id;
        public EditPengeluaran(int id, string kategori, DateTime tanggal, double jumlah, string deskripsi)
        {
            InitializeComponent();
            Id = id;
            
            if (kategori == "Makanan dan Minuman")
            {
                gunaComboKategoriPglr.SelectedIndex = 0;
            }
            else if (kategori == "Transportasi")
            {
                gunaComboKategoriPglr.SelectedIndex = 1;
            }

            else if (kategori == "Kebutuhan Rumah")
            {
                gunaComboKategoriPglr.SelectedIndex = 2;
            }
            else if (kategori == "Perawatan Pribadi")
            {
                gunaComboKategoriPglr.SelectedIndex = 3;
            }
            else if (kategori == "Belanja")
            {
                gunaComboKategoriPglr.SelectedIndex = 4;
            }
            else if (kategori == "Kesehatan")
            {
                gunaComboKategoriPglr.SelectedIndex = 5;
            }
            else if (kategori == "Pendidikan")
            {
                gunaComboKategoriPglr.SelectedIndex = 6;
            }
            else
            {
                gunaComboKategoriPglr.SelectedIndex = 7;
            }
            gunaDateTimePickerPglr.Value = tanggal;
            gunaTextBoxJmlPglr.Text = jumlah.ToString();
            gunaTextBoxDeskPglr.Text = deskripsi;
        }

        private void gunaBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButtonMulai_Click(object sender, EventArgs e)
        {
            string Kategori = gunaComboKategoriPglr.Text;
            DateTime Tanggal = gunaDateTimePickerPglr.Value;
            double Jumlah = Convert.ToDouble(gunaTextBoxJmlPglr.Text);
            string Deskripsi = gunaTextBoxDeskPglr.Text;

            if (pglr.editPengeluaran(Id, Kategori, Tanggal, Jumlah, Deskripsi))
            {
                this.Close();

                MessageBox.Show("Data Berhasil Diubah");
                transaksiPengeluaran.gunaDataGridViewPengeluaran.DataSource = addpglr.transaksiPengeluaran();
            }
        }
    }
}
