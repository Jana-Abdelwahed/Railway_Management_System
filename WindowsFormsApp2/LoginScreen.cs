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
using Oracle.DataAccess.Types;


namespace WindowsFormsApp2
{
    public partial class LoginScreen : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            
            
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT FULLNAME FROM PASSENGERS WHERE EMAIL = :email AND PASSWORD = :pass";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("email", Email.Text);
                cmd.Parameters.Add("pass", Password.Text);

                OracleDataReader dr = cmd.ExecuteReader();

                
            if (dr.Read())
            {
                string passengerName = dr["FULLNAME"].ToString();
                MessageBox.Show("Login Successfully! Welcome " + passengerName);

                system f2 = new system();
                f2.loggedInEmail = Email.Text;

                f2.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("Invalid Email or Password. Please try again.");
            }

            conn.Close();
        }

        
    }
    }

