using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutputCache.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration =3600 , VaryByParam ="id")]
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult RemoveCache(int id)
        {
            var url = Url.Action("Index", "Home", new { id = id });
            HttpResponse.RemoveOutputCacheItem(url);

            return Content(string.Format("Clear Output Cache by Url {0} Success!", url));
        }
    }
}