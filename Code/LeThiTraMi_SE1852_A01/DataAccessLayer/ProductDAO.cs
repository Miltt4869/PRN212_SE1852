using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public static class ProductDAO
    {
        private static readonly List<Product> Products = new List<Product>();

        static ProductDAO()
        {
            InitializeDataset();
        }

        private static void InitializeDataset()
        {
            if (!Products.Any())
            {
                Products.AddRange(new List<Product>
                {
                    new Product { ProductID = 1, ProductName = "Stin", CategoryID = 1, UnitPrice = 15000, UnitsInStock = 100, QuantityPerUnit = "10 chai", UnitsOnOrder = 20, ReorderLevel = 10, Discontinued = false },
                    new Product { ProductID = 2, ProductName = "7up", CategoryID = 1, UnitPrice = 55000, UnitsInStock = 50, QuantityPerUnit = "500g", UnitsOnOrder = 10, ReorderLevel = 5, Discontinued = false },
                    new Product { ProductID = 3, ProductName = "Hủ tíu", CategoryID = 2, UnitPrice = 25000, UnitsInStock = 80, QuantityPerUnit = "1 gói", UnitsOnOrder = 5, ReorderLevel = 15, Discontinued = false },
                    new Product { ProductID = 4, ProductName = "Bánh orio", CategoryID = 3, UnitPrice = 5000, UnitsInStock = 300, QuantityPerUnit = "5 bịch", UnitsOnOrder = 50, ReorderLevel = 50, Discontinued = false },
                    new Product { ProductID = 5, ProductName = "Cafe", CategoryID = 1, UnitPrice = 7000, UnitsInStock = 200, QuantityPerUnit = "500ml", UnitsOnOrder = 30, ReorderLevel = 40, Discontinued = false }
                });
            }
        }

        public static List<Product> GetAllProducts()
        {
            return Products;
        }

        public static Product? GetProductById(int id)
        {
            return Products.FirstOrDefault(p => p.ProductID == id);
        }

        public static void AddProduct(Product product)
        {
            product.ProductID = Products.Any() ? Products.Max(p => p.ProductID) + 1 : 1;
            Products.Add(product);
        }

        public static void UpdateProduct(Product product)
        {
            var existing = Products.FirstOrDefault(p => p.ProductID == product.ProductID);
            if (existing != null)
            {
                existing.ProductName = product.ProductName;
                existing.CategoryID = product.CategoryID;
                existing.UnitPrice = product.UnitPrice;
                existing.UnitsInStock = product.UnitsInStock;
                existing.QuantityPerUnit = product.QuantityPerUnit;
                existing.UnitsOnOrder = product.UnitsOnOrder;
                existing.ReorderLevel = product.ReorderLevel;
                existing.Discontinued = product.Discontinued;
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = Products.FirstOrDefault(p => p.ProductID == id);
            if (product != null)
            {
                Products.Remove(product);
            }
        }

        public static List<Product> SearchProducts(string keyword)
        {
            return Products
                .Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
