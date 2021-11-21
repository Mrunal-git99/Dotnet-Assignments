using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProperties
{
    class Employee
    {
        int empid;
        string name, desg;
        double salary;

        public int EmployeeID
        {
            get { return empid; }
            set { empid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Desg
        {
            get { return desg; }
            set { desg = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.EmployeeID = 100;
            emp.Name = "Harshal";
            emp.Desg = "Traine";
            emp.Salary = 40000;
            Console.WriteLine("Employee Details: {0},{1},{2},{3}", emp.EmployeeID, emp.Name, emp.Desg, emp.Salary);
            Console.ReadKey();
        }
    }
}
