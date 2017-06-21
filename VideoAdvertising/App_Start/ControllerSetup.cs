using System.Collections.Specialized;
using System.Configuration;
using System.Web.Mvc;
using VideoAdvertising.CustomAspClasses;

namespace VideoAdvertising
{
    public class ControllerSetup
    {
        private readonly ControllerBuilder _controllerBuilder;

        public ControllerSetup(ControllerBuilder controllerBuilder)
        {
            _controllerBuilder = controllerBuilder;
        }

        public void SetupApplication(NameValueCollection applicationSettings)
        {
            ControllerFactory factory = new ControllerFactory();
            
            _controllerBuilder.SetControllerFactory(factory);
        }
    }
}