using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{

    abstract class Animal
    {
        public abstract void FoodHabits();
    }

    class Cornivorous : Animal
    {
        public override void FoodHabits()
        {
            Console.WriteLine("Animals eat only meet");
        }
    }
    class Herbivorous : Animal
    {
        public override void FoodHabits()
        {
            Console.WriteLine("Animals eat only plants");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Herbivorous h=new Herbivorous();
            h.FoodHabits();

            Cornivorous c= new Cornivorous();
            c.FoodHabits();

            Console.ReadKey();
        }
    }
}
