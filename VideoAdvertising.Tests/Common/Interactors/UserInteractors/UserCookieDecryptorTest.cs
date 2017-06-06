using NUnit.Framework;
using VideoAdvertising.Common.Interactors.UserInteractors;
using VideoAdvertising.Common.Objects.SecurityObjects;

namespace VideoAdvertising.Tests.Common.Interactors.UserInteractors
{
    [TestFixture]
    public class UserCookieDecryptorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new UserCookieDecryptor());
            }
        }

        [TestFixture]
        public class DecryptValue
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new UserCookieDecryptor().DecryptValue(string.Empty));
            }

            [Test]
            public void Returns_User_And_Data_Value()
            {
                string user = "user";
                string token = "token";
                LoginMemorizationModel model = new UserCookieDecryptor().DecryptValue(user + "|" + token); 
                Assert.IsTrue(model.User == user && model.LoginToken == token);
            }
        }
    }
}
