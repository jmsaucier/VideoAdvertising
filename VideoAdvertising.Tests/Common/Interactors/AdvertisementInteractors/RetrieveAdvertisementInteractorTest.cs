using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interactors.AdvertisementInteractors;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequestInterfaces;

namespace VideoAdvertising.Tests.Common.Interactors.AdvertisementInteractors
{
    [TestFixture]
    public class RetrieveAdvertisementInteractorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new RetrieveAdvertisementInteractor());
            }
        }

        [TestFixture]
        public class RetrieveAdvertisement
        {
            private RetrieveAdvertisementInteractor Target;

            [SetUp]
            public void Before_Each_Test()
            {
                Target = new RetrieveAdvertisementInteractor();
            }

            [Test]
            public void Is_Not_Null()
            {
                Mock<IRetrieveAdvertisementRequest> requestMock = new Mock<IRetrieveAdvertisementRequest>();
                Assert.IsNotNull(Target.RetrieveAdvertisement(requestMock.Object));
            }
        }
    }
}
