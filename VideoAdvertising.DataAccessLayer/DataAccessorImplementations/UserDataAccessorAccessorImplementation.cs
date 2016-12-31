using System;
using System.Collections.Generic;
using VideoAdvertising.Common.DataAccessInterfaces;
using VideoAdvertising.Common.ObjectInterfaces;

namespace VideoAdvertising.DataAccessLayer.DataAccessorImplementations
{
    public class UserDataAccessorImplementation : IUserDataAccessor
    {
        public IUser GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public List<IUser> GetUsers()
        {
            throw new NotImplementedException();
        }

        public IUser StoreUser(IUser user)
        {
            throw new NotImplementedException();
        }

        public IUser UpdateUser(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}
