using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Programs
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }

        
 

        public static void getEmployees(List<Employee> employees)
        {
            var e1 = from emp in employees where emp.salary > 200000 select emp;
            foreach (Employee e in e1)
            {
                Console.WriteLine(e.Id + " " + e.Name + " " + e.salary);
            }

            var e2 = (from emp in employees select emp).GroupBy(x => x.Id).Where(g => g.Count() > 1);
            //Console.WriteLine(e2.ToString());
            //foreach (Employee e in e2)
            //{
            //    Console.WriteLine(e.Id + " " + e.Name + " " + e.salary);
            //}
        }
    }
}
