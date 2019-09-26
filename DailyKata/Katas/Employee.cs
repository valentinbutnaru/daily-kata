using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyKata.Katas
{
    abstract class Employee
    {
        private string Name { get; set; }
        public Employee (string n)
        {
            Name = n;
        }
        abstract public double GetSalary();
    }
}
