namespace VideoAdvertising.Common.Interfaces.RequestInterfaces
{
    public interface ICreateUserRequest
    {
        string Email { get; set; }
        string Username { get; set; }
    }
}