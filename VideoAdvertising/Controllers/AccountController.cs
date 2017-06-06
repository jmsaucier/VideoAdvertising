using System.Web;
using System.Web.Mvc;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Models;

namespace VideoAdvertising.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly string _loginCookieName;

        public AccountController(IUserRepository userRepository, string loginCookieName)
        {
            _userRepository = userRepository;
            _loginCookieName = loginCookieName;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel, string redirectUrl)
        {
            HttpCookie cookie = Request.Cookies.Get(_loginCookieName);
            
            return View(loginViewModel);
        }
    }
}