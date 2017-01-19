using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Tests.Common.Objects.ResponseObjects.ValidatorResponses
{
    [TestFixture]
    public class SystemFailureValidatorResponseTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new SystemFailureValidatorResponse());
            }
        }

        [TestFixture]
        public class Passed
        {
            [Test]
            public void Returns_False()
            {
                Assert.IsFalse(new SystemFailureValidatorResponse().Passed);
            }
        }

        [TestFixture]
        public class Messages
        {
            [Test]
            public void Returns_False()
            {
                Assert.IsTrue(new SystemFailureValidatorResponse().Messages.ToList()[0] == "System failure.");
            }
        }

        [TestFixture]
        public class SystemFailure
        {
            [Test]
            public void Returns_True()
            {
                Assert.IsTrue(new SystemFailureValidatorResponse().SystemFailure);
            }
        }
    }
}
