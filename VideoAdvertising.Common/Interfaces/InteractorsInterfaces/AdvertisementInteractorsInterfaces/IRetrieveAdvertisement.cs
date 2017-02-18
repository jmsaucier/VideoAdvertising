using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisementResponseInterfaces;

namespace VideoAdvertising.Common.Interfaces.InteractorsInterfaces.AdvertisementInteractorsInterfaces
{
    public interface IRetrieveAdvertisement
    {
        IRetrieveAdvertisementResponse RetrieveAdvertisement(IRetrieveAdvertisementRequest request);
    }
}
