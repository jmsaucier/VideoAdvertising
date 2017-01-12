using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;

namespace VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses
{
    public class AlwaysPassesValidatorResponse : IValidatorResponse
    {
        public bool Passed { get { return true; }}
        public IEnumerable<string> Messages {
            get { return new List<string>(); }
        }
        public bool SystemFailure {
            get { return false; }
        }
    }
}
