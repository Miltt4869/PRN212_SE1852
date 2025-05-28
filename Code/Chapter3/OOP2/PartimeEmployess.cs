using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class PartimeEmployess:Employess
    {
        public int WorkingHour {  get; set; }
        public override double calSalary()
        {
            return 10000000*WorkingHour;
        }
    }
}
