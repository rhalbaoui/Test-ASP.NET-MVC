using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comic_bock_gallery.Controllers
{
    public class ComicBooksController:Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }

            return Content ("Hello from the comic books controller");
            
            //return "Hello from the comic books controller !!";
        }
    }
}