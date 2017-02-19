using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisementResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;

namespace VideoAdvertising.Common.Objects.ResponseObjects.AdvertisementResponses
{
    class RetrieveAdvertisementResponse : IRetrieveAdvertisementResponse
    {
        public RetrieveAdvertisementResponse()
        {
            Advertisement = new Advertisement();
            Successful = true;
            Messages = new List<string>();
        }

        public RetrieveAdvertisementResponse(IValidatorResponse validatorResponse)
        {
            Advertisement = new Advertisement();
            Successful = validatorResponse.Passed;
            Messages = validatorResponse.Messages;
        }

        public IAdvertisement Advertisement { get; set; }
        public bool Successful { get; private set; }
        public IEnumerable<string> Messages { get; private set; }
    }
}
