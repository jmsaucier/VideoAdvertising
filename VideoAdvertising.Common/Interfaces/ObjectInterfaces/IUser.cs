namespace VideoAdvertising.Common.Interfaces.ObjectInterfaces
{
    public interface IUser
    {
        string Id { get; set; }

        string Email { get; set; }

        string Username { get; set; }

        string Password { get; set; }
    }
}
