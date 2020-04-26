using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class CookieEx1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("CookieEx2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie id = new HttpCookie("pid");
            HttpCookie name = new HttpCookie("pname");
            HttpCookie price = new HttpCookie("uprice");


            id.Value = TextBox1.Text;
            name.Value = TextBox2.Text;
            price.Value = TextBox3.Text;

            //cookie variables are stored in browser's memory
            // the followinf code adds the cookie variables to the browser's memory

            Response.Cookies.Add(id);
            Response.Cookies.Add(name);
            Response.Cookies.Add(price);

            Response.Write("<h3 style='color:green;'>");
            Response.Write("Cookies created...");
            Response.Write("</h3>");

        }
    }
}