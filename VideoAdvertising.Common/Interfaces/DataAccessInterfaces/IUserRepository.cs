using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Interfaces.DataAccessInterfaces
{
    public interface IUserRepository : IRepository<IUser>
    {
        IUser GetUserByUserName(string username);
    
        IUser GetUserByEmail(string email);
    }
}
