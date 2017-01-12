using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.DataValidatorInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects;

namespace VideoAdvertising.Common.Objects.ValidatorObjects
{
    public class UserEmailDoesNotExistValidator : IUserValidator
    {
        private readonly IUserRepository _userRepository;

        public UserEmailDoesNotExistValidator(IUserRepository repository)
        {
            _userRepository = repository;
        }

        public IValidatorResponse Validate(IUser value)
        {
            
            if (value == null)
            {
                //TODO: JMS - 1/11/17 - log this event to an error log, because this shouldn't happen
                return new SystemFailureValidatorResponse();
            }
            
            IUser user = _userRepository.GetUserByEmail(value.Email);

            GenericValidatorResponse response = (user.Id == string.Empty) ? 
                new GenericValidatorResponse(true) : 
                new GenericValidatorResponse(false, "Email address already registered.");

            return response;
        }
    }
}
