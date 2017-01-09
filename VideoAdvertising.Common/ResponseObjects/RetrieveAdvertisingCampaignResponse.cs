using System.Collections.Generic;
using VideoAdvertising.Common.ObjectInterfaces;
using VideoAdvertising.Common.ResponseInterfaces;

namespace VideoAdvertising.Common.ResponseObjects
{
    public class RetrieveAdvertisingCampaignResponse : IRetrieveAdvertisingCampaignResponse
    {
        public IEnumerable<IAdvertisingCampaign> AdvertisingCampaigns { get; set; }
    }
}