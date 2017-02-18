namespace VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequests
{
    public interface ICreateAdvertisementRequest
    {
        string Name { get; set; }

        string UserId { get; set; }
    }
}