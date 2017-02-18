using System;
using System.Threading;
using System.Xml.Linq;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisingCampaignRequestInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Common.Objects.ValidatorObjects.RequestValidators
{
    public class CreateAdvertisingRequestValidator : IValidator<ICreateAdvertisingCampaignRequest>
    {
        private readonly IValidator<IUser> _userValidator;
        public CreateAdvertisingRequestValidator(IValidator<IUser> userValidator)
        {
            _userValidator = userValidator;
        }

        public IValidatorResponse Validate(ICreateAdvertisingCampaignRequest value)
        {
            AggregateValidatorResponse response = new AggregateValidatorResponse();

            if (string.IsNullOrEmpty(value.Name))
            {
                response.AddValidatorResponse(new GenericValidatorResponse(false, "Advertising Campaign name is null or empty."));
            }
            IValidatorResponse userValidatorResponse = _userValidator.Validate(value.User);
            response.AddValidatorResponse(userValidatorResponse);
            if (value.Budget < 0)
            {
                response.AddValidatorResponse(new GenericValidatorResponse(false, "Budget is less than zero."));
            }
            
            if (value.StartDate >= value.EndDate)
            {
                response.AddValidatorResponse(new GenericValidatorResponse(false, "Dates are invalid."));
            }
            else if (value.StartDate == DateTime.MinValue)
            {
                response.AddValidatorResponse(new GenericValidatorResponse(false, "Start date is invalid."));
            }

            return response;
        }

    }
}