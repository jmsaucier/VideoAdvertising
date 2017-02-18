using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisementResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;

namespace VideoAdvertising.Common.Objects.ResponseObjects.AdvertisementResponses
{
    class CreateAdvertisementResponse : ICreateAdvertisementResponse
    {
        public CreateAdvertisementResponse()
        {
            Successful = true;
            Messages = new List<string>();
        }

        public CreateAdvertisementResponse(IValidatorResponse validatorResponse)
        {
            Advertisement = new Advertisement();
            Successful = validatorResponse.Passed;
            Messages = validatorResponse.Messages;
        }

        public bool Successful { get; private set; }
        public IEnumerable<string> Messages { get; private set; }
        public IAdvertisement Advertisement { get; set; }
    }
}
