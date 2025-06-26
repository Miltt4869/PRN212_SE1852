using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public override string ToString()
        {
            return $"Order {OrderID} - Product {ProductID} - {Quantity} x {UnitPrice:C} (Discount: {Discount * 100}%)";
        }
    }
}
