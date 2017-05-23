using System;
using System.Linq;
using Moq;
using NUnit.Framework;

using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisingCampaignRequestInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ValidatorObjects.GeneralValidators;
using VideoAdvertising.Common.Objects.ValidatorObjects.RequestValidators;

namespace VideoAdvertising.Tests.Common.Objects.ValidatorObjects.RequestValidators
{
    [TestFixture]
    public class CreateAdvertisingRequestValidatorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new CreateAdvertisingRequestValidator(new AlwaysPassValidator<IUser>()));
            }
        }

        [TestFixture]
        public class Validate
        {
            [Test]
            public void Is_Not_Null()
            {
                Mock<ICreateAdvertisingCampaignRequest> requestMock = new Mock<ICreateAdvertisingCampaignRequest>();
                Assert.IsNotNull(new CreateAdvertisingRequestValidator(new AlwaysPassValidator<IUser>()).Validate(requestMock.Object));
            }

            [Test]
            public void Calls_User_Validator()
            {
                Mock<ICreateAdvertisingCampaignRequest> requestMock = new Mock<ICreateAdvertisingCampaignRequest>();
                requestMock.Setup(a => a.Name).Returns("test");
                Assert.IsTrue(new CreateAdvertisingRequestValidator(new AlwaysPassValidator<IUser>()).Validate(requestMock.Object).Messages.Contains("Always passes validator response."));
            }

            [Test]
            public void Start_Date_Less_Than_End_Date_Fails()
            {
                Mock<ICreateAdvertisingCampaignRequest> requestMock = new Mock<ICreateAdvertisingCampaignRequest>();
                requestMock.Setup(a => a.Name).Returns("test");
                requestMock.Setup(a => a.StartDate).Returns(new DateTime(2017, 1, 2));
                requestMock.Setup(a => a.EndDate).Returns(new DateTime(2017, 1, 1));
                IValidatorResponse response = new CreateAdvertisingRequestValidator(new AlwaysPassValidator<IUser>())
                    .Validate(requestMock.Object);
                Assert.IsTrue(response.Messages.Contains("Dates are invalid."));
            }

            [Test]
            public void Start_Date_Min_Value_Fails()
            {
                Mock<ICreateAdvertisingCampaignRequest> requestMock = new Mock<ICreateAdvertisingCampaignRequest>();
                requestMock.Setup(a => a.Name).Returns("test");
                requestMock.Setup(a => a.StartDate).Returns(DateTime.MinValue);
                IValidatorResponse response = new CreateAdvertisingRequestValidator(new AlwaysPassValidator<IUser>())
                    .Validate(requestMock.Object);
                Assert.IsTrue(response.Messages.Contains("Start date is invalid."));
            }

            [Test]
            public void Negative_Budget_Fails()
            {
                Mock<ICreateAdvertisingCampaignRequest> requestMock = new Mock<ICreateAdvertisingCampaignRequest>();
                requestMock.Setup(a => a.Name).Returns("test");
                requestMock.Setup(a => a.StartDate).Returns(new DateTime(2017, 1, 1));
                requestMock.Setup(a => a.EndDate).Returns(new DateTime(2017, 1, 2));
                requestMock.Setup(a => a.Budget).Returns(-1);
                IValidatorResponse response = new CreateAdvertisingRequestValidator(new AlwaysPassValidator<IUser>())
                    .Validate(requestMock.Object);
                Assert.IsTrue(response.Messages.Contains("Budget is less than zero."));
            }

            [Test]
            public void Valid_Input_Passes()
            {
                Mock<ICreateAdvertisingCampaignRequest> requestMock = new Mock<ICreateAdvertisingCampaignRequest>();
                requestMock.Setup(a => a.Name).Returns("test");
                requestMock.Setup(a => a.StartDate).Returns(new DateTime(2017, 1, 1));
                requestMock.Setup(a => a.EndDate).Returns(new DateTime(2017, 1, 2));
                requestMock.Setup(a => a.Budget).Returns(1);
                IValidatorResponse response = new CreateAdvertisingRequestValidator(new AlwaysPassValidator<IUser>())
                    .Validate(requestMock.Object);
                Assert.IsTrue(response.Passed);
                
            }
        }
    }
}
