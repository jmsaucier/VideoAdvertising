using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.Common.Objects.ResponseObjects;

namespace VideoAdvertising.Common.Interactors
{
    public class CreateAdvertisingCampaignInteractor : ICreateAdvertisingCampaign
    {
        private readonly IAdvertisingCampaignRepository _advertisingCampaignRepository;
        public CreateAdvertisingCampaignInteractor(IAdvertisingCampaignRepository repository)
        {
            _advertisingCampaignRepository = repository;
        }

        public ICreateAdvertisingCampaignResponse CreateAdvertisingCampaign(ICreateAdvertisingCampaignRequest request)
        {
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
