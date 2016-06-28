using System.Web.Mvc;
using HomeAutomationTest.Data;

namespace HomeAutomationTest.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// Get House-data for one building
        /// </summary>
        /// <param name="id">String containing building id (see DataFile.json)</param>
        /// <returns>Json of house-data.</returns>
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
