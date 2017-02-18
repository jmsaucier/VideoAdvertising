using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interactors.AdvertisementInteractors;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces.AdvertisementInteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisementResponseInterfaces;
using VideoAdvertising.Tests.TestObjects;

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
                Assert.IsNotNull(new CreateAdvertisementInteractor(new AdvertisementTestRepository()));
            }
        }

        [TestFixture]
        public class CreateAdvertisement
        {
            private CreateAdvertisementInteractor Target;
            private IAdvertisementRepository testRepository;

            [SetUp]
            public void Before_Each_Test()
            {
                testRepository = new AdvertisementTestRepository();
                Target = new CreateAdvertisementInteractor(testRepository);
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
                
                Assert.IsTrue(Target.CreateAdvertisement(mockRequest.Object).Advertisement.Name == targetName);
            }

            [Test]
            public void Advertisement_Stored_In_DB()
            {
                Mock<ICreateAdvertisementRequest> mockRequest = new Mock<ICreateAdvertisementRequest>();
                mockRequest.Setup(a => a.Name).Returns("AAA");
                mockRequest.Setup(a => a.UserId).Returns("1");
                ICreateAdvertisementResponse response = Target.CreateAdvertisement(mockRequest.Object);
                Assert.IsTrue(testRepository.GetById(response.Advertisement.Id).Id != string.Empty);
            }
        }
    }
}