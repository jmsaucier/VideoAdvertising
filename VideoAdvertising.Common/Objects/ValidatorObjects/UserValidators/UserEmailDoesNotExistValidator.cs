using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Common.Objects.ValidatorObjects.UserValidators
{
    public class UserEmailDoesNotExistValidator : IValidator<IUser>
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
