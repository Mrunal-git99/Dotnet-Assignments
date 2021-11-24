using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsNonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            Console.WriteLine("Roll no   Names");
            hashtable.Add("1", "Mrunal");
            hashtable.Add("2", "Ayushi");
            hashtable.Add("3", "Kunal");
            hashtable.Add("4", "Akash");
            hashtable.Add("5", "Rutuja");
            hashtable.Add("6", "Bhargavi");
            hashtable.Add("7", "Sourabh");
            hashtable.Add("8", "Ajinkya");
            hashtable.Add("9", "Manasi");

            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine("  "+ de.Key+ "       " + de.Value);
            }
            Console.ReadKey();
        }
    }
}
