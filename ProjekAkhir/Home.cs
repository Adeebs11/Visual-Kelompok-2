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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void gunaBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void gunaButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void gunaButtonMulai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Halo halo = new Halo();
            halo.ShowDialog();
            
        }
    }
}
