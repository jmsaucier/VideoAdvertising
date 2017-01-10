using VideoAdvertising.Common.RequestInterfaces;
using VideoAdvertising.Common.ResponseInterfaces;

namespace VideoAdvertising.Common.InteractorsInterfaces
{
    public interface IRetrieveAdvertisingCampaigns
    {
        IRetrieveAdvertisingCampaignResponse GetAdvertisingCampaigns(IRetrieveAdvertisingCampaignRequest request);
    }
}