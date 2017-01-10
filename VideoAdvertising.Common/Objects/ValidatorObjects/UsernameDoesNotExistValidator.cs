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
            IUser user = _userRepository.GetUserByUserName(value.Username);
            GenericValidatorResponse response = new GenericValidatorResponse(); 
            if (user.Id == string.Empty)
            {
                response.Passed = true;    
            }
            else
            {
                response.Passed = false;
                response.Messages = new List<string> { "Username already exists." };
            }
            return response;
        }
    }
}