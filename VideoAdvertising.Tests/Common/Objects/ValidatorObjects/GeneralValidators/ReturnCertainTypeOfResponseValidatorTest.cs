using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;
using VideoAdvertising.Common.Objects.ValidatorObjects.GeneralValidators;

namespace VideoAdvertising.Tests.Common.Objects.ValidatorObjects.GeneralValidators
{
    [TestFixture]
    public class ReturnCertainTypeOfResponseValidatorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new ReturnCertainTypeOfResponseValidator<IUser, AlwaysPassesValidatorResponse>());
            }
        }

        [TestFixture]
        public class Validate
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new ReturnCertainTypeOfResponseValidator<IUser, AlwaysPassesValidatorResponse>().Validate(null));
            }

            [Test]
            public void Returns_Object_Of_The_Same_Type()
            {
                Assert.IsNotNull(new ReturnCertainTypeOfResponseValidator<IUser, AlwaysPassesValidatorResponse>().Validate(null) is AlwaysPassesValidatorResponse);
            }
        }
    }
}
