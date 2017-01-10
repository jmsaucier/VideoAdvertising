using System;
using System.Collections.Generic;
using System.Linq;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;

namespace VideoAdvertising.Tests.TestObjects
{
    public class UserTestRepository : IUserRepository
    {
        private readonly List<IUser> repository = new List<IUser>
        {
            new User {Id = "1", Email = "abc@xyz.com", Username = "abc"},
            new User {Id = "2", Email = "abc@xyz.com", Username = "foo"},
            new User {Id = "3", Email = "abc@xyz.com", Username = "bar"}
        };

        private int nextId = 4;
        
        public IUser GetById(string id)
        {
            IUser ret = repository.FirstOrDefault(a => a.Id == id);
            
            return ret ?? new User();
        }

        public IEnumerable<IUser> GetAll()
        {
            return repository.ToList();
        }

        public IUser Store(IUser user)
        {
            user.Id = nextId.ToString();
            nextId++;
            repository.Add(user);
            return user;
        }

        public IUser Update(string id, IUser value)
        {
            var temp = repository.FirstOrDefault(a => a.Id == id);
            if (temp == null)
            {
                throw new Exception("User not found");
            }
            repository.Remove(temp);
            repository.Add(value);
            return value;
        }

        public IUser GetUserByUserName(string username)
        {
            IUser ret = repository.FirstOrDefault(a => a.Username == username);
            return ret ?? new User();
        }

        public IUser GetUserByEmail(string email)
        {
            IUser ret = repository.FirstOrDefault(a => a.Email == email);
            return ret ?? new User();
        }
    }
}