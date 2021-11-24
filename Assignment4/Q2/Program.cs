using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeListGeneric
{
    class Employee
    {
        public int id;
        public string name;
        public string department;
        public double salary;

        public int  Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
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
            List<Employee> emplist = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.Name = "John";
            emp1.Department = "IT";
            emp1.Salary = 100000;
            emplist.Add(emp1);

            Employee emp2 = new Employee();
            emp2.Id = 2;
            emp2.Name = "Alex";
            emp2.Department = "Slaes";
            emp2.Salary = 80000;
            emplist.Add(emp2);

            Employee emp3 = new Employee();
            emp3.Id = 3;
            emp3.Name = "Joey";
            emp3.Department = "Marketing";
            emp3.Salary = 50000;
            emplist.Add(emp3);

           foreach (Employee emp in emplist)
            {
                Console.WriteLine(emp.Id);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Department);
                Console.WriteLine(emp.Salary);
            }
            Console.ReadKey();
        }
    }
}
