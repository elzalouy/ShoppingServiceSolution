using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingService.SSS_DAO.SSS_Entities;
using ShoppingService.SSS_Repositories;
namespace ShoppingService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetProducts()
        {
            List<Product> ListOfProducts = new List<Product>();
            ListOfProducts =SSR_Products.GetAllProducts();
            return Json(ListOfProducts, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}