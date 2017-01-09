using System;
using System.Collections.Generic;
using VideoAdvertising.Common.DataAccessInterfaces;
using VideoAdvertising.Common.ObjectInterfaces;

namespace VideoAdvertising.DataAccessLayer.DataAccessorImplementations
{
    public class UserRepositorySQLImplementation : IUserRepository
    {
        public UserRepositorySQLImplementation()
        {
            
        }

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
            throw new NotImplementedException();
        }
    }
}
