using System.Collections.Generic;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.UserResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;

namespace VideoAdvertising.Common.Objects.ResponseObjects
{
    public class CreateUserResponse : ICreateUserResponse
    {
        public CreateUserResponse()
        {
            
        }

        public CreateUserResponse(IValidatorResponse validatorResponse)
        {
            User = new User();
            Successful = validatorResponse.Passed;
            Messages = validatorResponse.Messages;
        }

        public IUser User { get; set; }
        public bool Successful { get; set; }
        public IEnumerable<string> Messages { get; set; }
    }
}