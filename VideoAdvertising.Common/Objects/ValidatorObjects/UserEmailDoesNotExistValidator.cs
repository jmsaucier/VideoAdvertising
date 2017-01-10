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
            IUser user = _userRepository.GetUserByEmail(value.Email);
            
            GenericValidatorResponse response = new GenericValidatorResponse();
            
            if (user.Id == string.Empty)
            {
                response.Passed = true;
            }
            else
            {
                response.Passed = false;
                response.Messages = new List<string> { "Email address already registered." };
            }

            return response;
        }
    }
}
