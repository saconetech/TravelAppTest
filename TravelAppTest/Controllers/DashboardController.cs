using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelAppTest.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult JsonData()
        {
            StreamReader sr = new StreamReader(Server.MapPath("~/content/TravelData.json"));
            var jsondata = Convert.ToString(sr.ReadToEnd());
            //var jsondata = JsonConvert.DeserializeObject(sr.ReadToEnd());
            return Json(jsondata, JsonRequestBehavior.AllowGet);
        }
    }

    //internal class JsonConvert
    //{
    //    internal static object Deseializeobject(object p)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}