using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisingCampaignRequests;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisingCampaignResponseInterfaces;

namespace VideoAdvertising.Common.Interfaces.InteractorsInterfaces.AdvertisingCampaignInteractorsInterfaces
{
    public interface ICreateAdvertisingCampaign
    {
        ICreateAdvertisingCampaignResponse CreateAdvertisingCampaign(ICreateAdvertisingCampaignRequest request);
    }
}