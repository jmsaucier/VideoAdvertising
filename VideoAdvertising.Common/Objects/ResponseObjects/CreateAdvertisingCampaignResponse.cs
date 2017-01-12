using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisingCampaignResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;

namespace VideoAdvertising.Common.Objects.ResponseObjects
{
    class CreateAdvertisingCampaignResponse : ICreateAdvertisingCampaignResponse
    {
        public CreateAdvertisingCampaignResponse()
        {
            
        }

        public CreateAdvertisingCampaignResponse(IValidatorResponse validatorResponse)
        {
            AdvertisingCampaign = new AdvertisingCampaign();
            Successful = validatorResponse.Passed;
            Messages = validatorResponse.Messages;
        }

        public IAdvertisingCampaign AdvertisingCampaign { get; set; }
        public bool Successful { get; private set; }
        public IEnumerable<string> Messages { get; private set; }
    }
}
