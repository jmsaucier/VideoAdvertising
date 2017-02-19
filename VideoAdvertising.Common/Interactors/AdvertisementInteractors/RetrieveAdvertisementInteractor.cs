using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces.AdvertisementInteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisementRequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.AdvertisementResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.Common.Objects.ResponseObjects.AdvertisementResponses;

namespace VideoAdvertising.Common.Interactors.AdvertisementInteractors
{
    public class RetrieveAdvertisementInteractor : IRetrieveAdvertisement
    {
        private readonly IAdvertisementRepository _advertisementRepository;
        private readonly IValidator<IUser> _userValidator;

        public RetrieveAdvertisementInteractor(IAdvertisementRepository advertisementRepository, IValidator<IUser> userValidator)
        {
            _advertisementRepository = advertisementRepository;
            _userValidator = userValidator;
        }

        public IRetrieveAdvertisementResponse RetrieveAdvertisement(IRetrieveAdvertisementRequest request)
        {
            IAdvertisement advertisement = _advertisementRepository.GetById(request.Id);

            IValidatorResponse validatorResponse = _userValidator.Validate(advertisement.User);
            if (!validatorResponse.Passed)
            {
                return new RetrieveAdvertisementResponse(validatorResponse);    
            }

            return new RetrieveAdvertisementResponse { Advertisement = advertisement};
        }
    }
}
