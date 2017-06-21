﻿using System.Configuration;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace VideoAdvertising
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerSetup controllerSetup = new ControllerSetup(ControllerBuilder.Current);
            controllerSetup.SetupApplication(ConfigurationManager.AppSettings);

            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
