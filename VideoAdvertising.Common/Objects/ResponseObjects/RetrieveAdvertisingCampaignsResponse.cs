using System.Collections.Generic;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisingCampaignResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;

namespace VideoAdvertising.Common.ResponseObjects
{
    public class RetrieveAdvertisingCampaignsResponse : IRetrieveAdvertisingCampaignsResponse
    {
        public RetrieveAdvertisingCampaignsResponse()
        {
            
        }

        public RetrieveAdvertisingCampaignsResponse(IValidatorResponse validatorResponse)
        {
            AdvertisingCampaigns = new List<IAdvertisingCampaign>();
            Successful = validatorResponse.Passed;
            Messages = validatorResponse.Messages;
        }
        public IEnumerable<IAdvertisingCampaign> AdvertisingCampaigns { get; set; }
        public bool Successful { get; private set; }
        public IEnumerable<string> Messages { get; private set; }
    }
}