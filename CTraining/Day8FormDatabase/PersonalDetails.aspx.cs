using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;



namespace Day8FormDatabase
{
    public partial class PersonalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        /*protected void SubmitButton_Click(object sender, EventArgs e)
        {
            /*string gender, rating;
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
            }*/
            //string CheckBoxContents = Projects.Text;
            /*if (Rating.SelectedValue == "Excellent")
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
            }*/
            /*string connectionString = $"Data Source=IL013413\\MSSQLSERVER2; Initial Catalog = myDB; Integrated Security=true";
            var connection = new SqlConnection(connectionString);
            /*var commandString = "Insert into Details values('"+this.Id.Text+"','"+this.LastName.Text+"','"+this.FirstName.Text+"','"+this.Gender.SelectedValue+"','"+this.Department.SelectedValue+"','+CheckBoxContents+','"+this.Address.Text+"','"+this.City.SelectedValue+"','"+this.Rating.SelectedValue+"')";
            var adapter = new SqlDataAdapter();*/
           /* var com = new SqlCommand("Select * from Details", connection);
            
            connection.Open();
            //adapter.InsertCommand = new SqlCommand(commandString, connection);
            //adapter.InsertCommand.ExecuteNonQuery();
            var reader = com.ExecuteReader();
            while (reader.Read())
            {
                Id.Text = reader[0].ToString();
                
            }
            connection.Close();
           
        }*/

        protected void SubmitButton_Click1(object sender, EventArgs e)
        {
            string CheckBoxContents = "";
            for (int i = 0; i <= Projects.Items.Count - 1; i++)
            {
                if (Projects.Items[i].Selected)
                {
                    if (CheckBoxContents == "")
                    {
                        CheckBoxContents = Projects.Items[i].Text;
                    }
                    else
                    {
                        CheckBoxContents += "," + Projects.Items[i].Text;
                    }
                }
            }
            string connectionString = $"Data Source=IL013413\\MSSQLSERVER2; Initial Catalog = myDB; Integrated Security=true";
            var connection = new SqlConnection(connectionString);
            var commandString = "Insert into Details values('"+this.Id.Text+"','"+this.LastName.Text+"','"+this.FirstName.Text+"','"+this.Gender.SelectedValue+"','"+this.Department.SelectedValue+"','"+CheckBoxContents+"','"+this.Address.Text+"','"+this.City.SelectedValue+"','"+this.Rating.SelectedValue+"')";
            var adapter = new SqlDataAdapter();
            
            connection.Open();
            adapter.InsertCommand = new SqlCommand(commandString, connection);
            adapter.InsertCommand.ExecuteNonQuery();
           
            DataDisplay.DataBind();

            connection.Close();
        }

        
    }
}