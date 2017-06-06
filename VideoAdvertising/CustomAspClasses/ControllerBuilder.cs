using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using VideoAdvertising.Controllers;
using VideoAdvertising.DataAccessLayer.DataAccessorImplementations;
using VideoAdvertising.DataAccessLayer.DbContexts;
using VideoAdvertising.Enums;

namespace VideoAdvertising.CustomAspClasses
{
    public class ControllerBuilder : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            ControllerEnum controllerEnum = (ControllerEnum)Enum.Parse(typeof(ControllerEnum), controllerName);
            IController ret;
            switch (controllerEnum)
            {
                case ControllerEnum.Account:
                    ret = new AccountController(new UserRepositoryEFImplementation(new UserDbContext()), "elysay.com");
                    break;
                case ControllerEnum.Callback:
                    ret = new CallbackController();
                    break;
                case ControllerEnum.Home:
                    ret = new HomeController();
                    break;
                default:
                    ret = new ManageController();
                    break;
            }
            return ret;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            throw new System.NotImplementedException();
        }

        public void ReleaseController(IController controller)
        {
            throw new System.NotImplementedException();
        }
    }
}