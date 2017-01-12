using System.Collections.Generic;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;

namespace VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses
{
    public class GenericValidatorResponse : IValidatorResponse
    {
        public GenericValidatorResponse()
            : this(false, new List<string>())
        {
            
        }

        public GenericValidatorResponse(bool passed) : this(passed, new List<string>())
        {
            
        }

        public GenericValidatorResponse(bool passed, string message)
            : this(passed, new List<string> { message })
        {
            
        }

        public GenericValidatorResponse(bool passed, IEnumerable<string> messages)
        {
            Passed = passed;
            Messages = messages;
        }

        public bool Passed { 
            get;
            private set;
        }

        public IEnumerable<string> Messages { get; private set; }
        
        public bool SystemFailure {
            get { return false; }
        }
    }
}