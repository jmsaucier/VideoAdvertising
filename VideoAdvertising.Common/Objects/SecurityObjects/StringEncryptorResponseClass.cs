using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.SecurityInterfaces;

namespace VideoAdvertising.Common.Objects.SecurityObjects
{
    class StringEncryptorResponseClass : IStringEncryptorResponse
    {
        public StringEncryptorResponseClass(byte[] cipherBytes, byte[] entropy)
        {
            CipherBytes = cipherBytes;
            Entropy = entropy;
        }

        public byte[] CipherBytes { get; private set; }
        public byte[] Entropy { get; private set; }
    }
}
