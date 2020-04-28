using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace PiotrWojcik.Restaurant.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Table Table { get; set; }
        public int TotalCost { get; set; }
        public List<Dish> dishes { get; set; }


    }
}