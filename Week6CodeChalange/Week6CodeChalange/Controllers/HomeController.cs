using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6CodeChalange.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult About()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult Work()
        {
            return PartialView();
        }

        public ActionResult Careers()
        {
            return PartialView();
        }

        public ActionResult Contact()
        {
            return PartialView();
        }

    }
}
