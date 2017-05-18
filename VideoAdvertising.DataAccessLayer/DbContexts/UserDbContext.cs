using System.Data.Entity;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;

namespace VideoAdvertising.DataAccessLayer.DbContexts
{
    public class UserDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
    }
}
