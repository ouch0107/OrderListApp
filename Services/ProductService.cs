using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using interview.Repositories;
using interview.Models;

namespace interview.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            var productRepository = new ProductRepository();
            return productRepository.GetProducts();
        }
        public Product FindById(int id)
        {
            var productRepository = new ProductRepository();
            return productRepository.FindById(id);
        }
    }
}