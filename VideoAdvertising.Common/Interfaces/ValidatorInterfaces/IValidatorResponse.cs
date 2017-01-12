using System.Collections.Generic;

namespace VideoAdvertising.Common.Interfaces.ValidatorInterfaces
{
    public interface IValidatorResponse
    {
        bool Passed { get; }
        IEnumerable<string> Messages { get; }
        bool SystemFailure { get; }
    }
}