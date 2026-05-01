using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class system : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public string loggedInEmail;
        public system()
        {
            InitializeComponent();
        }

        private void Trains_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Trains.SelectedItem == null) return;

            conn = new OracleConnection(ordb);
            
                conn.Open();

                OracleCommand cmdCount = new OracleCommand("GetAvailableSeatCount", conn);
                cmdCount.CommandType = CommandType.StoredProcedure;

                cmdCount.Parameters.Add("t_name", Trains.SelectedItem.ToString());
                cmdCount.Parameters.Add("seats_count", OracleDbType.Int32, ParameterDirection.Output);

                try
                {
                    cmdCount.ExecuteNonQuery();
                    string availableCount = cmdCount.Parameters["seats_count"].Value.ToString();
                    Count.Text =  availableCount;
                }
                catch (Exception ex) { MessageBox.Show("Procedure Error: " + ex.Message); }


                OracleCommand cmdDetails = new OracleCommand();
                cmdDetails.Connection = conn;
                cmdDetails.CommandText = "SELECT DEPARTURETIME, BASEFARE FROM TRAINS WHERE TRAINNAME = :name";
                cmdDetails.Parameters.Add("name", Trains.SelectedItem.ToString());

                OracleDataReader dr = cmdDetails.ExecuteReader();
                if (dr.Read())
                {
                    DateTime depTime = Convert.ToDateTime(dr["DEPARTURETIME"]);
                    Dtime.Text = depTime.ToString("HH:mm");
                    Date.Text = depTime.ToString("yyyy-MM-dd");

                    Totalfare.Tag = dr["BASEFARE"].ToString();
                }
                dr.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            
                conn.Open();

                string cmdText = "SELECT TRAINNAME FROM TRAINS " +
                     "WHERE UPPER(SOURCESTATION) = :source AND UPPER(DESTINATIONSTATION) = :dest";

                OracleCommand cmd = new OracleCommand(cmdText, conn);

                cmd.Parameters.Add("source", Source.Text.Trim().ToUpper());
                cmd.Parameters.Add("dest", Destination.Text.Trim().ToUpper());

                Trains.Items.Clear();

                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();

                    bool found = false;
                    while (dr.Read())
                    {
                        Trains.Items.Add(dr["TRAINNAME"].ToString());
                        found = true;
                    }
                    dr.Close();

                    if (!found)
                    {
                        MessageBox.Show("No trains found for this route.");
                    }
                    else
                    {
                        MessageBox.Show("Search complete. Please check the drop-down list.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        


        private void Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Totalfare.Tag != null)
            {
                double baseFare = Convert.ToDouble(Totalfare.Tag);
                double totalFare = baseFare;

                if (Class.SelectedItem.ToString() == "VIP")
                {
                    totalFare = baseFare * 1.5;
                }

                Totalfare.Text = totalFare.ToString();
            }
            if (Totalfare.Tag != null)
            {
                double baseFare = Convert.ToDouble(Totalfare.Tag);
                Totalfare.Text = (Class.SelectedItem.ToString() == "VIP" ? baseFare * 1.5 : baseFare).ToString();
            }

            conn = new OracleConnection(ordb);
            
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = @"SELECT SeatID FROM Seats s 
                            JOIN Trains t ON s.TrainID = t.TrainID 
                            WHERE t.TrainName = :tName 
                            AND s.ClassCategory = :class 
                            AND s.IsBooked = 0 
                            AND ROWNUM = 1";

                cmd.Parameters.Add("tName", Trains.SelectedItem.ToString());
                cmd.Parameters.Add("class", Class.SelectedItem.ToString());

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    SeatID.Text = result.ToString();

                    TicketID.Text = "TKT-" + new Random().Next(10000, 99999).ToString();
                }
                else
                {
                    MessageBox.Show("No available seats for this class.");
                    SeatID.Text = "";
                    TicketID.Text = "";
                }
            
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SeatID.Text) || string.IsNullOrEmpty(TicketID.Text))
            {
                MessageBox.Show("Please select a train and class first.");
                return;
            }

            conn = new OracleConnection(ordb);
            try
            {
                conn.Open();
                OracleTransaction trans = conn.BeginTransaction();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.Transaction = trans;

                cmd.CommandText = "UPDATE Seats SET IsBooked = 1 WHERE SeatID = :sid";
                cmd.Parameters.Add("sid", SeatID.Text);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear(); 
                cmd.CommandText = @"INSERT INTO Bookings (BookingID, SeatID, PASSENGEREMAIL, BookingDate, TotalPaid) 
                            VALUES (:bid, :sid, :email, :bdate, :price)";

                int numericID = new Random().Next(10000, 99999);
                cmd.Parameters.Add("bid", numericID);
                cmd.Parameters.Add("sid", SeatID.Text);
                cmd.Parameters.Add("email", loggedInEmail); 
                cmd.Parameters.Add("bdate", DateTime.Now);
                cmd.Parameters.Add("price", Totalfare.Text);

                cmd.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show($"Success! Ticket {numericID} is confirmed for Seat {SeatID.Text}.");

                SeatID.Clear();
                TicketID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Booking failed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
