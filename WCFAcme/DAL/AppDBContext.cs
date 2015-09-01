using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFAcme.DAL
{
    public class AppDBContext : AcmeCursosDB
    {

        public AppDBContext() : base("DefaultConnection")
        {

        }


    }
}