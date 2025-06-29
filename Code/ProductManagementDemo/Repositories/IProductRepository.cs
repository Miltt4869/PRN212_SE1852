using BusinessObjects;

namespace Repositories
{
    public interface IProductRepository
    {
        void SaveProduct(Product p);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
        List<Product> GetProducts();
        Product GetProductById(int id);
    }
}
