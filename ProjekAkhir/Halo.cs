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
    public partial class Halo : Form
    {
        public Halo()
        {
            InitializeComponent();
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


        private void Halo_Load(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            
        }
    }
}
