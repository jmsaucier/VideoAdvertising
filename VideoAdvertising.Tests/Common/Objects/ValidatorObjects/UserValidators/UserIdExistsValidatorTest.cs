﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ValidatorObjects.UserValidators;
using VideoAdvertising.Tests.TestObjects;

namespace VideoAdvertising.Tests.Common.Objects.ValidatorObjects.UserValidators
{
    [TestFixture]
    public class UserIdExistsValidatorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new UserIdExistsValidator(new UserTestRepository()));
            }
        }

        [TestFixture]
        public class Validate
        {
            private UserIdExistsValidator Target;

            [SetUp]
            public void Before_Each_Test()
            {
                Target = new UserIdExistsValidator(new UserTestRepository());
            }

            [Test]
            public void Passes_On_User_Id_Exists()
            {
                Mock<IUser> userMock = new Mock<IUser>();
                userMock.Setup(a => a.Id).Returns("1");

                bool passed = Target.Validate(userMock.Object).Passed;

                Assert.True(passed);
            }

            [Test]
            public void Fails_On_User_Id_Exists()
            {
                Mock<IUser> userMock = new Mock<IUser>();
                userMock.Setup(a => a.Id).Returns("11111");

                bool passed = Target.Validate(userMock.Object).Passed;

                Assert.IsFalse(passed);
            }

        }
    }
}