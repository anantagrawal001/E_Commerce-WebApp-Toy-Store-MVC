using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerceG3.Models
{
    public class Bill
    {
        public int order_ID { get; set; }
        public string phone_no { get; set; }
        public string prod_name { get; set; }
        public string Bil_Add { get; set; }
        public string shipp_Add { get; set; }
        public int Order_Amt { get; set; }
        public string Payment_mode { get; set; }
        public string delivery_date { get; set; }
    }
}