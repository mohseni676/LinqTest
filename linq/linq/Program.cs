using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using linq;
using System.Data;
using System.Data.Common;
using System.Data.Linq.Mapping;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new dbDataContext();
            var tb = db.tbCustomers;
            int count = tb.Count();
            Console.WriteLine(count);
            var list=(from u in tb where u.Lname.Contains("mohy") select new { u.Fname,u.Lname,u.TelegramId,u.mobile}).Count();
            Console.WriteLine("name={0} ", list);
            var list2 = (from u in tb  select new { u.Fname, u.Lname, u.TelegramId, u.mobile });
            foreach (var r in list2)
            {
                Console.WriteLine("name={0} {1}", r.Fname ,r.Lname);
            }
            tbCustomer rb = new tbCustomer
            {
                TelegramId=11111,
                Fname="Reza",
                Lname="Hosseini",
                mobile="09153331099"
            };
            db.tbCustomers.InsertOnSubmit(rb);
            try
            {
                db.SubmitChanges();
                Console.WriteLine("Record Added");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            
        }
    }
}
