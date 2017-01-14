using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;

namespace VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses
{
    public class SystemFailureValidatorResponse : IValidatorResponse
    {
        //TODO: JMS - 1/11/17 review this at a later time to add internal logging
        //Not allowed to pass with system failure
        public bool Passed {
            get { return false; }
        }
        public IEnumerable<string> Messages {
            get { return new List<string> { "System failure." }; }
        }
        public bool SystemFailure {
            get { return true; }
        }
    }
}
