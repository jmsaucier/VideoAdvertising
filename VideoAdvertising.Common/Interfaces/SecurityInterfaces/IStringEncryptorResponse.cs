using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAdvertising.Common.Interfaces.SecurityInterfaces
{
    public interface IStringEncryptorResponse
    {
        byte[] CipherBytes { get; set; }
        byte[] Entropy { get; set; }
    }
}
