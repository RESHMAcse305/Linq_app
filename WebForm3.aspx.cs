using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Linq_app
{
    public partial class WebForm3 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source=LAPTOP-FKULG3C3\SQLEXPRESS;initial catalog=Shopping_app ;Integrated security=true");
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter("select * from emp_tbl", con);
            adp.Fill(ds, "emp");

            // var m = from emp in ds.Tables["emp"].AsEnumerable() select emp;
            //var m = from emp in ds.Tables["emp"].AsEnumerable() where emp.Field<int>("salary") > 20000 select emp;
            // var m = from emp in ds.Tables["emp"].AsEnumerable() where emp.Field<int>("salary") > 20000 select emp.Field<string>("Name");
            //var m = from emp in ds.Tables[0].AsEnumerable() select new { Name = emp.Field<string>("Name"), job = emp.Field<string>("job") };
            //GridView1.DataSource = m;
            //GridView1.DataBind();

            var m= (from emp in ds.Tables[0].AsEnumerable() select emp.Field<int>("id")).Max();
            Response.Write(m);


        }
    }
}