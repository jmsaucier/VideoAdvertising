using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisementResponseInterfaces
{
    public interface IRetrieveAdvertisementResponse : IInteractorResponse
    {
        IAdvertisement Advertisement { get; set; }
    }
}
