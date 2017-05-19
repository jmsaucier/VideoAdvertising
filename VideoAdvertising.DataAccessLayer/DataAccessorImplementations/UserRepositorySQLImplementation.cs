using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.DataAccessLayer.DbContexts;

namespace VideoAdvertising.DataAccessLayer.DataAccessorImplementations
{
    public class UserRepositorySQLImplementation : IUserRepository
    {
        private readonly UserDbContext _dbContext;

        public UserRepositorySQLImplementation(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUser GetById(string id)
        {
            return _dbContext.Users.FirstOrDefault(a => a.Id == id) ?? new User();
        }

        public IEnumerable<IUser> GetAll()
        {
            return _dbContext.Users;
        }

        public IUser Store(IUser value)
        {
            IUser ret = _dbContext.Users.Add((User)value);
            _dbContext.SaveChanges();
            return ret ?? new User();
        }

        public IUser Update(string id, IUser value)
        {
            IUser currentEntity = _dbContext.Users.Find(id);
            if (currentEntity == null)
            {
                return new User();
            }
            _dbContext.Entry(currentEntity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return _dbContext.Users.Find(id) ?? new User();
        }

        public IUser GetUserByUserName(string username)
        {
            return _dbContext.Users.FirstOrDefault(a => a.Username == username) ?? new User();
        }

        public IUser GetUserByEmail(string email)
        {
            return _dbContext.Users.FirstOrDefault(a => a.Email == email) ?? new User();
        }
    }
}
