using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamArray
{
     class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Average(79, 56, 45, 89, 93, 34, 65));
            Console.WriteLine(p.Average(89, 23, 34, 56, 76, 85, 78, 96, 34, 45, 66, 69));
            Console.WriteLine(p.Average(33, 45, 67));
            Console.ReadKey();
        }

        public double Average(params double[] marks)
        {
            double sum = 0;
            double avg=0;
            foreach(double m in marks)
            {
                sum=sum+m;
            }
            avg = sum/marks.Length;
            return avg;
        }
    }
}
