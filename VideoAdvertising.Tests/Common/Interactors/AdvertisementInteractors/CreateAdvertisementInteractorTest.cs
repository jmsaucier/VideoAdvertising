using NUnit.Framework;
using VideoAdvertising.Common.Interactors.AdvertisementInteractors;

namespace VideoAdvertising.Tests.Common.Interactors.AdvertisementInteractors
{
    [TestFixture]
    public class CreateAdvertisementInteractorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new CreateAdvertisementInteractor());
            }
        }
    }
}