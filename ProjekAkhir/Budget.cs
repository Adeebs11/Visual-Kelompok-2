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
    public partial class Budget : Form
    {
        public Budget()
        {
            InitializeComponent();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (PilihTransaksi uu = new PilihTransaksi())
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
        
        CLASS.budget bdgt = new CLASS.budget();
        private void Budget_Load(object sender, EventArgs e)
        {
            //Pengeluaran
            gunaLabelTotPengeluaran.Text = "Rp." + bdgt.totBudgetPengeluaran();

            gunaLabelTotMakanan.Text = "Rp." + bdgt.totMakanan();
            gunaLabelTotTransportasi.Text = "Rp." + bdgt.totTransportasi();
            gunaLabelTotRumah.Text = "Rp." + bdgt.totKRumah();
            gunaLabelTotPerawatan.Text = "Rp." + bdgt.totPPribadi();
            gunaLabelTotBelanja.Text = "Rp." + bdgt.totBelanja();
            gunaLabelTotKesehatan.Text = "Rp." + bdgt.totKesehatan();
            gunaLabelTotPendidikan.Text = "Rp." + bdgt.totPendidikan();
            gunaLabelTotLainPengeluaran.Text = "Rp." + bdgt.totPengeluaranLainnya();

            //Pemasukan
            gunaLabelTotPemasukan.Text = "Rp." + bdgt.totBudgetPemasukan();

            gunaLabelTotGaji.Text = "Rp." + bdgt.totGaji();
            gunaLabelTotInvestasi.Text = "Rp." + bdgt.totInvestasi();
            gunaLabelTotLainPemasukan.Text = "Rp." + bdgt.totPemasukanLainnya();
        }
    }
}
