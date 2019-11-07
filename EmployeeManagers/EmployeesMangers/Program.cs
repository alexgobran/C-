using EmployeesMangerLib;
using System;
using System.Collections.Generic;

namespace EmployeesMangers {
    public class Program {
       
        public static void Main(string[] args) {
            (new Program()).Run();
        }



        void Run() { 

            var emp1 = new Employee("Jeff Robert", "IT", 80000);
            var emp2 = new Employee("Bill Davis", "Sales", 65000);
            var emp3 = new Employee("Dan Green", "Janitor", 34000);

            var mgr1 = new Managers("No Name", "Maint Mannager", 55000,10);
            var mgr2 = new Managers("big Money", "Sales Manager", 150000,5);


            Console.WriteLine(mgr2.Print());


        var emps = new List<Employee>() { emp1, emp2, emp3, mgr1, mgr2 };
        foreach (var emp in emps) {
            Console.WriteLine(emp.Print());
        }


        }
    }
}
