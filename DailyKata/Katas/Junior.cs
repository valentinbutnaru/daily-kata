using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyKata.Katas
{
    class Junior:Employee
    {
        public Junior(string n) : base(n) { }
        public override double GetSalary ()
        {
            return 100;
        }
    }
}
