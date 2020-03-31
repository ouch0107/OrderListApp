using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using interview.DAL;
using interview.Models;

namespace interview.Repositories
{
    public class ProductRepository
    {
        private MyContext db = new MyContext();

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public Product FindById(int id)
        {
            return db.Products.Where(p => p.ProductId == id).FirstOrDefault();
        }
    }
}