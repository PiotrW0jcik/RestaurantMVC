using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using PiotrWojcik.Restaurant.Models;
using Table = PiotrWojcik.Restaurant.Models.Table;

namespace PiotrWojcik.Restaurant.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDishes(int id,string quanity)
        {
            int IdTable = (int)Session["table"];
            DishModel dishModel = new DishModel();
            if (Session[$"order{IdTable}"] == null)
            {
                List<Item> order = new List<Item>();
                order.Add(new Item { Dish = dishModel.find(id), Quantity=1 });
                Session[$"order{IdTable}"] = order;
            }
            else
            {
                List<Item> order = (List<Item>)Session[$"order{IdTable}"];
                int index = isExist(id);
                if (index != -1)
                {
                    order[index].Quantity++;
                }
                else
                {
                    order.Add(new Item { Dish = dishModel.find(id), Quantity = 1 });
                }

                Session[$"order{IdTable}"] = order;
            }

            return RedirectToAction("Index");
        }
        public ActionResult EditOrder(int id)
        {
            Session["table"] = id;
            return RedirectToAction("Index");
        }
        public ActionResult Bill()
        {
            return RedirectToAction("Bill");
        }

        public ActionResult Remove(int id)
        {
            List<Item> order = (List<Item>)Session[$"order{(int)Session["table"]}"];
            int index = isExist(id);
            order.RemoveAt(index);
            Session[$"order{(int)Session["table"]}"] = order;
            return RedirectToAction("Index");
        }
        public ActionResult RemoveAllOrder()
        {
            List<Item> order = (List<Item>)Session[$"order{(int)Session["table"]}"];

            order.Clear();
            return RedirectToAction("Index","Table");
        }

        private int isExist(int id)
        {
            int IdTable = (int)Session["table"];
            List<Item> order = (List<Item>)Session[$"order{IdTable}"];
            for (int i = 0; i < order.Count; i++)
                if (order[i].Dish.Id.Equals(id))
                    return i;
            return -1;
        }

    }
}
