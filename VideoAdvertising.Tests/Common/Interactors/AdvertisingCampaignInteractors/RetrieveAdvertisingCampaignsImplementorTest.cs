using System.Collections;
using System.Collections.Generic;
using System.Web.UI;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interactors.AdvertisingCampaignInteractors;
using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisingCampaignRequests;
using VideoAdvertising.Common.Objects;
using VideoAdvertising.Tests.TestObjects;

namespace VideoAdvertising.Tests.Common.Interactors.AdvertisingCampaignInteractors
{
    [TestFixture]
    public class RetrieveAdvertisingCampaignsImplementorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                RetrieveAdvertisingCampaignsImplementor target =
                    new RetrieveAdvertisingCampaignsImplementor(new AdvertisingCampaignTestRepository());
                Assert.NotNull(target);
            }
        }

        [TestFixture]
        public class GetAdvertisingCampaigns
        {
            [Test]
            public void Is_Not_Null()
            {
                var requestMock = new Mock<IRetrieveAdvertisingCampaignRequest>();
                requestMock.Setup(a => a.UserId).Returns("1");

                RetrieveAdvertisingCampaignsImplementor target = new RetrieveAdvertisingCampaignsImplementor(new AdvertisingCampaignTestRepository());
                var response = target.GetAdvertisingCampaigns(requestMock.Object);
                Assert.IsNotNull(response);
            }

        }

    }
}
