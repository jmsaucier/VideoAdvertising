using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using VideoAdvertising.Models;

namespace VideoAdvertising.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {

        public ActionResult Index()
        {
            return View(new IndexViewModel());
        }

        public ActionResult ChangePassword()
        {
            return View(new ChangePasswordViewModel());
        }

        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordViewModel viewModel)
        {
            return View(new ChangePasswordViewModel());
        }

        public ActionResult SetPassword()
        {
            return View(new SetPasswordViewModel());
        }

    }
}