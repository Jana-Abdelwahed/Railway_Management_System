using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp7;

namespace WindowsFormsApp2
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginScreen l = new LoginScreen();
            l.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            AdminForm admin = new AdminForm();
            admin.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form1 Report= new Form1();
            Report.Show();
            

        }
    }
}

