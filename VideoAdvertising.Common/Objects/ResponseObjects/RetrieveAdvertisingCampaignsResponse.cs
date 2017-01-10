using System.Collections.Generic;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces;

namespace VideoAdvertising.Common.ResponseObjects
{
    public class RetrieveAdvertisingCampaignsResponse : IRetrieveAdvertisingCampaignsResponse
    {
        public IEnumerable<IAdvertisingCampaign> AdvertisingCampaigns { get; set; }
    }
}