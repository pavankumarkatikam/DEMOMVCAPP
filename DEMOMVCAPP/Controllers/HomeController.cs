using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMOMVCAPP.Controllers
{
    public class HomeController : Controller
    {
       
       ///ygasgashjashku
        //comment added
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Comment added
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        ////dsbhjdskjdkskj
        ///testpushing
        /// <summary>
        /// sdjhsdujhsdjhjksd
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
