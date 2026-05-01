using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        // Use Easy Connect - more reliable than "Data Source=orcl"
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";

        private OracleDataAdapter adapter;
        private DataSet ds;

        public AdminForm()
        {
            InitializeComponent();
        }

        //Disconnected Mode Requirement B1 
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please enter a Source Station (e.g. Cairo)");
                return;
            }

            try
            {
                string cmdStr = "SELECT * FROM Trains WHERE UPPER(SourceStation) = :src";

                adapter = new OracleDataAdapter(cmdStr, ordb);



                adapter.SelectCommand.Parameters.Add("src", OracleDbType.Varchar2).Value = txtSearch.Text.Trim().ToUpper();

                ds = new DataSet();
                adapter.Fill(ds, "Trains");

                dgvTrains.DataSource = ds.Tables["Trains"];


                new OracleCommandBuilder(adapter);

                MessageBox.Show("Data loaded successfully. You can now edit the grid.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error:\n" + ex.Message);
            }
        }

        // Disconnected Mode Requirement B2 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ds == null || adapter == null)
            {
                MessageBox.Show("Please click Load first!");
                return;
            }

            try
            {
                int rowsAffected = adapter.Update(ds.Tables["Trains"]);

                MessageBox.Show($"{rowsAffected} change(s) saved successfully to the database!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Error:\n" + ex.Message);
            }
        }
    }
}