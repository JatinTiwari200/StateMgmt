using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class SessionDemo1_2_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetSessionEmployee_Click(object sender, EventArgs e)
        {
            if (Session["emp"] != null)
            {
                Employee emp = (Employee)Session["emp"];

                Response.Write("<h3 style='color:navy;'>");
                Response.Write("Employee Id: " + emp.EmpID);
                Response.Write("<br/>Employee Name: " + emp.EmpName);
               // Response.Write("<br/>Employee Name: " + emp.EmpName);
                Response.Write("<br/>Salary: " + emp.salary);
                Response.Write("</h3>");
            }

        }
    }
}