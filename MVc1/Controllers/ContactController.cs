using MVc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVc1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            //ContactViewModel obj = new ContactViewModel();
            //obj.FName = "SUMESH";
            //obj.LName = "Nammilikkara";
            ContactViewModel obj1 = new ContactViewModel()
            {
                FName = "Vedha",
                LName = "Sumesh"
            };

             

            return View(obj1);
        }
    }
}