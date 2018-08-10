using BcseTestTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace BcseTestTask.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();

        public ActionResult Razor()
        {
            return View();
        }

        public ActionResult Ajax()
        {
            return View();
        }

        public ActionResult GetChart()
        {
            string label = "График зависимости цены от времени";
            var chart = new Chart(width: 800, height: 600)
                .AddTitle(label)
                .AddSeries(label, chartType: "Line",
                    xValue: db.Deals, xField: "Date",
                    yValues: db.Deals, yFields: "Price").
                    Write();
            return null;
        }

        public PartialViewResult GetTable()
        {
            var deals = db.Deals.ToList();
            return PartialView(deals);
        }

        public JsonResult GetDeals()
        {
            var deals = db.Deals.ToList();
            var returnValue = deals.Select(i => new { i.Id, Tool = i.Tool.Name, i.Price, i.Volume, i.Date, Seller = i.Seller.Name, Buyer = i.Buyer.Name });
            return Json(returnValue, JsonRequestBehavior.AllowGet);
        }
    }
}