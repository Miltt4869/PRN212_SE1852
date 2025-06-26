using System.Collections.Generic;
using BusinessObjects;

namespace Repositories
{
    public interface IProductRepositories
    {

        List<Product> GetAllProducts();


        Product? GetProductById(int id);


        void AddProduct(Product product);


        void UpdateProduct(Product product);

        void DeleteProduct(int id);

        List<Product> SearchProducts(string keyword);
    }
}