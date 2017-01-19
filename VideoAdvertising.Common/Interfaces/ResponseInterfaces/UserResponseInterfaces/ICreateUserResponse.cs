using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Interfaces.ResponseInterfaces.UserResponseInterfaces
{
    public interface ICreateUserResponse : IInteractorResponse
    {
        IUser User { get; set; }
    }
}