using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;

namespace VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses
{
    class AggregateValidatorResponse : IValidatorResponse
    {
        public bool Passed { get; private set; }
        public IEnumerable<string> Messages { get; private set; }
        public bool SystemFailure { get; private set; }
        
        public AggregateValidatorResponse() : this(true, false)
        {
            
        }

        public AggregateValidatorResponse(bool passed, bool systemFailure)
        {
            Passed = passed;
            SystemFailure = systemFailure;
            Messages = new List<string>();
        }

        public void AddValidatorResponse(IValidatorResponse response)
        {
            if (response == null)
            {
                //TODO: JMS - 1/11/17 - add event log here, this shouldn't happen
                return;
            }
            Passed = Passed && response.Passed;
            SystemFailure = SystemFailure || response.SystemFailure;
            if (response.Messages != null)
            {
                List<string> tempMessages = Messages.ToList();
                tempMessages.AddRange(response.Messages);
                Messages = tempMessages;
            }
        }

    }
}
