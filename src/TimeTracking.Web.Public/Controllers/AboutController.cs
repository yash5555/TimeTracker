using Microsoft.AspNetCore.Mvc;
using TimeTracking.Web.Controllers;

namespace TimeTracking.Web.Public.Controllers
{
    public class AboutController : TimeTrackingControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}