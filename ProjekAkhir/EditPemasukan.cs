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
    public partial class EditPemasukan : Form
    {
        CLASS.pemasukan pmsk = new CLASS.pemasukan();
        TransaksiPemasukan transaksiPemasukan = new TransaksiPemasukan();
        CLASS.addPemasukan addpmsk = new CLASS.addPemasukan();
        
        int Id;


        public EditPemasukan(int id, string kategori, DateTime tanggal, double jumlah,string deskripsi)
        {
            InitializeComponent();
            Id = id;

            if (kategori == "Gaji")
            {
                gunaComboKategoriPmsk.SelectedIndex = 0;
            }
            else if (kategori == "Investasi")
             {
                 gunaComboKategoriPmsk.SelectedIndex = 1;
             }
            
            else
            {
                gunaComboKategoriPmsk.SelectedIndex = 2;
            }
            gunaDateTimePickerPmsk.Value = tanggal;
            gunaTextBoxJmlPmsk.Text = jumlah.ToString();
            gunaTextBoxDeskPmsk.Text = deskripsi;

        }

        private void gunaBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditPemasukan_Load(object sender, EventArgs e)
        {

        }


        private void gunaButtonMulai_Click(object sender, EventArgs e)
        {

            string Kategori = gunaComboKategoriPmsk.Text;
            DateTime Tanggal = gunaDateTimePickerPmsk.Value;
            double Jumlah = Convert.ToDouble(gunaTextBoxJmlPmsk.Text);
            string Deskripsi = gunaTextBoxDeskPmsk.Text;

            if (pmsk.editPemasukan(Id, Kategori, Tanggal, Jumlah, Deskripsi))
            {
                this.Close();

                MessageBox.Show("Data Berhasil Diubah");
                transaksiPemasukan.gunaDataGridViewPemasukan.DataSource = addpmsk.transaksiPemasukan();
            }

        }
    }
}
