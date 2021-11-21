using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Student
    {
        int marks;

        public Student(int marks)
        {
            this.marks = marks;
        }

        public static Student operator +(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks + b.marks;
            return res;
        }

        public static Student operator -(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks - b.marks;
            return (res);
        }

        public static Student operator *(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks * b.marks;
            return (res);
        }

        public static Student operator /(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks / b.marks;
            return (res);
        }
        public static bool operator ==(Student a, Student b)
        {
            bool status = false;
            if (a.marks == b.marks)
            {

                status = true;
                Console.WriteLine("Marks are Equal");
            }
            return status;
        }
        public static bool operator !=(Student a, Student b)
        {
            bool status = false;

            if (a.marks != b.marks)
            {

                status = true;
                Console.WriteLine("Marks are not equal");
            }
            return status;
        }
        public void PrintMarks()
        {
            Console.WriteLine(marks);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student(80);
            Student obj2 = new Student(80);

            Student address = obj1 + obj2;
            Console.WriteLine("Addition");
            address.PrintMarks();

            Student subres = obj1 - obj2;
            Console.WriteLine("Subtraction");
            subres.PrintMarks();

            Student mult = obj1 * obj2;
            Console.WriteLine("Multiplication");
            mult.PrintMarks();

            Student div = obj1 / obj2;
            Console.WriteLine("Division");
            div.PrintMarks();

            if (obj1 == obj2)
                Console.WriteLine("Marks are equal ");
            else
                Console.WriteLine("Marks are not equal ");


            Console.ReadKey();
        }
    }
}
