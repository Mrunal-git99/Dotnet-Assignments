using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureCalculatorLibrary
{
    public class TemperatureClass
    {
        public float FehernheitToCelsius(float Fehrenheit)
        {
            return (Fehrenheit - 32) * 5 / 9;
        }
    }
}
