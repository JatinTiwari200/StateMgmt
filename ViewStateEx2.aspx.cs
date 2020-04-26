using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace StateMgmt
{
    public partial class ViewStateEx2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSetViewState_Click(object sender, EventArgs e)
        {
            ViewState["uname"] = TextBox1.Text;
            Response.Write("Viewstate text changed.");

        }

        protected void btnGetViewState_Click(object sender, EventArgs e)
        {
            Response.Write("<h3 style='color:green;'>");
            Response.Write("Name: " + ViewState["uname"].ToString());
            Response.Write("</h3>");

        }
    }
}