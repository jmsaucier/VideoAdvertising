using System.Collections.Generic;

using VideoAdvertising.Common.ObjectInterfaces;

namespace VideoAdvertising.Common.DataAccessInterfaces
{
    public interface IUserDataAccessor
    {
        IUser GetUser(string id);

        List<IUser> GetUsers();

        IUser StoreUser(IUser user);

        IUser UpdateUser(IUser user);
    }
}
