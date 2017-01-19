using System.Linq;
using NUnit.Framework;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Tests.Common.Objects.ResponseObjects.ValidatorResponses
{
    [TestFixture]
    public class AlwaysPassesValidatorResponseTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new AlwaysPassesValidatorResponse());
            }
        }

        [TestFixture]
        public class Passed
        {
            [Test]
            public void Always_Passes()
            {
                Assert.IsTrue(new AlwaysPassesValidatorResponse().Passed);
            }
        }

        [TestFixture]
        public class Messages
        {
            [Test]
            public void Returns_Certain_String()
            {
                Assert.IsTrue(new AlwaysPassesValidatorResponse().Messages.ToList()[0] == "Always passes validator response.");
            }
        }

        [TestFixture]
        public class SystemFailure
        {
            [Test]
            public void Returns_Certain_String()
            {
                Assert.IsFalse(new AlwaysPassesValidatorResponse().SystemFailure);
            }
        }
    }
}