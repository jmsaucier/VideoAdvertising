using System;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interactors;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.Tests.TestObjects;

namespace VideoAdvertising.Tests.Common.Interactors
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
                CreateAdvertisingCampaignInteractor target = new CreateAdvertisingCampaignInteractor(new AdvertisingCampaignTestRepository());
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

                CreateAdvertisingCampaignInteractor target = new CreateAdvertisingCampaignInteractor(new AdvertisingCampaignTestRepository());
                ICreateAdvertisingCampaignResponse response = target.CreateAdvertisingCampaign(mockCreateAdvertisingCampaignRequest.Object);
                Assert.IsNotNull(response);
            }
        }
    }

}
