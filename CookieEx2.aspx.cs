using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class CookieEx2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["pid"] != null)
            {
                string pid = Request.Cookies["pid"].Value;
                Response.Write("<h3 style='color:orange;'>");
                Response.Write("Product ID: " + pid);
                Response.Write("</h3>");
            }
            else
            {
                Response.Write("<h3 style='color:red;'>");
                Response.Write("Product Id does not exist / expired.");
                Response.Write("</h3>");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["pname"] != null)
            {
                string pname = Request.Cookies["pname"].Value;
                Response.Write("<h3 style='color:orange;'>");
                Response.Write("Product Name: " + pname);
                Response.Write("</h3>");
            }
            else
            {
                Response.Write("<h3 style='color:red;'>");
                Response.Write("Product Name does not exist / expired.");
                Response.Write("</h3>");
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["uprice"] != null)
            {
                string uprice = Request.Cookies["uprice"].Value;
                Response.Write("<h3 style='color:orange;'>");
                Response.Write("Unit Price: " + uprice);
                Response.Write("</h3>");
            }
            else
            {
                Response.Write("<h3 style='color:red;'>");
                Response.Write("Unit Price does not exist / expired.");
                Response.Write("</h3>");
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write("<h3 style='color:maroon;'>");
            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                Response.Write(Request.Cookies[i].Name);
                Response.Write(" : ");
                Response.Write(Request.Cookies[i].Value);
                Response.Write("<br/>");
            }
            Response.Write("</h3>");
        }

    }
}
