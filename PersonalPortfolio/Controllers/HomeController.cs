using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalPortfolio.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() { // Always a full view, info will instead be injected into it
            return View();
        }

        public ActionResult About() {
            return PartialView();
        }

        public ActionResult Contact() {
            return PartialView();
        }
    }
}