using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMVCApplication.Repository;

namespace SimpleMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        protected ProductRepository productRepository = new ProductRepository();

        public ActionResult Index()
        {
            var products = productRepository.GetAll();
            ViewBag.products = products;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Search)
        {
            var products = productRepository.SearchProduct(Search);
            ViewBag.products = products;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddProduct()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var categories = categoryRepository.GetAll();
            ViewBag.categories = categories;

            return View();
        }
    }
}