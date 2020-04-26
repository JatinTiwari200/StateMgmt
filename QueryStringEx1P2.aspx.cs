using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class QueryStringEx1P2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["uname"] != null)
                Label1.Text = "Hello " + Request.QueryString["uname"].ToString();
        } 
    }
}