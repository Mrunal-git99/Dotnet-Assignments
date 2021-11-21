using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritance
{
    class Employee
    {
        int eno;
        String name, designation;
        public Employee(int eno, string name, string designation)
        {
            this.eno = eno;
            this.name = name;
            this.designation = designation;
        }

        public void PrintData()
        {
            Console.WriteLine("Emp No= " + eno + " Emp Name = " + name + " Designation= " + designation);
        }
    }

    class PermanentEmp : Employee
    {
        double basicsal, da, hra, GrossSalary;

        public PermanentEmp(int eno, string name, string designation, double basicsal) : base(eno, name, designation)
        {
            this.basicsal = basicsal;
        }

        public void CalculateSalary()
        {
            da = (basicsal * 30) / 100;
            hra = (basicsal * 50) / 100;
            GrossSalary = (basicsal + da + hra);
            Console.WriteLine("Gross Salary = " + GrossSalary);
        }
        public void PrintData()
        {
            base.PrintData();
            //Console.WriteLine(basicsal);
        }
    }

    class WagedEmp : Employee
    {
        double no_of_hour, hourlyamt, GrossSalary;
        public WagedEmp(int eno, string name, string designation, double no_of_hour, double hourlyamt) : base(eno, name, designation)
        {
            this.no_of_hour = no_of_hour;
            this.hourlyamt = hourlyamt;
        }

        public void CalculateSalary()
        {
            GrossSalary = no_of_hour * hourlyamt;
            Console.WriteLine("Gross Salary = " + GrossSalary);
        }
        public void PrintData()
        {
            base.PrintData();
            Console.WriteLine("Number of Working Hour= " + no_of_hour + " Amount Per Hour= " + hourlyamt);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmp emp1 = new PermanentEmp(101, "Suyush", "Manager", 20000);
            WagedEmp wep = new WagedEmp(102, "Ashish", "Salesman", 12, 1500);

            Console.WriteLine("Permanent Employee");
            emp1.PrintData();
            emp1.CalculateSalary();

            Console.WriteLine("Waged Employee");
            wep.PrintData();
            wep.CalculateSalary();
            Console.ReadKey();
        }
    }
}
