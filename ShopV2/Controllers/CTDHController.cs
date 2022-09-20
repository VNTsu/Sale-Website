using ShopV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopV2.Controllers
{
    public class CTDHController : Controller
    {
        UserContext db = new UserContext();
        // GET: CTDH
        public ActionResult Index(String id) 

        {
            var model = db.OrderDetails.Where(m => m.orderID == id).ToList();
            return View(model);
        }
    }
}