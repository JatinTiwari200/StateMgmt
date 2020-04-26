using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class DataCacheDemo : System.Web.UI.Page
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter adap;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Cache["Data"] != null)
            {
                GridView1.DataSource = Cache["Data"];
                GridView1.DataBind();
            }
            else
            {
                con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database = MyDB;Integrated Security = true");
                query = "select * from Employee";
                adap = new SqlDataAdapter(query, con);
                ds = new DataSet();
                adap.Fill(ds);
                Cache["Data"] = ds.Tables[0].DefaultView;
                GridView1.DataSource = Cache["Data"];
                GridView1.DataBind();
            }

        }
    }
}