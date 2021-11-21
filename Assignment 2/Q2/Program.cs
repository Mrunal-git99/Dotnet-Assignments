using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationDays
{
     class Program
    {
        enum Days {Sunday, Monday, Tuesday, Wednesday, Friday, Saturday}
        static void Main(string[] args)
        {
            int firstday = (int)Days.Tuesday;
            Console.WriteLine(firstday);
            Console.ReadKey();
        }
    }
}
