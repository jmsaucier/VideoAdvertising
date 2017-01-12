using System.Collections.Generic;

namespace VideoAdvertising.Common.Interfaces.DataValidatorInterfaces
{
    public interface IValidatorResponse
    {
        bool Passed { get; }
        IEnumerable<string> Messages { get; }
        bool SystemFailure { get; }
    }
}