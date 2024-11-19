using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            d1.Day = 11;         // internally C# calls the set assessor
            d1.Month = "June";
            d1.Year = 2024;

            // internally C# calls the get assessor
            Console.WriteLine($"Date is {d1.Day}/ {d1.Month} / {d1.Year}");

            // object initializer syntax

            Date d2 = new Date { Day = 23, Month = "Sept", Year = 2024 };
            Console.WriteLine($"Date is {d2.Day}/ {d2.Month} / {d2.Year}");


        }
    }
}
