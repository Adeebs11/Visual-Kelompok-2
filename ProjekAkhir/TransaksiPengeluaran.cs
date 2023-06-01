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
    public partial class TransaksiPengeluaran : Form
    {
        CLASS.addPengeluaran addpglr = new CLASS.addPengeluaran();
        CLASS.pengeluaran pglr = new CLASS.pengeluaran();

        int id;
        string kategori;
        DateTime tanggal;
        double jumlah;
        string deskripsi;

        public TransaksiPengeluaran()
        {
            InitializeComponent();
        }

        private void TransaksiPengeluaran_Load(object sender, EventArgs e)
        {
            gunaDataGridViewPengeluaran.DataSource = addpglr.transaksiPengeluaran();
        }

        private void gunaButtonEdit_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (EditPengeluaran uu = new EditPengeluaran(id, kategori, tanggal, jumlah, deskripsi))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void gunaDataGridViewPengeluaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(gunaDataGridViewPengeluaran.CurrentRow.Cells[0].Value);
            kategori = gunaDataGridViewPengeluaran.CurrentRow.Cells[1].Value.ToString();
            tanggal = (DateTime)gunaDataGridViewPengeluaran.CurrentRow.Cells[2].Value;
            jumlah = Convert.ToDouble(gunaDataGridViewPengeluaran.CurrentRow.Cells[3].Value);
            deskripsi = gunaDataGridViewPengeluaran.CurrentRow.Cells[4].Value.ToString();
        }

        private void gunaButtonHapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Kode untuk menghapus data

                id = Convert.ToInt32(gunaDataGridViewPengeluaran.CurrentRow.Cells[0].Value);
                pglr.removePengeluaran(id);
                gunaDataGridViewPengeluaran.DataSource = addpglr.transaksiPengeluaran();
                MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Penghapusan data dibatalkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
