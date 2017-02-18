using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisementResponseInterfaces;

namespace VideoAdvertising.Common.Interfaces.InteractorsInterfaces.AdvertisementInteractorsInterfaces
{
    public interface ICreateAdvertisement
    {
        ICreateAdvertisementResponse CreateAdvertisement(ICreateAdvertisementRequest request);
    }
}
