using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_app
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            7

            Employees.Add(new Emp { name = "jobin", age = 22, salary = 24000 });
            Employees.Add(new Emp { name = "ajith", age = 24, salary = 26000 });
            Employees.Add(new Emp { name = "sibin", age = 21, salary = 22000 });
            Employees.Add(new Emp { name = "elju", age = 26, salary = 28000 });
            Employees.Add(new Emp { name = "shiju", age = 22, salary = 25000 });
            Employees.Add(new Emp { name = "sreelakshmi", age = 23, salary = 20000 });
            Employees.Add(new Emp { name = "sangeeth", age = 22, salary = 24000 });
            Employees.Add(new Emp { name = "Roby", age = 24, salary = 22000 });
            Employees.Add(new Emp { name = "suresh", age = 21, salary = 21000 });
            Employees.Add(new Emp { name = "soumya", age = 23, salary = 20000 });
            Employees.Add(new Emp { name = "Nisha", age = 22, salary = 24000 });
            Employees.Add(new Emp { name = "eimy", age = 25, salary = 23000 });
            Employees.Add(new Emp { name = "jerin", age = 26, salary = 28000 });
            Employees.Add(new Emp { name = "midhun", age = 27, salary = 26000 });
            Employees.Add(new Emp { name = "arun", age = 22, salary = 26000 });
            Employees.Add(new Emp { name = "sree", age = 28, salary = 22000 });

            //var match = from s in Employees select s;
            // var match = from emp in Employees where emp.age > 22 && emp.salary > 22000 select emp;
            //var match = from emp in Employees select emp.name;
            //var match = from emp in Employees
            //            select new { Name_of_Employee = emp.name, emp.salary };
            //var match = (from emp in Employees select new { emp.name,emp.age }).Distinct();
            // var match = from emp in Employees where emp.name.StartsWith("s") && emp.age > 22 select emp;

            //var match = from emp in Employees where TestEmployee(emp) && emp.age > 22 select emp;
            var match = from emp in Employees orderby emp.name select emp;
            GridView1.DataSource = match;
            GridView1.DataBind();

          

        }
        //static bool TestEmployee(Emp em)
        //{
        //    return em.name.StartsWith("s");
        //}
    }
}