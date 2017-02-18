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
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.Common.Objects.ResponseObjects.AdvertisementResponses;

namespace VideoAdvertising.Common.Interactors.AdvertisementInteractors
{
    public class CreateAdvertisementInteractor : ICreateAdvertisement
    {
        private IAdvertisementRepository _advertisementRepository;

        public CreateAdvertisementInteractor(IAdvertisementRepository repository)
        {
            _advertisementRepository = repository;
        }

        public ICreateAdvertisementResponse CreateAdvertisement(ICreateAdvertisementRequest request)
        {
            Advertisement advertisement = new Advertisement
            {
                Name = request.Name,
                UserId = request.UserId
            };

            IAdvertisement storedAdvertisement = _advertisementRepository.Store(advertisement);
            CreateAdvertisementResponse response = new CreateAdvertisementResponse(){Advertisement = storedAdvertisement };
            return response;
        }
    }
}
