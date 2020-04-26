using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class ViewStateEx1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { if(!Page.IsPostBack)
            Label1.Text = "Hello";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}