using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restful_test.Models;

namespace restful_test.Tests.Controllers
{
    [TestClass]
    public class ProductsConntection
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product product = new Product();
            product.ID = 1;
            product.Name = "Super man";
            product.Category = "Toy";
            product.Price = 1000;
            //ProductContext products = new ProductContext();
            //products.AddProduct(product);
            //products.FindProduct(1);
            
        }
    }
}
