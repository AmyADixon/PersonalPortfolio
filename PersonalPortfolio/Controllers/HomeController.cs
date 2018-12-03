using PersonalPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalPortfolio.Controllers {
    public class HomeController : Controller {
        CommentContext _db = new CommentContext();
        /// <summary>
        /// FOR DYNAMIC LOAD ONLY: Produces an empty 
        /// full view to contain the website and bottom menu 
        /// bar options
        /// </summary>
        /// <returns></returns>
        public ActionResult Index() { 
            return View();
        }

        /// <summary>
        /// FOR HOME TAB ONLY: Produces
        /// an empty partial view so that a site user 
        /// can just visualize the background art 
        /// </summary>
        /// <returns></returns>
        public ActionResult Main() {
            return PartialView();
        }

        /// <summary>
        /// Produces a partial view with information
        /// about the site creator
        /// </summary>
        /// <returns></returns>
        public ActionResult About() {
            return PartialView();
        }

        /// <summary>
        /// Produces a partial view where a visitor can
        /// contact the site creator by leaving a comment
        /// or by sending an external message
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact() {
            /* Retrieve a list of all VisitorComment objects */
            List<VisitorComments> allComments = CommentDBHelper.getAllComments(_db);

            /* Pass them to a partial view to be displayed */
            return PartialView(allComments);
        }

        public ActionResult Create() {
            return PartialView();
        }

        /// <summary>
        /// Produces a partial view capable of adding a 
        /// comment to the DB
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VisitorComments vComment) {
            if (ModelState.IsValid) {
                CommentDBHelper.addComment(_db, vComment);

                return RedirectToAction("Contact"); // Will most likely load a new page; will need ajax
            }

            return PartialView(vComment);
        }
    }
}