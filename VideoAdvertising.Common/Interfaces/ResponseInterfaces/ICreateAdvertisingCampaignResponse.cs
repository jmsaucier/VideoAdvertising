using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Interfaces.ResponseInterfaces
{
    public interface ICreateAdvertisingCampaignResponse
    {
        IAdvertisingCampaign AdvertisingCampaign { get; set; }
    }
}