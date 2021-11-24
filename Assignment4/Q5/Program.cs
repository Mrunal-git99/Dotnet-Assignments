using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Console.WriteLine("Roll no Name");
            dict.Add("1", "Mrunal");
            dict.Add("2", "Ayushi");
            dict.Add("3", "Kunal");
            dict.Add("4", "Akash");
            dict.Add("5", "Rutuja");
            dict.Add("6", "Bhargavi");
            dict.Add("7", "Sourabh");
            dict.Add("8", "Ajinkya");
            dict.Add("9", "Manasi");

            foreach (KeyValuePair<string, string> de in dict)
            {
                Console.WriteLine(" "+ de.Key + "     " + de.Value);
            }
            Console.ReadKey();
        }
    }
}
