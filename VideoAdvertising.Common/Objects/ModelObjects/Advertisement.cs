using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Objects.ModelObjects
{
    public class Advertisement : IAdvertisement
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IUser User { get; set; }
    }
}
