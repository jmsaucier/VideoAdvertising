using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;
using VideoAdvertising.Common.Objects.ValidatorObjects.UserValidators;
using VideoAdvertising.Tests.TestObjects;

namespace VideoAdvertising.Tests.Common.Objects.ValidatorObjects.UserValidators
{
    [TestFixture]
    public class UserObjectsMatchValidatorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Mock<IUser> userMock = new Mock<IUser>();
                Assert.IsNotNull(new UserObjectsMatchValidator(userMock.Object));
            }
        }

        [TestFixture]
        public class Validate
        {
            private UserObjectsMatchValidator Target;
            private UserTestRepository userTestRepository;
            [SetUp]
            public void Before_Each_Test()
            {
                userTestRepository = new UserTestRepository();
                
                Target = new UserObjectsMatchValidator(userTestRepository.GetById("1"));
            }

            [Test]
            public void Is_Not_Null()
            {
                Mock<IUser> userMock = new Mock<IUser>();
                Assert.IsNotNull(Target.Validate(userMock.Object));   
            }

            [Test]
            public void Null_Input_Is_System_Failure()
            {
                Assert.IsTrue(typeof(SystemFailureValidatorResponse) == Target.Validate(null).GetType());
            }

            [Test]
            public void Successful_When_Users_Match()
            {
                IUser user = userTestRepository.GetById("1");
                Assert.IsTrue(Target.Validate(user).Passed);
            }

            [Test]
            public void Failure_When_Users_Do_Not_Match()
            {
                IUser user = userTestRepository.GetById("2");
                Assert.IsFalse(Target.Validate(user).Passed);
            }
        }
    }
}
