using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interactors.UserInteractors;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.UserResponseInterfaces;
using VideoAdvertising.Common.Objects.ValidatorObjects.GeneralValidators;
using VideoAdvertising.Common.Objects.ValidatorObjects.UserValidators;
using VideoAdvertising.Tests.TestObjects;

namespace VideoAdvertising.Tests.Common.Interactors.UserInteractors
{
    [TestFixture]
    public class CreateUserInteractorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new CreateUserInteractor(new UserTestRepository(), new AlwaysPassValidator<IUser>(), new AlwaysPassValidator<ICreateUserRequest>()));
            }
        }

        [TestFixture]
        public class CreateUser
        { 
            private Mock<ICreateUserRequest> _requestMock;

            [SetUp]
            public void Before_Each_Test()
            {
                _requestMock = new Mock<ICreateUserRequest>();
                _requestMock.Setup(a => a.Email).Returns("abc@abc.com");
                _requestMock.Setup(a => a.Username).Returns("abcabc");

            }

            [Test]
            public void Is_Not_Null()
            {
                CreateUserInteractor target = new CreateUserInteractor(new UserTestRepository(), new AlwaysPassValidator<IUser>(), new AlwaysPassValidator<ICreateUserRequest>());
                Assert.IsNotNull(target.CreateUser(_requestMock.Object));
            }

            [Test]
            public void Adds_User_To_Repository()
            {
                UserTestRepository repository = new UserTestRepository();
                CreateUserInteractor target = new CreateUserInteractor(repository, new AlwaysPassValidator<IUser>(), new AlwaysPassValidator<ICreateUserRequest>());
                target.CreateUser(_requestMock.Object);
                Assert.IsTrue(repository.GetUserByEmail(_requestMock.Object.Email).Id != "");
            }

            [Test]
            public void Response_Contains_New_User()
            {
                UserTestRepository repository = new UserTestRepository();
                CreateUserInteractor target = new CreateUserInteractor(repository, new AlwaysPassValidator<IUser>(), new AlwaysPassValidator<ICreateUserRequest>());
                ICreateUserResponse response = target.CreateUser(_requestMock.Object);
                Assert.IsTrue(response.User.Id != string.Empty 
                    && response.User.Email == _requestMock.Object.Email 
                    && response.User.Username == _requestMock.Object.Username);
            }

            [Test]
            public void Does_Not_Insert_Duplicate_Emails()
            {
                UserTestRepository repository = new UserTestRepository();
                CreateUserInteractor target = new CreateUserInteractor(repository, new UserEmailDoesNotExistValidator(repository), new AlwaysPassValidator<ICreateUserRequest>());
                target.CreateUser(_requestMock.Object);
                ICreateUserResponse response2 = target.CreateUser(_requestMock.Object);
                Assert.IsFalse(response2.Successful);
            }
        }
    }
}