using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ecommerceG3.Models;
using ecommerceG3.Controllers;

namespace ecommerceG3.Connections
{
    public class CreateUser
    {
        public static List<userdb> ShowRecord()
        {
            ecom_capestoneEntities3 db = new ecom_capestoneEntities3();
            var query = from p in db.userdbs
                        select p;
            var products = query.ToList();
            return products;
        }
        public static List<Billingdb> historyview()
        {
            ecom_capestoneEntities3 db = new ecom_capestoneEntities3();
            var query = from p in db.Billingdbs
                        select p;
            var products = query.ToList();
            return products;
        }
        public static List<product_db> ProductsView(string cat)
        {
            ecom_capestoneEntities3 db = new ecom_capestoneEntities3();
            var query = from p in db.product_db where p.Product_Cat==cat                       
                        select p;
            var products = query.ToList();
            return products;
        }
        public static List<cart> ShowCart()
        {
            ecom_capestoneEntities3 db = new ecom_capestoneEntities3();
            var query = from p in db.carts
                        select p;
            var rec = query.ToList();
            return rec;
        }
        public static List<inventory> showproduct()
        {
            ecom_capestoneEntities3 db = new ecom_capestoneEntities3();
            var query = from p in db.inventories
                        select p;
            var products = query.ToList();
            return products;
        }


        public static void CU(userdb udb)
        {
            ecom_capestoneEntities3 db = new ecom_capestoneEntities3();
            userdb User = new userdb();
            User.User_Name = udb.User_Name;
            User.Phone_Number = udb.Phone_Number;
            User.Address_line1 = udb.Address_line1;
            User.Address_line2 = udb.Address_line2;
            User.Email = udb.Email;
            User.Pincode = udb.Pincode;
            User.State = udb.State;
            User.u_pass = udb.u_pass;
            User.Gender = udb.Gender;
            db.userdbs.Add(User);
            db.SaveChanges();

        }
        public static void addP(product_db p)
        {
            ecom_capestoneEntities3 db = new ecom_capestoneEntities3();
            product_db pr = new product_db();
            pr.Product_Cat=p.Product_Cat;
            pr.Product_name=p.Product_name;
            pr.Product_ID=p.Product_ID;
            pr.Price=  p.Price;
            pr.Description=p.Description;
            pr.qty=p.qty;
            db.product_db.Add(pr);
            db.SaveChanges();
        }
        public static void EditRecord(String Phone_Number, userdb udb)
        {
            ecom_capestoneEntities3 db = new ecom_capestoneEntities3();
            var User = db.userdbs.FirstOrDefault(x => x.Phone_Number == Phone_Number);

            User.User_Name = udb.User_Name;
            //User.Phone_Number = udb.Phone_Number;
            User.Address_line1 = udb.Address_line1;
            User.Address_line2 = udb.Address_line2;
            User.Email = udb.Email;
            User.Pincode = udb.Pincode;
            User.State = udb.State;
            User.u_pass = udb.u_pass;
            User.Gender = udb.Gender;
            db.SaveChanges();
        }
        public static void checku(userlog u)
        {
            ecom_capestoneEntities3 db = new ecom_capestoneEntities3();
            var query = from p in db.userdbs
                        where p.Phone_Number == u.Phone_No && p.u_pass == u.password
                        select p;
            HomeController hd = new HomeController();
            hd.Index();
            
        }
    }
        



    
}