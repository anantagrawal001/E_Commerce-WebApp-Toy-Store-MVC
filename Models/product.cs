using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerceG3.Models
{
    public class product
    {
        public string Product_name { get; set; }
        public int Product_ID { get; set; }
        public string Description { get; set; }
        public string Product_Cat { get; set; }
        public int Price { get; set; }
        public int qty { get; set; }
    }
}