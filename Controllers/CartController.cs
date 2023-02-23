using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ecommerceG3.Connections;

public class CartController : Controller
{
    // GET: Cart
    public ActionResult Index()
    {
        var cart_rec = CreateUser.ShowCart();
        return View(cart_rec); 
    }

    public ActionResult Address()
    {
        
        return View();
    }

}