using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class SessionDemo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void btnCreateSession_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpID = Convert.ToInt32(txtEmpId.Text);
            emp.EmpName = txtEmpName.Text;
            emp.salary = Convert.ToSingle(txtSalary.Text);

            Session["emp"] = emp;
            Response.Write("<h3 style='color:orange;'>");
            Response.Write("Session Object creates.");
            Response.Write("</h3>");
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("SessionDemo1(2).aspx");

        }
    }
}