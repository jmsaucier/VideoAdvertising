using System.Collections.Generic;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.DataValidatorInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects;

namespace VideoAdvertising.Common.Objects.ValidatorObjects
{
    public class UsernameDoesNotExistValidator : IUserValidator
    {
        private readonly IUserRepository _userRepository;

        public UsernameDoesNotExistValidator(IUserRepository repository)
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

            IUser user = _userRepository.GetUserByUserName(value.Username);
            GenericValidatorResponse response = (user.Id == string.Empty) ? 
                new GenericValidatorResponse(true) : 
                new GenericValidatorResponse(false, "Username already exists.");
            return response;
        }
    }
}