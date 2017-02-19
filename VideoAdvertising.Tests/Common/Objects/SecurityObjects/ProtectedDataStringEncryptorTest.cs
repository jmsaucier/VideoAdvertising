using NUnit.Framework;
using VideoAdvertising.Common.Objects.SecurityObjects;

namespace VideoAdvertising.Tests.Common.Objects.SecurityObjects
{
    [TestFixture]
    public class ProtectedDataStringEncryptorTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new ProtectedDataStringEncryptor());
            }
        }

        [TestFixture]
        public class Encrypt
        {
            private ProtectedDataStringEncryptor Target;

            [SetUp]
            public void Before_Each_Test()
            {
                Target = new ProtectedDataStringEncryptor();
            }

            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(Target.Encrypt(string.Empty));
            }

            [Test]
            public void Cipher_Bytes_Is_Not_Null()
            {
                Assert.IsNotNull(Target.Encrypt(string.Empty).CipherBytes);
            }

            [Test]
            public void Entropy_Is_Not_Null()
            {
                Assert.IsNotNull(Target.Encrypt(string.Empty).Entropy);
            }
        }
    }
}
