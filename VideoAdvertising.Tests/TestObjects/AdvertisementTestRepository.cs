using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects;
using VideoAdvertising.Common.Objects.ModelObjects;

namespace VideoAdvertising.Tests.TestObjects
{
    public class AdvertisementTestRepository : IAdvertisementRepository
    {
        private int nextId = 5;

        private readonly List<IAdvertisement> repository = new List<IAdvertisement>()
        {
            new Advertisement { Id="1", Name="a", UserId = "1"},
            new Advertisement { Id="2", Name="b", UserId = "1"},
            new Advertisement { Id="3", Name="c", UserId = "2"},
            new Advertisement { Id="4", Name="a", UserId = "2"}
        };

        public IAdvertisement GetById(string id)
        {
            var ret = repository.FirstOrDefault(a => a.Id == id);
            return ret ?? new Advertisement();
        }

        public IEnumerable<IAdvertisement> GetAll()
        {
            return repository.ToList();
        }

        public IAdvertisement Store(IAdvertisement user)
        {
            user.Id = nextId.ToString();
            nextId++;
            repository.Add(user);
            return user;
        }
        
        public IAdvertisement Update(string id, IAdvertisement value)
        {
            var temp = repository.FirstOrDefault(a => a.Id == id);
            if (temp == null)
            {
                throw new Exception("Advertisement not found.");
            }
            repository.Remove(temp);
            repository.Add(value);
            return value;
        }
    }
}