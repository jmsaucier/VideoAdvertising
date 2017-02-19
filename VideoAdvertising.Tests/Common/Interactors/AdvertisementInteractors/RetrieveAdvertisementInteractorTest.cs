using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interactors.AdvertisementInteractors;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisementResponseInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;
using VideoAdvertising.Common.Objects.ValidatorObjects.GeneralValidators;
using VideoAdvertising.Common.Objects.ValidatorObjects.UserValidators;
using VideoAdvertising.Tests.TestObjects;

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
                Assert.IsNotNull(new RetrieveAdvertisementInteractor(new AdvertisementTestRepository(), new AlwaysPassValidator<IUser>()));
            }
        }

        [TestFixture]
        public class RetrieveAdvertisement
        {
            private RetrieveAdvertisementInteractor Target;

            [SetUp]
            public void Before_Each_Test()
            {
                Target = new RetrieveAdvertisementInteractor(new AdvertisementTestRepository(), new AlwaysPassValidator<IUser>());
            }

            [Test]
            public void Is_Not_Null()
            {
                Mock<IRetrieveAdvertisementRequest> requestMock = new Mock<IRetrieveAdvertisementRequest>();
                Assert.IsNotNull(Target.RetrieveAdvertisement(requestMock.Object));
            }

            [Test]
            public void Requested_Id_Matches()
            {
                Mock<IRetrieveAdvertisementRequest> requestMock = new Mock<IRetrieveAdvertisementRequest>();
                requestMock.Setup(a => a.Id).Returns("1");
                Assert.IsTrue(Target.RetrieveAdvertisement(requestMock.Object).Advertisement.Id == "1");
            }

            [Test]
            public void Returns_Expected_Advertisement()
            {
                string targetId = "1";
                Mock<IRetrieveAdvertisementRequest> requestMock = new Mock<IRetrieveAdvertisementRequest>();
                requestMock.Setup(a => a.Id).Returns(targetId);
                IAdvertisement expectedAdvertisement = new AdvertisementTestRepository().GetById(targetId);
                IRetrieveAdvertisementResponse response = Target.RetrieveAdvertisement(requestMock.Object);
                Assert.IsTrue(expectedAdvertisement.Id == response.Advertisement.Id
                    && expectedAdvertisement.User.Id == response.Advertisement.User.Id
                    && expectedAdvertisement.Name == response.Advertisement.Name);
            }

            [Test]
            public void Validates_Processes_User_Validation()
            {
                IAdvertisementRepository advertisementRepository = new AdvertisementTestRepository();
                TestValidatorWasCalled<IUser, AlwaysPassesValidatorResponse> userValidator = new TestValidatorWasCalled<IUser, AlwaysPassesValidatorResponse>(); 
                Mock<IRetrieveAdvertisementRequest> requestMock = new Mock<IRetrieveAdvertisementRequest>();
                
                RetrieveAdvertisementInteractor targetInteractor = new RetrieveAdvertisementInteractor(advertisementRepository, userValidator);
                targetInteractor.RetrieveAdvertisement(requestMock.Object);
                Assert.IsTrue(userValidator.WasCalled);
            }

            [Test]
            public void Passes_If_Users_Match()
            {
                IAdvertisementRepository advertisementRepository = new AdvertisementTestRepository();
                UserObjectsMatchValidator userValidator = new UserObjectsMatchValidator(new UserTestRepository().GetById("1"));
                Mock<IRetrieveAdvertisementRequest> requestMock = new Mock<IRetrieveAdvertisementRequest>();
                requestMock.Setup(a => a.Id).Returns("1");

                RetrieveAdvertisementInteractor targetInteractor = new RetrieveAdvertisementInteractor(advertisementRepository, userValidator);
                IRetrieveAdvertisementResponse response = targetInteractor.RetrieveAdvertisement(requestMock.Object);
                Assert.IsTrue(response.Successful);    
            }

            [Test]
            public void Fails_If_Users_Do_Not_Match()
            {
                IAdvertisementRepository advertisementRepository = new AdvertisementTestRepository();
                UserObjectsMatchValidator userValidator = new UserObjectsMatchValidator(new UserTestRepository().GetById("2"));
                Mock<IRetrieveAdvertisementRequest> requestMock = new Mock<IRetrieveAdvertisementRequest>();
                requestMock.Setup(a => a.Id).Returns("1");

                RetrieveAdvertisementInteractor targetInteractor = new RetrieveAdvertisementInteractor(advertisementRepository, userValidator);
                IRetrieveAdvertisementResponse response = targetInteractor.RetrieveAdvertisement(requestMock.Object);
                Assert.IsFalse(response.Successful);
            }
        }
    }
}
