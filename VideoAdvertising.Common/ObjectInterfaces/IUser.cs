using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAdvertising.Common.ObjectInterfaces
{
    public interface IUser
    {
        string Email { get; set; }

        string Username { get; set; }
    }
}
