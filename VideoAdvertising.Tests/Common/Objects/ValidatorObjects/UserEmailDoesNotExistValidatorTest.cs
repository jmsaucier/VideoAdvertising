using System.Linq;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ValidatorObjects;
using VideoAdvertising.Common.Objects.ValidatorObjects.UserValidators;
using VideoAdvertising.Tests.TestObjects;

namespace VideoAdvertising.Tests.Common.Objects.ValidatorObjects
{
    [TestFixture]
    public class UserEmailDoesNotExistValidatorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new UserEmailDoesNotExistValidator(new UserTestRepository()));
            }
        }

        [TestFixture]
        public class Validate
        {
            [Test]
            public void Is_Not_Null()
            {
                UserEmailDoesNotExistValidator target =
                    new UserEmailDoesNotExistValidator(new UserTestRepository());

                Mock<IUser> userMock = new Mock<IUser>();
                userMock.Setup(a => a.Email).Returns("abc1@xyz.com");

                Assert.IsNotNull(target.Validate(userMock.Object));
            }

            [Test]
            public void Null_Input_Fails()
            {
                UserEmailDoesNotExistValidator target = new UserEmailDoesNotExistValidator(new UserTestRepository());

                Assert.IsFalse(target.Validate(null).Passed);
            }

            [Test]
            public void Does_Not_Pass_On_Match()
            {
                UserEmailDoesNotExistValidator target =
                    new UserEmailDoesNotExistValidator(new UserTestRepository());

                Mock<IUser> userMock = new Mock<IUser>();
                userMock.Setup(a => a.Email).Returns("abc1@xyz.com");

                Assert.IsFalse(target.Validate(userMock.Object).Passed);
            }

            [Test]
            public void Has_One_Message_On_Failure()
            {
                UserEmailDoesNotExistValidator target =
                    new UserEmailDoesNotExistValidator(new UserTestRepository());

                Mock<IUser> userMock = new Mock<IUser>();
                userMock.Setup(a => a.Email).Returns("abc1@xyz.com");

                Assert.IsTrue(target.Validate(userMock.Object).Messages.Count() == 1);
            }

            [Test]
            public void Passes_On_No_Match()
            {
                UserEmailDoesNotExistValidator target =
                    new UserEmailDoesNotExistValidator(new UserTestRepository());

                Mock<IUser> userMock = new Mock<IUser>();
                userMock.Setup(a => a.Email).Returns("abc4@xyz.com");

                Assert.IsTrue(target.Validate(userMock.Object).Passed);
            }
        }
    }
}
