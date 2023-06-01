using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekAkhir
{
    public partial class TransaksiPemasukan : Form
    {
        CLASS.addPemasukan addpmsk = new CLASS.addPemasukan();
        CLASS.pemasukan pmsk = new CLASS.pemasukan();

        int id;
        string kategori;
        DateTime tanggal;
        double jumlah;
        string deskripsi;
        public TransaksiPemasukan()
        {
            InitializeComponent();
            
        }

        private void Transaksi_Shown(object sender, EventArgs e)
        {
            
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TransaksiPemasukan_Load(object sender, EventArgs e)
        {
            gunaDataGridViewPemasukan.DataSource = addpmsk.transaksiPemasukan();
        }

        private void gunaButtonEdit_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (EditPemasukan uu = new EditPemasukan(id,kategori, tanggal, jumlah, deskripsi))
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

        private void gunaDataGridViewPemasukan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(gunaDataGridViewPemasukan.CurrentRow.Cells[0].Value);
            kategori = gunaDataGridViewPemasukan.CurrentRow.Cells[1].Value.ToString();
            tanggal = (DateTime)gunaDataGridViewPemasukan.CurrentRow.Cells[2].Value;
            jumlah = Convert.ToDouble(gunaDataGridViewPemasukan.CurrentRow.Cells[3].Value);
            deskripsi = gunaDataGridViewPemasukan.CurrentRow.Cells[4].Value.ToString();
        }

        private void gunaButtonHapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Kode untuk menghapus data

                id = Convert.ToInt32(gunaDataGridViewPemasukan.CurrentRow.Cells[0].Value);
                pmsk.removePemasukan(id);
                gunaDataGridViewPemasukan.DataSource = addpmsk.transaksiPemasukan();
                MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Penghapusan data dibatalkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
