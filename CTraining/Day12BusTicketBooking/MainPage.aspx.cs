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
                if(string.Compare(item.Value,abc)==0)
                {
                    continue;
                }
                DropDownList2.Items.Add(item);
            }
        }
        protected void ProceedButton_Click(object sender, EventArgs e)
        {

            /*Application["Source"] = DropDownList1.SelectedValue;
            Application["Destination"] = DropDownList2.SelectedValue;
            Application["Date"] = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Application["Time"] = RadioButtonList1.SelectedValue;
            Response.Redirect("Details.aspx");*/

            HttpCookie sourceCookie = new HttpCookie("Source");
            HttpCookie destinationCookie = new HttpCookie("Destination");
            HttpCookie dateCookie = new HttpCookie("Date");
            HttpCookie timeCookie = new HttpCookie("Time");
            sourceCookie.Value = DropDownList1.SelectedValue;
            destinationCookie.Value = DropDownList2.SelectedValue;
            dateCookie.Value = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            timeCookie.Value = RadioButtonList1.SelectedValue;
            sourceCookie.Expires = DateTime.Now.AddHours(1);
            destinationCookie.Expires = DateTime.Now.AddHours(1);
            dateCookie.Expires = DateTime.Now.AddHours(1);
            timeCookie.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(sourceCookie);
            Response.Cookies.Add(destinationCookie);
            Response.Cookies.Add(dateCookie);
            Response.Cookies.Add(timeCookie);
            
            Response.Redirect("Details.aspx");

            //Response.Redirect("Details.aspx ?Source=" +DropDownList1.SelectedValue+"&Destination="+DropDownList2.SelectedValue+"&Date="+Calendar1.SelectedDate.ToString("dd/MM/yyyy")+"&Time="+RadioButtonList1.SelectedValue);
        }
    }
}