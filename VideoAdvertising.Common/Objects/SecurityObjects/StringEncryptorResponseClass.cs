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
        public byte[] CipherBytes { get; set; }
        public byte[] Entropy { get; set; }
    }
}
