using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Common.Objects.ValidatorObjects.UserValidators
{
    public class UserObjectsMatchValidator : IValidator<IUser>
    {
        private readonly IUser _userMatchingAgainst;
        public UserObjectsMatchValidator(IUser userMatchingAgainst)
        {
            _userMatchingAgainst = userMatchingAgainst;
        }

        public IValidatorResponse Validate(IUser value)
        {
            if (value == null)
            {
                return new SystemFailureValidatorResponse();
            }

            if (value.Id == _userMatchingAgainst.Id 
                && value.Email == _userMatchingAgainst.Email 
                && value.Username == _userMatchingAgainst.Username)
            {
                return new GenericValidatorResponse(true);
            }
            return new GenericValidatorResponse(false, "Users do not match.");
        }
    }
}
