using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Common.Objects.ValidatorObjects.GeneralValidators
{
    public class AlwaysPassValidator<T> : IValidator<T>
    {
        public IValidatorResponse Validate(T value)
        {
            return new AlwaysPassesValidatorResponse();
        }
    }
}
