using System;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interactors.AdvertisingCampaignInteractors;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisingCampaignResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;
using VideoAdvertising.Common.Objects.ValidatorObjects.GeneralValidators;
using VideoAdvertising.Tests.TestObjects;

namespace VideoAdvertising.Tests.Common.Interactors.AdvertisingCampaign
{
    [TestFixture]
    public class CreateAdvertisingCampaignInteractorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                CreateAdvertisingCampaignInteractor target = new CreateAdvertisingCampaignInteractor(new AdvertisingCampaignTestRepository(), new AlwaysPassValidator<IUser>(), new AlwaysPassValidator<ICreateAdvertisingCampaignRequest>());
                Assert.IsNotNull(target);
            }
        }

        [TestFixture]
        public class CreateAdvertisingCampaign
        {
            [Test]
            public void Is_Not_Null()
            {
                Mock<IUser> mockUser = new Mock<IUser>();
                mockUser.Setup(a => a.Email).Returns("abcd@xyz.com");
                mockUser.Setup(a => a.Username).Returns("test");
                mockUser.Setup(a => a.Id).Returns("1");

                Mock<ICreateAdvertisingCampaignRequest> mockCreateAdvertisingCampaignRequest = new Mock<ICreateAdvertisingCampaignRequest>();
                mockCreateAdvertisingCampaignRequest.Setup(a => a.User).Returns(mockUser.Object);
                mockCreateAdvertisingCampaignRequest.Setup(a => a.StartDate).Returns(new DateTime(2017, 1, 1));
                mockCreateAdvertisingCampaignRequest.Setup(a => a.EndDate).Returns(new DateTime(2017, 2, 1));
                mockCreateAdvertisingCampaignRequest.Setup(a => a.Budget).Returns(500.00);
                mockCreateAdvertisingCampaignRequest.Setup(a => a.Name).Returns("MyCampaign");

                CreateAdvertisingCampaignInteractor target = new CreateAdvertisingCampaignInteractor(new AdvertisingCampaignTestRepository(), new AlwaysPassValidator<IUser>(), new AlwaysPassValidator<ICreateAdvertisingCampaignRequest>());
                ICreateAdvertisingCampaignResponse response = target.CreateAdvertisingCampaign(mockCreateAdvertisingCampaignRequest.Object);
                Assert.IsNotNull(response);
            }

            [Test]
            public void User_Validator_Was_Called()
            {
                TestValidatorWasCalled<IUser, AlwaysFailsValidatorResponse> validator = new TestValidatorWasCalled<IUser, AlwaysFailsValidatorResponse>();
                CreateAdvertisingCampaignInteractor target = new CreateAdvertisingCampaignInteractor(new AdvertisingCampaignTestRepository(), validator, new AlwaysPassValidator<ICreateAdvertisingCampaignRequest>());
                Mock<ICreateAdvertisingCampaignRequest> mockCreateAdvertisingCampaignRequest = new Mock<ICreateAdvertisingCampaignRequest>();
                target.CreateAdvertisingCampaign(mockCreateAdvertisingCampaignRequest.Object);
                Assert.IsTrue(validator.WasCalled);
            }
            
            [Test]
            public void Request_Validator_Was_Called()
            {
                TestValidatorWasCalled<ICreateAdvertisingCampaignRequest, AlwaysFailsValidatorResponse> validator = new TestValidatorWasCalled<ICreateAdvertisingCampaignRequest, AlwaysFailsValidatorResponse>();
                CreateAdvertisingCampaignInteractor target = new CreateAdvertisingCampaignInteractor(new AdvertisingCampaignTestRepository(), new AlwaysPassValidator<IUser>(), validator);
                Mock<ICreateAdvertisingCampaignRequest> mockCreateAdvertisingCampaignRequest = new Mock<ICreateAdvertisingCampaignRequest>();
                target.CreateAdvertisingCampaign(mockCreateAdvertisingCampaignRequest.Object);
                Assert.IsTrue(validator.WasCalled);
            }


        }
    }

}
