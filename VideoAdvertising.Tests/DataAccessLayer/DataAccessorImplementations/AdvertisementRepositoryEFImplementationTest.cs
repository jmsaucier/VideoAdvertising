using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VideoAdvertising.DataAccessLayer.DataAccessorImplementations;

namespace VideoAdvertising.Tests.DataAccessLayer.DataAccessorImplementations
{
    [TestFixture]
    public class AdvertisementRepositoryEFImplementationTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new AdvertisementRepositoryEFImplementation());
            }
        }

        [TestFixture]
        public class GetById
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new AdvertisementRepositoryEFImplementation().GetById("1"));
            }

            [Test]
            public void Returns_Expected_Value()
            {
                
            }
        }
        
    }
}
