namespace VideoAdvertising.Common.Interfaces.ValidatorInterfaces
{
    public interface IValidator<T>
    {
        IValidatorResponse Validate(T value);
    }
}