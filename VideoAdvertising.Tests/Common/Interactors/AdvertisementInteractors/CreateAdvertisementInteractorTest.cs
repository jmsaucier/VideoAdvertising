using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interactors.AdvertisementInteractors;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces.AdvertisementInteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequests;

namespace VideoAdvertising.Tests.Common.Interactors.AdvertisementInteractors
{
    [TestFixture]
    public class CreateAdvertisementInteractorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new CreateAdvertisementInteractor());
            }
        }

        [TestFixture]
        public class CreateAdvertisement
        {
            private CreateAdvertisementInteractor Target;

            [SetUp]
            public void Before_Each_Test()
            {
                Target = new CreateAdvertisementInteractor();
            }

            [Test]
            public void Is_Not_Null()
            {
                Mock<ICreateAdvertisementRequest> request = new Mock<ICreateAdvertisementRequest>();
                Assert.IsNotNull(Target.CreateAdvertisement(request.Object));
            }

            [Test]
            public void Advertisement_Name_Matches()
            {
                Mock<ICreateAdvertisementRequest> mockRequest = new Mock<ICreateAdvertisementRequest>();
                string targetName = "1";
                mockRequest.Setup(a => a.Name).Returns(targetName);
                
                Assert.IsTrue(Target.CreateAdvertisement(mockRequest.Object).Name == targetName);
            }
        }
    }
}