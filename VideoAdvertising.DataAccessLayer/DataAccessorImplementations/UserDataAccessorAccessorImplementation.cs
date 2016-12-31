using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.DataAccessInterfaces;
using VideoAdvertising.Common.Objects;

namespace VideoAdvertising.DataAccessLayer.DataAccessorObjects
{
    public class UserDataAccessorImplementation : IUserDataAccessor
    {
        public User GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User StoreUser(User user)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
