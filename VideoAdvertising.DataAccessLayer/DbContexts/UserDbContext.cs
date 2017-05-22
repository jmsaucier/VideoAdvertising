using System.Data.Entity;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.DataAccessLayer.Models;

namespace VideoAdvertising.DataAccessLayer.DbContexts
{
    public class UserDbContext : DbContext
    {
        public virtual DbSet<DbUser> Users { get; set; }

        public virtual void SetPropertyIsModified(DbUser user)
        {
            Entry(user).Property("Email").IsModified = true;
        }

        public virtual void SetEntryIsModified(DbUser user)
        {
            Entry(user).State = EntityState.Modified;            
        }
    }
}
