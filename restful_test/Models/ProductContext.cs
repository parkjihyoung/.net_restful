using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace restful_test.Models
{


    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductContext") { }

        public DbSet<Product> Products { get; set; }
        /*
        public void AddProduct(Product product)
        {

            using (var context = new ProductContext())
            {

                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public Product FindProduct(int key)
        {

            using (var context = new ProductContext())
            {
                return context.Products.Find(key);
            }
        }
         * */
    }
}