using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.DataAccessLayer.DbContexts;
using VideoAdvertising.DataAccessLayer.Models;

namespace VideoAdvertising.DataAccessLayer.DataAccessorImplementations
{
    public class UserRepositoryEFImplementation : IUserRepository
    {
        private readonly UserDbContext _dbContext;

        public UserRepositoryEFImplementation(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUser GetById(string id)
        {
            return _dbContext.Users.FirstOrDefault(a => a.Id == id) ?? new DbUser();
        }

        public IEnumerable<IUser> GetAll()
        {
            return _dbContext.Users;
        }

        public IUser Store(IUser value)
        {
            IUser ret = _dbContext.Users.Add((DbUser)value);
            _dbContext.SaveChanges();
            return ret ?? new DbUser();
        }

        public IUser Update(string id, IUser value)
        {
            DbUser currentEntity = _dbContext.Users.Find(id);
            if (currentEntity == null)
            {
                return new DbUser();
            }
            _dbContext.SetEntryIsModified(currentEntity);
            _dbContext.SaveChanges();
            return _dbContext.Users.Find(id) ?? new DbUser();
        }

        public IUser GetUserByUserName(string username)
        {
            return _dbContext.Users.FirstOrDefault(a => a.Username == username) ?? new DbUser();
        }

        public IUser GetUserByEmail(string email)
        {
            return _dbContext.Users.FirstOrDefault(a => a.Email == email) ?? new DbUser();
        }
    }
}
