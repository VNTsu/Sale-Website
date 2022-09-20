using ShopV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopV2.viewModel;

namespace ShopV2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Models.UserContext db = new Models.UserContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel log)
        {
            var user = db.Logins.Where(m => m.cusPhone.Equals(log.user)).ToList();

            if (user.Count() > 0)
            {
                if (user.SingleOrDefault().pass.Equals(log.pass))
                {
                    Session["user"] = user.SingleOrDefault().cusFullname;
                    Session["phone"] = user.SingleOrDefault().cusPhone;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Session["user"] = null;
                    ViewBag.LoginError = "Sai tài khoản hoặc mật khẩu.";
                    return View();
                }

            }
            return View();
        }
        public ActionResult Resgister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Resgister(Login cus)
        {
            if (ModelState.IsValid)
            {
                //cus.cusFullName = "aa";
                //cus.password = "123";
                //cus.cusPhone = "123";
                //cus.cusMail = "123@acd";
                //cus.cusAddress = "HN";
                db.Logins.Add(cus);
                db.SaveChanges();
                return RedirectToAction("Login", "Login");
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session["user"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}