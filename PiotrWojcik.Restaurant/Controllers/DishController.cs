using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PiotrWojcik.Restaurant.Models;

namespace PiotrWojcik.Restaurant.Controllers
{
    public class DishController : Controller
    {
        // GET: Dish
        public ActionResult Index()
        {
            
            DishModel dishModel = new DishModel();
            ViewBag.dishes = dishModel.findAll();
            return View();
        }
        public ActionResult AddOrderToTable(int id)
        {
            Session["table"] = id;
            DishModel dishModel = new DishModel();
            ViewBag.dishes = dishModel.findAll();
            return RedirectToAction("Index");
        }
        
    }
}