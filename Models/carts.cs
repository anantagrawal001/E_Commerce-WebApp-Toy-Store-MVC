using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerceG3.Models
{
    public class carts
    {
        public string Phone_no { get; set; }
        public string user_name { get; set; }
        public int Product_ID { get; set; }
        public int product_price { get; set; }
        public int qty { get; set; }
        public int final_pr { get; set; }
    }
}