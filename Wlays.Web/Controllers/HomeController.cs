using System.Web.Mvc;

namespace Wlays.Web.Controllers
{
    public class HomeController : WlaysControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}