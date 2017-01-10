using System.Collections.Generic;
using VideoAdvertising.Common.ObjectInterfaces;

namespace VideoAdvertising.Common.ResponseInterfaces
{
    public interface IRetrieveAdvertisingCampaignResponse
    {
        IEnumerable<IAdvertisingCampaign> AdvertisingCampaigns { get; set; }
    }
}