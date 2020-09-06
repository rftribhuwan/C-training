using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace Day12BusTicketBooking
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = $"Data Source=IL013413\\MSSQLSERVER2; Initial Catalog = myDB; Integrated Security=true";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("Select * from BusBooking", connection);
            var adapter = new SqlDataAdapter(command);
            StringBuilder builder = new StringBuilder();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            builder.Append("<table>");
            builder.Append("<tr border='2px solid black'><th>SrNo</th><th>Name</th><th>Phone</th><th>Email</th><th>Source</th><th>Destination</th><th>Travel Date</th><th>Time</th><th>Seat Nos</th><th>Price</th></tr>");
            
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                builder.Append("<tr>");
                builder.Append("<td>" + ds.Tables[0].Rows[i]["SrNo"] + "</td>");
                builder.Append("<td>" + ds.Tables[0].Rows[i]["Name"] + "</td>");
                builder.Append("<td>" + ds.Tables[0].Rows[i]["Phone"] + "</td>");
                builder.Append("<td>" + ds.Tables[0].Rows[i]["Email"] + "</td>");
                builder.Append("<td>" + ds.Tables[0].Rows[i]["Source"] + "</td>");
                builder.Append("<td>" + ds.Tables[0].Rows[i]["Destination"] + "</td>");
                builder.Append("<td>" + ds.Tables[0].Rows[i]["TravelDate"] + "</td>");
                builder.Append("<td>" + ds.Tables[0].Rows[i]["Timing"] + "</td>");
                builder.Append("<td>" + ds.Tables[0].Rows[i]["SeatNos"] + "</td>");
                builder.Append("<td>" + ds.Tables[0].Rows[i]["Price"] + "</td>");
                builder.Append("</tr>");
            }

            builder.Append("</table>");
            DBDataPlaceHolder.Controls.Add(new Literal { Text = builder.ToString() });
            
        }
    }
}