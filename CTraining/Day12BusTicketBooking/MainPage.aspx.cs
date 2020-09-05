using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Day12BusTicketBooking
{
    public partial class MainPage : System.Web.UI.Page
    {
        public string source, destination, quantity;
        public DateTime travelDate;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear(); 
            var abc = DropDownList1.SelectedValue;
            ListItem item;
            for(int i=0;i<DropDownList1.Items.Count;i++) 
            {
                item = DropDownList1.Items[i];
                if(item.Value == abc)
                {
                    continue;
                }
                DropDownList2.Items.Add(item);
            }
        }
        protected void ProceedButton_Click(object sender, EventArgs e)
        {
            
            Application["Source"] = DropDownList1.SelectedValue;
            Application["Destination"] = DropDownList2.SelectedValue;
            Application["Date"] = Calendar1.SelectedDate.Date;
            Application["Time"] = RadioButtonList1.SelectedValue;
            Response.Redirect("Details.aspx");


            /*string connectionString = $"Data Source=IL013413\\MSSQLSERVER2; Initial Catalog = myDB; Integrated Security=true";
            var connection = new SqlConnection(connectionString);
            string commandString = "select count(Name) where
            var occupiedSeats = 
            if(Quantity.Text == "" || int.Parse(Quantity.Text)>25 || Quantity.Text >)
            quantity = Quantity.Text;*/

        }
    }
}