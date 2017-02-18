using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequests;

namespace VideoAdvertising.Common.Interfaces.InteractorsInterfaces.AdvertisementInteractorsInterfaces
{
    public interface ICreateAdvertisement
    {
        IAdvertisement CreateAdvertisement(ICreateAdvertisementRequest request);
    }
}
