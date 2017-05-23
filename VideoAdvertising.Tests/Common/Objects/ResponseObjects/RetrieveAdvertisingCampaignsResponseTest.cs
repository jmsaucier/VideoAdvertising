using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.ResponseObjects;

namespace VideoAdvertising.Tests.Common.Objects.ResponseObjects
{
    [TestFixture]
    public class RetrieveAdvertisingCampaignsResponseTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new RetrieveAdvertisingCampaignsResponse());
            }

            [Test]
            public void Contains_Same_Information()
            {
                Mock<IValidatorResponse> responseMock = new Mock<IValidatorResponse>();
                responseMock.Setup(a => a.Passed).Returns(true);
                responseMock.Setup(a => a.Messages).Returns(new List<string> { "1", "2" });
                RetrieveAdvertisingCampaignsResponse target = new RetrieveAdvertisingCampaignsResponse(responseMock.Object);
                Assert.IsNotNull(target.Successful && target.Messages.Count() == 2);
            }
        }
    }
}
