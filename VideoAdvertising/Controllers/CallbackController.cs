using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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