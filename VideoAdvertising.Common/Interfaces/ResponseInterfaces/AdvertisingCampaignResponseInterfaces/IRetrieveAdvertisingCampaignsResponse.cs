using System.Collections.Generic;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisingCampaignResponseInterfaces
{
    public interface IRetrieveAdvertisingCampaignsResponse : IInteractorResponse
    {
        IEnumerable<IAdvertisingCampaign> AdvertisingCampaigns { get; set; }
    }
}