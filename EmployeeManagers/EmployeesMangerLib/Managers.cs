using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMangerLib {
     public class Managers : Employee {



        public int TeamSize { get; set; } = 0;

        public override string Print() {
            return base.Print() + $", Team Size: {TeamSize}";
        }

        public Managers(string name, string job, decimal salary, int teamsize)
            :base(name, job, salary) {
            this.TeamSize = teamsize; 
        }
    }
}
