using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC_HM_2.Models;

namespace WebMVC_HM_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Custom(TextSettings model)
        {
            //TextSettings model = new TextSettings
            //{
            //    Text = Request.Form["Text"],
            //    Color = Request.Form["Color"],
            //    Size = Int32.Parse(Request.Form["SizeTextBox"])
            //};

            return new CustomText(model);
        }
    }
}