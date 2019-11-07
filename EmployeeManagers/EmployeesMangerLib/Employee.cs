using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMangerLib {
    public class Employee {

        public string Name{get; set;}
        public string Job { get; set; }
        public decimal Salary { get; set; }

        public virtual string Print() {//POLYMORPHISM
            return $"{this.GetType().Name}:: Name: {Name}, Job: {Job}, Salary: {Salary.ToString("C")}";
            }



        public Employee(string name, string job, decimal salary) {
            Name = name;
            Job = job;
            Salary = salary;

        }



    }
}
