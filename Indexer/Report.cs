using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Report
    {
        public delegate bool IsIllegate(Employee e);
        public void ProcessEmployee(Employee[] employees, string title, IsIllegate isIllegate )
        {
            Console.WriteLine(title);
            Console.WriteLine("====================================");

            foreach (var e in employees)
            {
                if (isIllegate(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        //----------------------------(1)-----------------
        //public void ProcessEmployeeWithSalesPlus60000(Employee[] employees)
        //{
        //    Console.WriteLine("Employee with sales over 60 000: ");
        //    Console.WriteLine("====================================");

        //    foreach (var e in employees)
        //    {
        //        if (e.TotalSales >= 60000)
        //        {
        //            Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.TotalSales}");
        //        }
        //    }
        ////    Console.WriteLine("\n\n");
        //}

        //public void ProcessEmployeeWithSalesBetween30000And59999(Employee[] employees)
        //{
        //    Console.WriteLine("Employee with sales Between 30 000 And 59 999: ");
        //    Console.WriteLine("====================================");

        //    foreach (var e in employees)
        //    {
        //        if (e.TotalSales >= 30000 && e.TotalSales <=59999)
        //        {
        //            Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.TotalSales}");
        //        }
        //    }
        ////    Console.WriteLine("\n\n");

        //}

        //public void ProcessEmployeeWithSalesLessThan30000(Employee[] employees)
        //{
        //    Console.WriteLine("Employee with sales LessThan 30 000: ");
        //    Console.WriteLine("====================================");

        //    foreach (var e in employees)
        //    {
        //        if (e.TotalSales < 30000)
        //        {
        //            Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.TotalSales}");
        //        }
        //    }
        ////    Console.WriteLine("\n\n");

        //}
    }
}
