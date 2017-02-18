using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces.AdvertisementInteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequests;
using VideoAdvertising.Common.Objects.ModelObjects;

namespace VideoAdvertising.Common.Interactors.AdvertisementInteractors
{
    public class CreateAdvertisementInteractor : ICreateAdvertisement
    {
        public IAdvertisement CreateAdvertisement(ICreateAdvertisementRequest request)
        {
            return new Advertisement
            {
                Name = request.Name
            };
        }
    }
}
