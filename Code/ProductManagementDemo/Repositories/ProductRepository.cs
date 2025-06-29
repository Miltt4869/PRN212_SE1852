using System;
using System.Collections.Generic;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void SaveProduct(Product p) => ProductDAO.SaveProduct(p);
        public void DeleteProduct(Product product) => ProductDAO.DeleteProduct(product);

        public void UpdateProduct(Product product) => ProductDAO.UpdateProduct(product);
        public List<Product> GetProducts() => ProductDAO.GetProducts();


        public Product GetProductById(int id) => ProductDAO.GetProductById(id);
    }
}
