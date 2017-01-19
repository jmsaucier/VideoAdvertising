using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;

namespace VideoAdvertising.Common.Objects.ValidatorObjects.GeneralValidators
{
    public class ReturnCertainTypeOfResponseValidator<T, TK> : IValidator<T> where TK : IValidatorResponse, new()  
    {   
        public virtual IValidatorResponse Validate(T value)
        {
            return new TK();
        }
    }
}