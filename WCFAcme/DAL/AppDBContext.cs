using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WCFAcme.Models;

namespace WCFAcme.DAL
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class AppDBContext : DbContext
    {

        public AppDBContext() : base(nameOrConnectionString: "AcmeCursosConnection") { }

        public DbSet<Customer> Customers { get; set; }

    }
}