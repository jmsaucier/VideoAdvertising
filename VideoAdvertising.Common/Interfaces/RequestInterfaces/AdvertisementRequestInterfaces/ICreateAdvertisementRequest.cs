namespace VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequestInterfaces
{
    public interface ICreateAdvertisementRequest
    {
        string Name { get; set; }

        string UserId { get; set; }
    }
}