using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlinkDashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            ViewData["tempVal1"] = FlinkController.Temp1;
            ViewData["tempVal2"] = FlinkController.Temp2;
            ViewData["tempVal3"] = FlinkController.Temp3;

            ViewData["humVal1"] = FlinkController.Hum1;
            ViewData["humVal2"] = FlinkController.Hum2;
            ViewData["humVal3"] = FlinkController.Hum3;

            return View();
        }

        public string Get(string id)
        {
            string valueApi = id.ToString();
            return "New Value 1 :" + valueApi;
        }
        public string Get2(string id)
        {
            string valueApi = id.ToString();
            return "New Value get 2 :" + valueApi;
        }
    }
}
