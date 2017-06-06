using System.Security.Cryptography;
using System.Text;
using VideoAdvertising.Common.Interfaces.SecurityInterfaces;

namespace VideoAdvertising.Common.Objects.SecurityObjects
{
    public class ProtectedDataStringEncryptor : IStringEncryptor
    {
        public IStringEncryptorResponse Encrypt(string data)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            byte[] entropy = new byte[10];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(entropy);
            }
            byte[] ret = ProtectedData.Protect(dataBytes, entropy, DataProtectionScope.CurrentUser);
            return new StringEncryptorResponseClass(ret, entropy);
        }
    }
}
