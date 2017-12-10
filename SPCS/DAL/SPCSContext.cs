using SPCS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SPCS.DAL
{
    public class SPCSContext: DbContext
    {
        public SPCSContext() : base("SPCSContext") { }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ShiftInstance> ShiftInstances { get; set; }

        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-N8EF63B\\SQLEXPRESS;Initial Catalog=Intex;Integrated Security=True");
    }
}