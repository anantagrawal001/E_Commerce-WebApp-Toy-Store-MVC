using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ecommerceG3.Connections;
using ecommerceG3.Models;

namespace ecommerceG3.Controllers
{
    public class userController : Controller
    {
        // GET: user
        [HttpGet]
        public ActionResult Index(string cat)
        {
            var result = CreateUser.ProductsView(cat);
            return View(result); 
        }
        [HttpGet]
        public ActionResult Create()
        {
            userdb u = new userdb();
            //CreateUser qwe = new CreateUser();
            return View(u);
        }
        [HttpPost]
        public ActionResult Create(userdb u)
        {
            CreateUser.CU(u);
            return View("Create");
        }
        public ActionResult Login(userlog u)
        {
            CreateUser.checku(u);
            return View();
        }
        public ActionResult OHistory()
        {
            var result = CreateUser.historyview();
            return View(result);
        }
    }
}