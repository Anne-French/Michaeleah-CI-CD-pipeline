using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLD521_FA2_Michaeleah_Anne_Murray.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Location()
        {
            return View();
        }

        public ActionResult Favourites()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult LatestNews()
        {
            return Redirect("https://www.webtoons.com/en/");
        }
    }
}