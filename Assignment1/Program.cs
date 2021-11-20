using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        int empid;
        string name, desg;
        double salary;


        public void GetEmployee()
        {
            Console.WriteLine("Enter Employee Details id, name, designation, salary");
            empid = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            desg = Console.ReadLine();
            salary = Convert.ToDouble(Console.ReadLine());
        }
        public void PrintData()
        {
            Console.WriteLine("Emp ID: " + empid + " Emp Name: " + name + " Designation: " + desg + " Salary: " + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.GetEmployee();
            Console.WriteLine("Employee Details");
            emp.PrintData();


            Console.ReadKey();
        }
    }
}
