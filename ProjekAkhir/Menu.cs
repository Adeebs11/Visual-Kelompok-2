using ProjekAkhir.Properties;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void MoveIndicator()
        {

        }

        private void gunaBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void gunaButtonMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void container(object _form)
        {
            // Membersihkan panel sebelum menambahkan form baru (opsional)
            if (gunaPanelContainer.Controls.Count > 0) gunaPanelContainer.Controls.Clear();
            // Membuat instance form yang akan ditampilkan
            Form fm = _form as Form;
            // Mengatur properti form sesuai kebutuhan (opsional)
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            // Menambahkan form sebagai kontrol anak ke dalam panel
            gunaPanelContainer.Controls.Add(fm);
            gunaPanelContainer.Tag = fm;
            // Menampilkan form
            fm.Show();
        }

        private void gunaButtonBeranda_Click(object sender, EventArgs e)
        {
            container(new Dashboard());
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            container(new Dashboard());
        }

        private void gunaButtonBudget_Click(object sender, EventArgs e)
        {
            container(new Budget());
        }

        private void gunaButtonTransaksi_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool isCollapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                gunaButtonTransaksi.Image = Resources.Collapse_Arrow_20px;
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                gunaButtonTransaksi.Image = Resources.Expand_Arrow_20px;
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            container(new TransaksiPemasukan());
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            container(new TransaksiPengeluaran());
        }
    }
}
