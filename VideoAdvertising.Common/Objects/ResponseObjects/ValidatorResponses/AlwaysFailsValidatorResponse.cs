using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;

namespace VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses
{
    public class AlwaysFailsValidatorResponse : IValidatorResponse
    {
        public bool Passed {
            get { return false; }
        }
        public IEnumerable<string> Messages { get {return new List<string> { "Always fails validator message." };}}
        public bool SystemFailure
        {
            get { return false; }
        }
    }
}
