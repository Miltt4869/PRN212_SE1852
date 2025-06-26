using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Order
    {

        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public override string ToString()
        {
            return $"{OrderID} - Customer: {CustomerID}, Employee: {EmployeeID}, Date: {OrderDate:yyyy-MM-dd}";
        }
    }
}
