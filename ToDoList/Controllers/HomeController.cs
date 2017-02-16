using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.DAL;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private ToDoListContext db = new ToDoListContext();

        public ActionResult Index()
        {
            return View(db.TaskItems.ToList());
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
    }
}