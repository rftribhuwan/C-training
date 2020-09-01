using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var a = TextBox1.Text;
            var b = TextBox2.Text;
            var c = TextBox3.Text;
            var d = TextBox4.Text;
            var k = TextBox5.Text;
            var f = TextBox6.Text;
            var g = TextBox7.Text;
            var h = TextBox8.Text;
            var i = TextBox9.Text;
            var j = TextBox10.Text;
        }
    }
}