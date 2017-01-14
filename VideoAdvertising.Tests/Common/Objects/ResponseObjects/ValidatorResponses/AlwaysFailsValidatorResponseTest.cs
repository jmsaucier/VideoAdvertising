using System.Linq;
using NUnit.Framework;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Tests.Common.Objects.ResponseObjects.ValidatorResponses
{
    [TestFixture]
    public class AlwaysFailsValidatorResponseTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new AlwaysFailsValidatorResponse());
            }
        }

        [TestFixture]
        public class Passed
        {
            [Test]
            public void Returns_False()
            {
                Assert.IsFalse((new AlwaysFailsValidatorResponse()).Passed);
            }
        }

        [TestFixture]
        public class Messages
        {
            [Test]
            public void Equals_Message()
            {
                Assert.IsTrue((new AlwaysFailsValidatorResponse()).Messages.ToList()[0] == "Always fails validator message.");
            }
        }

        [TestFixture]
        public class SystemFailure
        {
            [Test]
            public void Returns_False()
            {
                Assert.IsFalse((new AlwaysFailsValidatorResponse()).SystemFailure);
            }
        }
    }
}
