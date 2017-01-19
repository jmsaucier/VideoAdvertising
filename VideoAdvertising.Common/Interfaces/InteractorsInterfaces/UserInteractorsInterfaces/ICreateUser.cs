using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.UserResponseInterfaces;

namespace VideoAdvertising.Common.Interfaces.InteractorsInterfaces.UserInteractorsInterfaces
{
    public interface ICreateUser
    {
        ICreateUserResponse CreateUser(ICreateUserRequest request);
    }
}