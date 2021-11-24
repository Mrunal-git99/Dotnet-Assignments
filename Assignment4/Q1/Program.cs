using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverideFunction
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }

        public override string ToString()
        {
            return this.EmpId + " " + this.EmpName + " " + this.DeptName;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { EmpId = 1, EmpName = "Mrunal", DeptName = "Computer Science" };

            Console.WriteLine(emp.ToString());
            Console.ReadLine();
        }
    }
}
