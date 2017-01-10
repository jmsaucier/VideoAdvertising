using NUnit.Framework;
using VideoAdvertising.Common.Objects.ValidatorObjects;
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

            }
        }
    }
}
