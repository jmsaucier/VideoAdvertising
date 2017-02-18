using System.Collections.Generic;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces.AdvertisingCampaignInteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisingCampaignRequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisingCampaignResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.Common.Objects.ResponseObjects;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Common.Interactors.AdvertisingCampaignInteractors
{
    public class CreateAdvertisingCampaignInteractor : ICreateAdvertisingCampaign
    {
        private readonly IAdvertisingCampaignRepository _advertisingCampaignRepository;
        private readonly IValidator<IUser> _userValidator;
        private readonly IValidator<ICreateAdvertisingCampaignRequest> _createAdvertisingCampaignRequestValidator;

        public CreateAdvertisingCampaignInteractor(IAdvertisingCampaignRepository repository, IValidator<IUser> userValidator, IValidator<ICreateAdvertisingCampaignRequest> requestValidator)
        {
            _advertisingCampaignRepository = repository;
            _userValidator = userValidator;
            _createAdvertisingCampaignRequestValidator = requestValidator;
        }

        public ICreateAdvertisingCampaignResponse CreateAdvertisingCampaign(ICreateAdvertisingCampaignRequest request)
        {
            AggregateValidatorResponse validatorResponse = new AggregateValidatorResponse();
            validatorResponse.AddValidatorResponse(_createAdvertisingCampaignRequestValidator.Validate(request));
            validatorResponse.AddValidatorResponse(_userValidator.Validate(request.User));
            if (!validatorResponse.Passed)
            {
                return new CreateAdvertisingCampaignResponse(validatorResponse);
            }

            AdvertisingCampaign advertisingCampaign = new AdvertisingCampaign
            {
                Name = request.Name,
                Budget = request.Budget,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                UserId = request.User.Id
            };

            CreateAdvertisingCampaignResponse response = new CreateAdvertisingCampaignResponse
            {
                AdvertisingCampaign = _advertisingCampaignRepository.Store(advertisingCampaign)
            };
            return response;
        }

    }
}
