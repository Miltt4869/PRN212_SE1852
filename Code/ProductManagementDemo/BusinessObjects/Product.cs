﻿namespace BusinessObjects
{
    public class Product
    {
        //public Product() { }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public short? UnitInStock { get; set; }
        public decimal? UnitPrice { get; set; }
        public virtual Category Category { get; set; }

        public Product(int id, string name, int catId,
                  short unitInStock, decimal price)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.CategoryId = catId;
            this.UnitInStock = unitInStock;
            this.UnitPrice = price;
        }

        public Product()
        {
        }
    }
}