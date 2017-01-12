using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;
using VideoAdvertising.Common.Objects.ValidatorObjects.GeneralValidators;

namespace VideoAdvertising.Tests.TestObjects
{
    public class TestValidatorWasCalled<T, TK> : ReturnCertainTypeOfResponseValidator<T, TK>
        where TK : IValidatorResponse, new()
    {
        public bool WasCalled { get; set; }

        public override IValidatorResponse Validate(T value)
        {
            WasCalled = true;
            return base.Validate(value);
        }
    }
}