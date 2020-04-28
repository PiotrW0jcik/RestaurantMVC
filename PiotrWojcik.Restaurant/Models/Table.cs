using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiotrWojcik.Restaurant.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Order { get; set; }
        public Table(){}
     
    }
}