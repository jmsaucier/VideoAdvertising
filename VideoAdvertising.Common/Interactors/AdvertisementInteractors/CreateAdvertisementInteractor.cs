using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class CreateAdvertisementInteractor : ICreateAdvertisement
    {
        private IAdvertisementRepository _advertisementRepository;
        private IValidator<IUser> _userValidator;

        public CreateAdvertisementInteractor(IAdvertisementRepository repository, IValidator<IUser> userValidator)
        {
            _advertisementRepository = repository;
            _userValidator = userValidator;
        }

        public ICreateAdvertisementResponse CreateAdvertisement(ICreateAdvertisementRequest request)
        {
            IValidatorResponse validatorResponse = _userValidator.Validate(request.User);
            if (!validatorResponse.Passed)
            {
                return new CreateAdvertisementResponse(validatorResponse);
            }



            Advertisement advertisement = new Advertisement
            {
                Name = request.Name,
                User = request.User
            };

            IAdvertisement storedAdvertisement = _advertisementRepository.Store(advertisement);
            CreateAdvertisementResponse response = new CreateAdvertisementResponse(){Advertisement = storedAdvertisement };
            return response;
        }
    }
}
