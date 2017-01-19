using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisingCampaignResponseInterfaces
{
    public interface ICreateAdvertisingCampaignResponse : IInteractorResponse
    {
        IAdvertisingCampaign AdvertisingCampaign { get; set; }
    }
}