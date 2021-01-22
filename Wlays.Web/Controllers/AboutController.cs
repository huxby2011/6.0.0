using System.Web.Mvc;

namespace Wlays.Web.Controllers
{
    public class AboutController : WlaysControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}