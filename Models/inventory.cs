//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ecommerceG3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventory
    {
        public int Product_ID { get; set; }
        public int Stock { get; set; }
    
        public virtual product_db product_db { get; set; }
    }
}
