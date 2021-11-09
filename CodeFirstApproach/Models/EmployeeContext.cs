using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeFirstApproach.Models
{
    public class EmployeeContext :DbContext
    {
        //connectionstring
        public EmployeeContext():base("ConStr")
        {

        }

        //table

        public DbSet<EmployeeModel> EmployeeModels { get; set; }

    }
}