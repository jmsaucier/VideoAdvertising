using System;
using System.Collections.Generic;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.DataAccessLayer.DataAccessorImplementations
{
    public class UserRepositorySQLImplementation : IUserRepository
    {
        public IUser GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public IUser Store(IUser value)
        {
            throw new NotImplementedException();
        }

        public IUser Update(string id, IUser value)
        {

        }

        public IUser GetUserByUserName(string username)
        {
            throw new NotImplementedException();
        }

        public IUser GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
