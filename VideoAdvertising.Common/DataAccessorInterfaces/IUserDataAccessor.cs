using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Objects;

namespace VideoAdvertising.Common.DataAccessInterfaces
{
    public interface IUserDataAccessor
    {
        User GetUser(string id);

        List<User> GetUsers();

        User StoreUser(User user);

        User UpdateUser(User user);
    }
}
