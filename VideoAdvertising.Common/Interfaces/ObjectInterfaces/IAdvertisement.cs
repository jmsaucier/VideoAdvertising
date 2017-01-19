namespace VideoAdvertising.Common.Interfaces.ObjectInterfaces
{
    public interface IAdvertisement
    {
        string Id { get; set; }

        string Name { get; set; }
        
        string UserId { get; set; }
    }
}