using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using WindowsFormsApp2;


namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        CrystalReport1 CR;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            foreach(ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);

            }
            foreach (ParameterDiscreteValue v in CR.ParameterFields[1].DefaultValues)
            {
                comboBox2.Items.Add(v.Value);

            }
            foreach (ParameterDiscreteValue v in CR.ParameterFields[2].DefaultValues)
            {
                comboBox3.Items.Add(v.Value);

            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            CR.SetParameterValue(0, comboBox1.Text);
            CR.SetParameterValue(1, comboBox2.Text);
            CR.SetParameterValue(2, comboBox3.Text);

            crystalReportViewer1.ReportSource = CR;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
