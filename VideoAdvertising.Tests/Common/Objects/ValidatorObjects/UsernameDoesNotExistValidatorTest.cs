using System.Linq;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ValidatorObjects;
using VideoAdvertising.Tests.TestObjects;

namespace VideoAdvertising.Tests.Common.Objects.ValidatorObjects
{
    [TestFixture]
    public class UsernameDoesNotExistValidatorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new UsernameDoesNotExistValidator(new UserTestRepository()));
            }
        }

        [TestFixture]
        public class Validate
        {
            [Test]
            public void Is_Not_Null()
            {
                UsernameDoesNotExistValidator target =
                    new UsernameDoesNotExistValidator(new UserTestRepository());

                Mock<IUser> userMock = new Mock<IUser>();
                userMock.Setup(a => a.Username).Returns("abc");

                Assert.IsNotNull(target.Validate(userMock.Object));
            }

            [Test]
            public void Null_Input_Fails()
            {
                UsernameDoesNotExistValidator target = new UsernameDoesNotExistValidator(new UserTestRepository());

                Assert.IsFalse(target.Validate(null).Passed);
            }

            [Test]
            public void Does_Not_Pass_On_Match()
            {
                UsernameDoesNotExistValidator target =
                    new UsernameDoesNotExistValidator(new UserTestRepository());

                Mock<IUser> userMock = new Mock<IUser>();
                userMock.Setup(a => a.Username).Returns("abc");

                Assert.IsFalse(target.Validate(userMock.Object).Passed);
            }

            [Test]
            public void Has_One_Message_On_Failure()
            {
                UsernameDoesNotExistValidator target =
                    new UsernameDoesNotExistValidator(new UserTestRepository());

                Mock<IUser> userMock = new Mock<IUser>();
                userMock.Setup(a => a.Username).Returns("abc");

                Assert.IsTrue(target.Validate(userMock.Object).Messages.Count() == 1);
            }

            [Test]
            public void Passes_On_No_Match()
            {
                UsernameDoesNotExistValidator target =
                    new UsernameDoesNotExistValidator(new UserTestRepository());

                Mock<IUser> userMock = new Mock<IUser>();
                userMock.Setup(a => a.Username).Returns("abc2");

                Assert.IsTrue(target.Validate(userMock.Object).Passed);
            }
        }
    }
}
