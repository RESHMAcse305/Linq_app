using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Linq_app
{
    [Table(Name ="emp_tbl")]
    public class emp_tbl
    {
        [Column(IsPrimaryKey =true)]
        public int Id { set; get; }
        [Column]
        public string Name { set; get; }
        [Column]
        public string Job { set; get; }
        [Column]
        public int Salary { set; get; }
    }
}