using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisementResponseInterfaces;

namespace VideoAdvertising.Common.Objects.ResponseObjects.AdvertisementResponses
{
    class CreateAdvertisementResponse : ICreateAdvertisementResponse
    {


        public bool Successful { get; private set; }
        public IEnumerable<string> Messages { get; private set; }
        public IAdvertisement Advertisement { get; set; }
    }
}
