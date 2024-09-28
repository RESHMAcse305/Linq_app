using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Linq_app
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataContext dc = new DataContext(@"data source=LAPTOP-FKULG3C3\SQLEXPRESS;initial catalog=Shopping_app ;Integrated security=true");
                Table<emp_tbl> employee = dc.GetTable<emp_tbl>();
                var m1 = from emp in employee where emp.Salary > 20000 select emp;
                GridView1.DataSource = m1;
                GridView1.DataBind();


                var m = from emp in employee select new { Name = emp.Name, Id = emp.Id };
                DropDownList1.DataSource = m;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
            }
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source=LAPTOP-FKULG3C3\SQLEXPRESS;initial catalog=Shopping_app ;Integrated security=true");
            Table<emp_tbl> employee = dc.GetTable<emp_tbl>();
            var m = from emp in employee where emp.Id == Convert.ToInt32(DropDownList1.SelectedItem.Value) select emp;
            GridView1.DataSource = m;
            GridView1.DataBind();

            foreach(emp_tbl  em in m)
            {
                TextBox1.Text = em.Id.ToString();
                TextBox2.Text = em.Name;
                TextBox3.Text = em.Job;
                TextBox4.Text = em.Salary.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source=LAPTOP-FKULG3C3\SQLEXPRESS;initial catalog=Shopping_app ;Integrated security=true");
            Table<emp_tbl> employee = dc.GetTable<emp_tbl>();

            emp_tbl emp = new emp_tbl { Id = Convert.ToInt32(TextBox1.Text), Name = TextBox2.Text, Job = TextBox3.Text, Salary = Convert.ToInt32(TextBox4.Text) };
            employee.InsertOnSubmit(emp);
            dc.SubmitChanges();
            GridView1.DataSource = employee;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source=LAPTOP-FKULG3C3\SQLEXPRESS;initial catalog=Shopping_app ;Integrated security=true");
            Table<emp_tbl> employee = dc.GetTable<emp_tbl>();

            emp_tbl em = (from emp in employee where emp.Id == (Convert.ToInt32(DropDownList1.SelectedItem.Value)) select emp).First<emp_tbl>();
            employee.DeleteOnSubmit(em);
            dc.SubmitChanges();
            GridView1.DataSource = employee;
            GridView1.DataBind();


        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            DataContext dc = new DataContext(@"data source=LAPTOP-FKULG3C3\SQLEXPRESS;initial catalog=Shopping_app ;Integrated security=true");
            Table<emp_tbl> employee = dc.GetTable<emp_tbl>();
            emp_tbl em = (from emp in employee where emp.Id == (Convert.ToInt32(DropDownList1.SelectedItem.Value)) select emp).First<emp_tbl>();
            em.Name = TextBox2.Text;
            em.Job = TextBox3.Text;
            em.Salary = Convert.ToInt32(TextBox4.Text);
            dc.SubmitChanges();
            GridView1.DataSource = employee;
            GridView1.DataBind();

        }
    }
}