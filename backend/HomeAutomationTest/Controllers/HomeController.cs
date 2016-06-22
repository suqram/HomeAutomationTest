using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeAutomationTest.Models;

namespace HomeAutomationTest.Controllers
{
    public class HomeController : Controller
    {
        Home[] homes = new Home[] 
        {
            new Home { Id = "Hus1", Rooms = new Room[] 
            {
                new Room {Name = "Hall", Temperature = 21.3, Humidity = 70 },
                new Room {Name = "Kök", Temperature = 22.0, Humidity = 74 },
                new Room {Name = "Sovrum", Temperature = 19.5, Humidity = 69 }
            } },
            new Home { Id = "Hus2", Rooms = new Room[] 
            {
                new Room {Name = "Farstu", Temperature = -3, Humidity = 95 },
                new Room {Name = "Kök", Temperature = 22.0, Humidity = 74 },
                new Room {Name = "Vardagsrum", Temperature = 21.7, Humidity = 77 }
            } }
        };

        public ActionResult Data()
        {
            return Json(homes, JsonRequestBehavior.AllowGet);
        }

        //public ActionResult Data(string id)
        //{
        //    var home = homes.FirstOrDefault((h) => h.Id == id);
        //    if (home == null)
        //    {
        //        return  HttpNotFound();
        //    }

        //    return Json(home, JsonRequestBehavior.AllowGet);
        //}
    }
}
