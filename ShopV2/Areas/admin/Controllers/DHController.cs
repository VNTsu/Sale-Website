using ShopV2.Areas.admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopV2.Areas.admin.Controllers
{
    public class DHController : Controller
    {
        AdminContext db = new AdminContext();
        // GET: admin/DH
        public ActionResult Index()
        {
            var model = db.Orders.ToList();
            return View(model);
        }
    }
}