using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Objects.ModelObjects
{
    public class User : IUser
    {
        public User()
        {
            Id = string.Empty;
            Email = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
        }

        public string Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
