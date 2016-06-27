using System.Web.Mvc;
using HomeAutomationTest.Data;

namespace HomeAutomationTest.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult HouseData(string id)
        {
            var home = JsonReader.GetSingleHome(id);

            if (home == null)
            {
                return HttpNotFound();
            }

            return Json(home, JsonRequestBehavior.AllowGet);
        }
    }
}
