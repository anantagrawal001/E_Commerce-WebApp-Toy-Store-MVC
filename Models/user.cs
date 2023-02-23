using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerceG3.Models
{
    public class user
    {
        public string User_Name { get; set; }
        public string Phone_Number { get; set; }
        public string u_pass { get; set; }
        public string Address_line1 { get; set; }
        public string Address_line2 { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}