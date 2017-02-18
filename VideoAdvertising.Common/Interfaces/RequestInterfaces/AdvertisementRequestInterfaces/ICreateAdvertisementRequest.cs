using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequestInterfaces
{
    public interface ICreateAdvertisementRequest
    {
        string Name { get; set; }

        IUser User { get; set; }
    }
}