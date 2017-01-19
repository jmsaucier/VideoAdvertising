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
    public class AlwaysPassValidatorTest
    {
        public class Constructor
        {
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new AlwaysPassValidator<IUser>());
            }
        }

        public class Validate
        {
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new AlwaysPassValidator<IUser>().Validate(null));
            }

            public void Is_AlwaysPassesValidatorResponse()
            {
                Assert.IsTrue(new AlwaysPassValidator<IUser>().Validate(null) is AlwaysPassesValidatorResponse);
            }
        }
    }
}
