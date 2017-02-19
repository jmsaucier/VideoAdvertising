using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAdvertising.Common.Interfaces.SecurityInterfaces
{
    interface IStringEncryptor
    {
        IStringEncryptorResponse Encrypt(string data);
    }
}
