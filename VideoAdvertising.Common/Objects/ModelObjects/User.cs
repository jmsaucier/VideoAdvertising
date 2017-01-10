using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Objects.ModelObjects
{
    public class User : IUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
    }
}
