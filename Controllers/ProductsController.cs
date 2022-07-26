using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eclerx.Nursery.Models;

namespace Eclerx.Nursery.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var products = GetProducts();

            return View(products);
        }
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product{Id=1,TreeName="Mango Tree",SKU_No=20,Price=340} ,
                new Product{Id=2,TreeName="Orange Tree",SKU_No=30,Price=500},
                new Product{Id=3,TreeName="Rose Tree",SKU_No=70,Price=750} ,
                new Product{Id=4,TreeName="Grapes Tree",SKU_No=45,Price=840} ,
                new Product{Id=5,TreeName="Banana Tree",SKU_No=98,Price=740},
            };
        }
    }
}