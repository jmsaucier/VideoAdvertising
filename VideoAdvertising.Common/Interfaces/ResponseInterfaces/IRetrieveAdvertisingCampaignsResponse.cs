using System.Collections.Generic;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Interfaces.ResponseInterfaces
{
    public interface IRetrieveAdvertisingCampaignsResponse
    {
        IEnumerable<IAdvertisingCampaign> AdvertisingCampaigns { get; set; }
    }
}