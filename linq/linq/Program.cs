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
            //Console.WriteLine(count);
            var list=(from u in tb  select new { u.Fname,u.Lname,u.TelegramId,u.mobile}).Count();
            Console.WriteLine("Count={0} ", list);
            var list2 = (from u in tb  select new { u.Fname, u.Lname, u.TelegramId, u.mobile });
            foreach (var r in list2)
            {
                Console.WriteLine("{0} {1} {2} {3}", r.Fname ,r.Lname,r.mobile,r.TelegramId);
            }
            tbCustomer rb = new tbCustomer();
            Console.Write("TelegramID=");
            rb.TelegramId = Convert.ToInt32(Console.ReadLine());
            Console.Write("First Name=");
            rb.Fname = Console.ReadLine();
            Console.Write("Last Name=");
            rb.Lname = Console.ReadLine();
            Console.Write("Mobile=");
            rb.mobile = Console.ReadLine();



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
