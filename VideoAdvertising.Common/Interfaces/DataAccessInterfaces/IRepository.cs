using System.Collections.Generic;

namespace VideoAdvertising.Common.Interfaces.DataAccessInterfaces
{
    public interface IRepository<T>
    {
        T GetById(string id);

        IEnumerable<T> GetAll();

        T Store(T value);

        T Update(string id, T value);
    }
}