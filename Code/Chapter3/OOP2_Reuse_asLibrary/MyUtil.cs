using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_Reuse_asLibrary
{
    public static class MyUtil
    {
        public static int TinhTuoi(this Employess emp)
        {
            return DateTime.Now.Year - emp.Birthday.Year + 1;
        }
    }
}
