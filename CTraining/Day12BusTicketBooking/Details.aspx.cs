using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace Day12BusTicketBooking
{
    public partial class Details : System.Web.UI.Page
    {
        static List<string> seatList = new List<string>();
        static string[] seat12;
        static string seats = "";
        static int count = 0;
        static int rate = 0;
        string source, destination, date, time;
        protected void ButtonDisable(Button button)
        {
                foreach (var items in seatList)
                {
                    if (string.Compare(button.Text, items) == 0)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
        }
        protected void ButtonSelect(Button button)
        {
            button.BackColor = Color.Green;
            if (string.IsNullOrEmpty(seats))
            {
                seats += button.Text;
            }
            else
            {
                seats += "," + button.Text;
            }
            count++;
            rate = 200 * count;
            Quantity.Text = count.ToString();
            TotalPrice.Text = rate.ToString();
            button.Enabled = false;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Quantity.Text = "0";
            TotalPrice.Text = "0";
            

            source = Application["Source"].ToString();
            destination = Application["Destination"].ToString();
            date = Application["Date"].ToString();
            time = Application["Time"].ToString();
            string connectionString = $"Data Source=IL013413\\MSSQLSERVER2; Initial Catalog = myDB; Integrated Security=true";
            var connection = new SqlConnection(connectionString);
            string commandString = $"select SeatNos from BusBooking where Source=@source and Destination=@destination and TravelDate=@date and Timing=@time";
            var command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@source", source);
            command.Parameters.AddWithValue("@destination", destination);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@time", time);
            connection.Open();
            var reader = command.ExecuteReader();
            while(reader.Read())
            {
                string readerElements = reader[0].ToString();
                seat12 = readerElements.Split(',');
                foreach(var items in seat12)
                {
                    seatList.Add(items);
                }
                
            }
            connection.Close();
            ButtonDisable(Button2);
            ButtonDisable(Button3);
            ButtonDisable(Button4);
            ButtonDisable(Button5);
            ButtonDisable(Button6);
            ButtonDisable(Button7);
            ButtonDisable(Button8);
            ButtonDisable(Button9);
            ButtonDisable(Button10);
            ButtonDisable(Button11);
            ButtonDisable(Button12);
            ButtonDisable(Button13);
            ButtonDisable(Button14);
            ButtonDisable(Button15);
            ButtonDisable(Button16);
            ButtonDisable(Button17);
            ButtonDisable(Button18);
            ButtonDisable(Button19);
            ButtonDisable(Button20);
            ButtonDisable(Button21);
            ButtonDisable(Button22);
            ButtonDisable(Button23);
            ButtonDisable(Button24);
            ButtonDisable(Button25);


        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button25);
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button24);
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button23);
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button22);
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button21);
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button20);
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button19);
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button18);
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button17);
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button16);
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button15);
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button14);
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button13);
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button12);
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button11);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button10);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button9);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button8);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button7);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button6);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button5);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button4);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button3);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ButtonSelect(Button2);
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            string connectionString = $"Data Source=IL013413\\MSSQLSERVER2; Initial Catalog = myDB; Integrated Security=true";
            var connection = new SqlConnection(connectionString);
            string commandString = "Insert into BusBooking values(@Name,@Phone,@Email,@Source,@Destination,@Date,@Time,@Seats,@Price)";
            var adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(commandString, connection);
            connection.Open();
            adapter.InsertCommand.Parameters.AddWithValue("@Name", Name.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@Phone", PhoneNumber.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@Email", Email.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@Source", source);
            adapter.InsertCommand.Parameters.AddWithValue("@Destination", destination);
            adapter.InsertCommand.Parameters.AddWithValue("@Date", date);
            adapter.InsertCommand.Parameters.AddWithValue("@Time", time);
            adapter.InsertCommand.Parameters.AddWithValue("@Seats", seats);
            adapter.InsertCommand.Parameters.AddWithValue("@Price", rate);
            adapter.InsertCommand.ExecuteNonQuery();
            connection.Close();
            Response.Redirect("Display.aspx");
        }
    }
}