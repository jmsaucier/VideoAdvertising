using System;
using System.Collections.Generic;
using System.Linq;
using VideoAdvertising.Common.DataAccessInterfaces;
using VideoAdvertising.Common.ObjectInterfaces;
using VideoAdvertising.Common.Objects;

namespace VideoAdvertising.Tests.TestObjects
{
    public class AdvertisingCampaignTestRepository : IAdvertisingCampaignRepository
    {
        private int nextId = 4;

        private readonly List<IAdvertisingCampaign> repository = new List<IAdvertisingCampaign>()
        {
            new AdvertisingCampaign {Id = "1", Budget = 100.00, Name = "ABC", StartDate = new DateTime(2017,01,01), EndDate = new DateTime(2017, 02, 01), UserId="1", AdvertisementIds = new List<string> {"1"} },
            new AdvertisingCampaign {Id = "2", Budget = 200.00, Name = "ABC", StartDate = new DateTime(2017,01,20), EndDate = new DateTime(2017, 02, 01), UserId="1", AdvertisementIds = new List<string> {"2"} },
            new AdvertisingCampaign {Id = "3", Budget = 300.00, Name = "ABC", StartDate = new DateTime(2017,01,30), EndDate = new DateTime(2017, 02, 01), UserId="2", AdvertisementIds = new List<string> {"3","4"} }
        };

        public IAdvertisingCampaign GetById(string id)
        {
            return repository.FirstOrDefault(a => a.Id == id) ?? new AdvertisingCampaign();
        }

        public IEnumerable<IAdvertisingCampaign> GetAll()
        {
            return repository.ToList();
        }

        public IAdvertisingCampaign Store(IAdvertisingCampaign value)
        {
            value.Id = nextId.ToString();
            nextId++;
            repository.Add(value);
            return value;
        }

        public IAdvertisingCampaign Update(string id, IAdvertisingCampaign value)
        {
            var temp = repository.FirstOrDefault(a => a.Id == id);
            if (temp == null)
            {
                throw new Exception("AdvertisingCampaign not found.");
            }
            repository.Remove(temp);
            repository.Add(value);
            return value;
        }

        public IEnumerable<IAdvertisingCampaign> GetByUser(string userId)
        {
            return repository.Where(a => a.UserId == userId);
        }
    }
}