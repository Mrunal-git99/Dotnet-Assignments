using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedExample
{
    class Bird
    {

    }
    sealed class Test : Bird { }
    class Example: Test { }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
