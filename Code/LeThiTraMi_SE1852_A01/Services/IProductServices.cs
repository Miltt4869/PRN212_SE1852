using System.Collections.Generic;
using BusinessObjects;

namespace Services
{
    public interface IProductServices
    {
       
        List<Product> GetAllProducts();

        Product? GetProductById(int id);

 
        void AddProduct(Product product);


        void UpdateProduct(Product product);

        void DeleteProduct(int id);


        List<Product> SearchProducts(string keyword);
    }
}