using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class FulltimeEmployess: Employess // kees thua extend huongwr heets chir cos private laf ko dc
    {
        public override double calSalary()
        {
            return base.calSalary() + 5000000;
        }
    }
}
