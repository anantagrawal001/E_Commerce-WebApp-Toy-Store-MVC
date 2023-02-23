using ecommerceG3.Connections;
using ecommerceG3.Models;
using System.Web.Mvc;


namespace ecommerceG3.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Log()
        {
            return View();
        }
        public ActionResult Viewusers()
        {
            var result = CreateUser.ShowRecord();
            return View(result);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            product_db product_Db = new product_db();
            return View(product_Db);
        }
        [HttpPost]
        public ActionResult AddProduct(product_db p)
        {
            CreateUser.addP(p);
            return View();
        }
        public ActionResult inventory()
        {
            var res = CreateUser.showproduct();
            return View(res);
        }
        public ActionResult sales()
        {
            var result = CreateUser.historyview();
            return View(result);
        }
    }
}