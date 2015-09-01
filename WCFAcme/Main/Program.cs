using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFAcme.Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DAL.AppDBContext())
            {
                var customers = context.Customers.ToList();
                foreach (var cust in customers)
                {
                    Console.WriteLine(cust.id + " " + cust.customer + " " + cust.address);
                }

            }
        }

    }
}