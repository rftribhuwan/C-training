using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Day8FormDatabase
{
    public partial class PersonalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string gender, rating;
            if(Gender.SelectedValue == "Male")
            {
                gender = "Male";
            }
            else if(Gender.SelectedValue == "Female")
            {
                gender = "Female";
            }
            else
            {
                gender = "Other";
            }
            string CheckBoxContents = Projects.Text;
            if (Rating.SelectedValue == "Excellent")
            {
                rating = "Excellent";
            }
            else if (Rating.SelectedValue == "Very Good")
            {
                rating = "Very Good";
            }
            else if (Rating.SelectedValue == "Good")
            {
                rating = "Good";
            }
            else
            {
                rating = "Bad";
            }
            string connectionString = $"Data Source=ctraining.database.windows.net; Initial Catalog=myDB; User ID=reuben; Password=Pass@1234";
            var connection = new SqlConnection(connectionString);
            var commandString = "Insert into Details values('"+this.Id.Text+"','"+this.LastName.Text+"','"+this.FirstName.Text+"','+gender+','"+this.Department.SelectedValue+"','+CheckBoxContents+','"+this.Address.Text+"','"+this.City.SelectedValue+"','+rating+')";
            var adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(commandString, connection);
            connection.Open();
            adapter.InsertCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}