using System;
using System.Web.Mvc;
using NUnit.Framework;
using VideoAdvertising.Controllers;
using VideoAdvertising.CustomAspClasses;
using VideoAdvertising.Enums;

namespace VideoAdvertising.Tests.Web.CustomAspClasses
{
    [TestFixture]
    public class ControllerFactoryTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new ControllerFactory());
            }
        }

        [TestFixture]
        public class CreateController
        {
            public ControllerFactory Target;

            [SetUp]
            public void Before_Each_Test()
            {
                Target = new ControllerFactory();
            }

            [TestCase("Account", typeof(AccountController))]
            [TestCase("Callback", typeof(CallbackController))]
            [TestCase("Home", typeof(HomeController))]
            [TestCase("Manage", typeof(ManageController))]
            public void Returns_Correct_Controller(string controllerName, Type expectedControllerType)
            {
                IController controller = Target.CreateController(null, controllerName);
                Assert.IsTrue(controller.GetType() == expectedControllerType);
            }
        }
    }
}
