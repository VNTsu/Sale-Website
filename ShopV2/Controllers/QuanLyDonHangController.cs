using ShopV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopV2.Controllers
{
    public class QuanLyDonHangController : Controller
    {
        UserContext db = new UserContext();
        // GET: QuanLyDonHang
        public ActionResult Index(String id)
        {
            var model = db.Orders.Where(m => m.cusPhone == id).ToList();
            return View(model);
        }

        public ActionResult Update (String id)
        {
            var model = db.Orders.Where(m => m.orderID == id).SingleOrDefault();
            model.orderStatus = "1";
            db.SaveChanges();
            return RedirectToAction("Index", "QuanLyDonHang");
        }


    }
}