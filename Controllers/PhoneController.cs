using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            string[] products = { "Phone" };

            ViewData["products"] = products;

            
            ViewBag.Message = "Your phone description page.";
            return View();
        }

        public ActionResult PhoneList()
        {
            var phoneList = new List<Phone>{
                            new Phone() { PhoneId = "ID-1", PhoneName = "Landon's IPhone", Manufacturer = "Samsung", MSRP = 14, ScreenSize = 9},
                            new Phone() { PhoneId = "ID-2", PhoneName = "Aaliyah's IPhone", Manufacturer = "Sony", MSRP = 13, ScreenSize = 5},
                            new Phone() { PhoneId = "ID-3", PhoneName = "Keshia's IPhone", Manufacturer = "HTC", MSRP = 12, ScreenSize = 6},
                            new Phone() { PhoneId = "ID-3", PhoneName = "Melissa's IPhone", Manufacturer = "SOny", MSRP = 12, ScreenSize = 6}
                        };
            // Get the students from the database in the real application

            return View(phoneList);
        }
        public ActionResult Details(string product)
        {
            ViewBag.Message = "You have selected " + product;
            return View();


        }
    }
}

