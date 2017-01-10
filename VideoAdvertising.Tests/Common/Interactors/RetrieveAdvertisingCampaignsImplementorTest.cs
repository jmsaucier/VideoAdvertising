using System.Collections;
using System.Collections.Generic;
using System.Web.UI;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.DataAccessInterfaces;
using VideoAdvertising.Common.Interactors;
using VideoAdvertising.Common.ObjectInterfaces;
using VideoAdvertising.Common.Objects;
using VideoAdvertising.Common.RequestInterfaces;
using VideoAdvertising.Tests.TestObjects;

namespace VideoAdvertising.Tests.Common.Interactors
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
                RetrieveAdvertisingCampaignsImplementor Target =
                    new RetrieveAdvertisingCampaignsImplementor(new AdvertisingCampaignTestRepository());
                Assert.NotNull(Target);
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

                RetrieveAdvertisingCampaignsImplementor Target = new RetrieveAdvertisingCampaignsImplementor(new AdvertisingCampaignTestRepository());
                var response = Target.GetAdvertisingCampaigns(requestMock.Object);
                Assert.IsNotNull(response);
            }
        }

    }
}
