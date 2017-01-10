using System.Collections.Generic;

namespace VideoAdvertising.Common.Interfaces.DataValidatorInterfaces
{
    public interface IValidatorResponse
    {
        bool Passed { get; set; }
        IEnumerable<string> Messages { get; set; }
    }
}