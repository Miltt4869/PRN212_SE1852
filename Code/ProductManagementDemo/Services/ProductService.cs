﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iProductRepository;

        public ProductService()
        {
            iProductRepository = new ProductRepository();
        }

        public void SaveProduct(Product p)
        {
            iProductRepository.SaveProduct(p);
        }

        public void DeleteProduct(Product product)
        {
            iProductRepository.DeleteProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            iProductRepository.UpdateProduct(product);
        }

        public List<Product> GetProducts()
        {
            return iProductRepository.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return iProductRepository.GetProductById(id);
        }
    }
}