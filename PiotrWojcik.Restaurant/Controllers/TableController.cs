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
    public class TableController : Controller
    {
        // GET: Table

        public ActionResult Index()
        {
            TableModel tableModel = new TableModel();
            ViewBag.tables = tableModel.findAll();
            return View();
        }
    }
}