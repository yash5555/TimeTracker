using Microsoft.AspNetCore.Mvc;
using TimeTracking.Web.Controllers;

namespace TimeTracking.Web.Public.Controllers
{
    public class HomeController : TimeTrackingControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}