using PersonalPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalPortfolio.Controllers {
    public class HomeController : Controller {
        CommentContext _db = new CommentContext();

        public ActionResult Index() { 
            return View();
        }

        public ActionResult Main() {
            return PartialView();
        }

        public ActionResult About() {
            return PartialView();
        }

        public ActionResult Contact() {
            /* Retrieve a list of all VisitorComment objects */
            List<VisitorComments> allComments = CommentDBHelper.getAllComments(_db);

            /* Pass them to a partial view to be displayed */
            return PartialView(allComments);
        }

        [HttpPost]
        public ActionResult Create() {
            return PartialView();
        }
    }
}