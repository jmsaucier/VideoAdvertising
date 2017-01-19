using System.Collections.Generic;

namespace VideoAdvertising.Common.Interfaces.ResponseInterfaces
{
    public interface IInteractorResponse
    {
        bool Successful { get; }
        IEnumerable<string> Messages { get; }
    }
}