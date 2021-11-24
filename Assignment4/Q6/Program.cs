using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureCalculatorLibrary;

namespace TemperatureLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureCalculatorLibrary.TemperatureClass temp1 = new TemperatureCalculatorLibrary.TemperatureClass();
            Console.WriteLine("Celsiuis Temperature " + temp1.FehernheitToCelsius(76));
            Console.ReadKey();
        }
    }
}
