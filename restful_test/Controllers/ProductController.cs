using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using restful_test.Models;

namespace restful_test.Controllers
{
    public class ProductController : ApiController
    {

        public static Lazy<List<Product>> products = new Lazy<List<Product>>();
        public static int PageLoadFlag = 1;
        public static int ProductID = 4;

        public ProductController()
        {
            if (PageLoadFlag == 1) //use this only for first time page load
            {
                //Three product added to display the data
                products.Value.Add(new Product { ID = 1, Name = "bus", Category = "Toy", Price = 200.12M });
                products.Value.Add(new Product { ID = 2, Name = "Car", Category = "Toy", Price = 300 });
                products.Value.Add(new Product { ID = 3, Name = "robot", Category = "Toy", Price = 3000 });
                PageLoadFlag++;
            }
        }

        // GET api/product
        public List<Product> GetAllProducts() //get method
        {
            //Instedd of static variable you can use database resource to get the data and return to API
            return products.Value; //return all the product list data
        }

        public void ProductAdd(Product product) //post method
        {
            product.ID = ProductID;
            products.Value.Add(product); //add the post product data to the product list
            ProductID++;
            //instead of adding product data to the static product list you can save data to the database.
        }

        /*
        //
        // GET: /Product/
        public ActionResult Index()
        {
            return View();
        }
         * 
         */
	}
}