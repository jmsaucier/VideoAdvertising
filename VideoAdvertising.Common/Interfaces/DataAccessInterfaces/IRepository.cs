using System.Collections.Generic;
using VideoAdvertising.Common.ObjectInterfaces;

namespace VideoAdvertising.Common.DataAccessInterfaces
{
    public interface IRepository<T>
    {
        T GetById(string id);

        IEnumerable<T> GetAll();

        T Store(T value);

        T Update(string id, T value);
    }
}