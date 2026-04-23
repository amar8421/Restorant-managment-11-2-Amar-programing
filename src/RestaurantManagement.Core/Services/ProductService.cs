using RestaurantManagement.Core.Models;
using RestaurantManagement.Data;
using RestaurantManagement.Data.Repositories;
using System;
using System.Collections.Generic;

namespace RestaurantManagement.Core.Services
{
    /// <summary>
    /// Shërbimi për menaxhimin e produkteve
    /// </summary>
    public class ProductService
    {
        private ProductRepository _productRepository;

        public ProductService()
        {
            var context = new DatabaseContext();
            _productRepository = new ProductRepository(context);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProduct(int productId)
        {
            return _productRepository.GetById(productId);
        }

        public void AddProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductName))
                throw new ArgumentException("Emri i produktit nuk mund të jetë bosh");
            
            if (product.Price <= 0)
                throw new ArgumentException("Çmimi duhet të jetë më i madh se 0");
            
            product.IsActive = true;
            _productRepository.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductName))
                throw new ArgumentException("Emri i produktit nuk mund të jetë bosh");
            
            if (product.Price <= 0)
                throw new ArgumentException("Çmimi duhet të jetë më i madh se 0");
            
            _productRepository.Update(product);
        }

        public void DeleteProduct(int productId)
        {
            _productRepository.Delete(productId);
        }
    }
}
