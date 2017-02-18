using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interactors.AdvertisementInteractors;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces.AdvertisementInteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisementResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;
using VideoAdvertising.Common.Objects.ValidatorObjects.GeneralValidators;
using VideoAdvertising.Common.Objects.ValidatorObjects.UserValidators;
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
                Assert.IsNotNull(new CreateAdvertisementInteractor(new AdvertisementTestRepository(), new UserIdExistsValidator(new UserTestRepository())));
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
                Target = new CreateAdvertisementInteractor(testRepository, new AlwaysPassValidator<IUser>());
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
                mockRequest.Setup(a => a.User).Returns(new UserTestRepository().GetById("1"));
                ICreateAdvertisementResponse response = Target.CreateAdvertisement(mockRequest.Object);
                Assert.IsTrue(testRepository.GetById(response.Advertisement.Id).Id != string.Empty);
            }

            [Test]
            public void Calls_User_Validator()
            {
                Mock<ICreateAdvertisementRequest> mockRequest = new Mock<ICreateAdvertisementRequest>();
                Mock<IUser> userMock = new Mock<IUser>();

                mockRequest.Setup(a => a.User).Returns(userMock.Object);
                TestValidatorWasCalled<IUser, AlwaysPassesValidatorResponse> userValidator = new TestValidatorWasCalled<IUser, AlwaysPassesValidatorResponse>();
                
                Target = new CreateAdvertisementInteractor(testRepository, userValidator);
                Target.CreateAdvertisement(mockRequest.Object);
                Assert.IsTrue(userValidator.WasCalled);
            }

            [Test]
            public void Passes_If_User_With_Id_Exists_When_Given_Id_Validator()
            {
                Mock<ICreateAdvertisementRequest> mockRequest = new Mock<ICreateAdvertisementRequest>();
                mockRequest.Setup(a => a.User).Returns(new UserTestRepository().GetById("1"));

                Target = new CreateAdvertisementInteractor(
                    new AdvertisementTestRepository(), 
                    new UserIdExistsValidator(
                        new UserTestRepository()
                    )
                );
                ICreateAdvertisementResponse response = Target.CreateAdvertisement(mockRequest.Object);
                Assert.IsTrue(response.Successful);
            }

            [Test]
            public void Fails_If_User_Id_Does_Not_Exist_When_Given_Id_Validator()
            {
                Mock<ICreateAdvertisementRequest> mockRequest = new Mock<ICreateAdvertisementRequest>();
                mockRequest.Setup(a => a.User).Returns(new UserTestRepository().GetById("11111"));

                Target = new CreateAdvertisementInteractor(
                    new AdvertisementTestRepository(),
                    new UserIdExistsValidator(
                        new UserTestRepository()
                    )
                );

                ICreateAdvertisementResponse response = Target.CreateAdvertisement(mockRequest.Object);
                Assert.IsFalse(response.Successful);
            }
        }
    }
}