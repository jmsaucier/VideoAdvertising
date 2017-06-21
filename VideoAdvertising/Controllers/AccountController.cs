using System;
using System.Web;
using System.Web.Mvc;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces.UserInteractorsInterfaces;
using VideoAdvertising.Models;

namespace VideoAdvertising.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public AccountController()
        {
        }

        public ActionResult Login()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel, string redirectUrl)
        {
            throw new NotImplementedException();
        }

    }
}