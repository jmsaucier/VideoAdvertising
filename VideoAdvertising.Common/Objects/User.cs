using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.ObjectInterfaces;

namespace VideoAdvertising.Common.Objects
{
    public class User : IUser
    {
        public string Email { get; set; }
        public string Username { get; set; }
    }
}
