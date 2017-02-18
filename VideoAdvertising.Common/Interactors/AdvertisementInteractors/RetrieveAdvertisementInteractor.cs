using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces.AdvertisementInteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisementResponseInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects.AdvertisementResponses;

namespace VideoAdvertising.Common.Interactors.AdvertisementInteractors
{
    public class RetrieveAdvertisementInteractor : IRetrieveAdvertisement
    {
        public IRetrieveAdvertisementResponse RetrieveAdvertisement(IRetrieveAdvertisementRequest request)
        {
            return new RetrieveAdvertisementResponse();
        }
    }
}
