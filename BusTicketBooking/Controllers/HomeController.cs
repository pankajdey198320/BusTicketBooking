using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusBookingTicket.Model;

namespace BusTicketBooking.Controllers
{
    public class HomeController : Controller
    {
        BusBookingTicketEntities context = new BusBookingTicketEntities();

        public ActionResult Index()
        {
            return View();
        }

        
        public JsonResult ShowCityNames(string strTerm)
        {
            var result = (from c in context.CityDetails
                          where c.CityName.ToLower().Contains(strTerm.ToLower())
                          select new { c.CityName }).Distinct();
                    

            return Json(result , JsonRequestBehavior.AllowGet);
        
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
