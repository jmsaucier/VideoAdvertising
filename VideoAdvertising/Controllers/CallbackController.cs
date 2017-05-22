using System.Web.Mvc;

namespace VideoAdvertising.Controllers
{
    public class CallbackController : Controller
    {
        // GET: Callback
        public ActionResult Index(string code, string state)
        { 
            return View();
        }
    }
}