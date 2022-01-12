using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ProductManager
    {
        private readonly ApplicationDbContext _context;

        public ProductManager(ApplicationDbContext context)
        {
            _context = context;
        }


        public List<Product> GetProducts()
        {
            return _context.Products.ToList();

        }

        public List<Product> GetProductByPrice(decimal? minPrice, decimal? maxPrice)
        {

            var products = _context.Products.ToList();

            decimal productPrice = 0;
            foreach (var product in products)
            {
                if (product.Price > productPrice)
                {
                    productPrice = product.Price;
                }
            }


            if (minPrice == null)
                minPrice = 0;

            if (maxPrice == null)
                maxPrice = productPrice;

            return _context.Products.Where(x=>x.Price >= minPrice && x.Price <= maxPrice).ToList();
        }

        public List<Product> FilterProduct(int? categoryId, decimal? minPrice, decimal? maxPrice)
        {
            var products = _context.Products.ToList();

            decimal productPrice = 0;
            foreach (var product in products)
            {
                if (product.Price > productPrice)
                {
                    productPrice = product.Price;
                }

            }



            if (minPrice == null)
                minPrice = 0;

            if (maxPrice == null)
                maxPrice = productPrice;

          

            return _context.Products.Where(x => x.Price >= minPrice && x.Price <= maxPrice && x.CategoryId == categoryId).ToList();
        }




        public Product GetProduct(int? id)
        {
            return _context.Products.Find(id);

        }

        public List<Product> GetSameProducts(int? id, int? categoryId)
        {
            return _context.Products.Where(x => x.ID != id && x.CategoryId == categoryId).ToList();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
