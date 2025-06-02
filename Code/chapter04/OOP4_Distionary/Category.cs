using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Distionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }

        public Category()
        {
            Products = new Dictionary<int, Product>();
        }

        //CRUD
        //Thêm mới 1 sản phẩm cho Category
        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id) == false)
            {
                Products.Add(p.Id, p);
            }
        }

        public void PrintsAllProduct()
        {
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p);
            }
        }

        // Lay chi tiet 1 doi tuong
        public Product GetProduct(int id) // kieeur soos tim khong thay tra ve -1
        {
            return null;
            return Products[id];
        }

        public Dictionary<int, Product>SortProduct()
        {
            return Products.OrderBy (item => item.Value.Price).ToDictionary<int, Product>();
        }

        public Dictionary<int, Product> Complexsort()
        {
            return Products
                .OrderByDescending(item => item.Value.Quantity)
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();

        }

        public void EditProduct(Product p)
        {
            if (Products.ContainsKey(p.Id) == false)
            {
                return;
            }
            else
            {
                //sua su du lieu ta o nho chua p.Id
                Products[p.Id] = p;
            }
        }

        // xoas
        public bool Removeproduct(int id)
        {
            if (Products.ContainsKey(id) == false)

            {
                return false;
            }
            return true;
        }

        /*
         * Xoas all san pham ban e trong quy 1 nam 2025
         * e: Ban chi dc 1 don hang 
         */

    }
}
