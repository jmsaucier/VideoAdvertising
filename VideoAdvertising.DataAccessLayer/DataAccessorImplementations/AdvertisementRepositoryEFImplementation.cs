using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;

namespace VideoAdvertising.DataAccessLayer.DataAccessorImplementations
{
    public class AdvertisementRepositoryEFImplementation : IAdvertisementRepository
    {
        public IAdvertisement GetById(string id)
        {
            return new Advertisement();
        }

        public IEnumerable<IAdvertisement> GetAll()
        {
            throw new NotImplementedException();
        }

        public IAdvertisement Store(IAdvertisement value)
        {
            throw new NotImplementedException();
        }

        public IAdvertisement Update(string id, IAdvertisement value)
        {
            throw new NotImplementedException();
        }
    }
}
