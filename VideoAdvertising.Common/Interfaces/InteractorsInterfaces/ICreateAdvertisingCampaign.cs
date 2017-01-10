using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces;

namespace VideoAdvertising.Common.Interfaces.InteractorsInterfaces
{
    public interface ICreateAdvertisingCampaign
    {
        ICreateAdvertisingCampaignResponse CreateAdvertisingCampaign(ICreateAdvertisingCampaignRequest request);
    }
}