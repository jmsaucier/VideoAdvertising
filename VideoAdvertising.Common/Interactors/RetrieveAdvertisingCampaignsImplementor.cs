using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.DataAccessInterfaces;
using VideoAdvertising.Common.InteractorsInterfaces;
using VideoAdvertising.Common.RequestInterfaces;
using VideoAdvertising.Common.ResponseInterfaces;
using VideoAdvertising.Common.ResponseObjects;

namespace VideoAdvertising.Common.Interactors
{
    public class RetrieveAdvertisingCampaignsImplementor : IRetrieveAdvertisingCampaigns
    {
        private IAdvertisingCampaignRepository _advertisingCampaignRepository;

        public RetrieveAdvertisingCampaignsImplementor(IAdvertisingCampaignRepository advertisingCampaignRepository)
        {
            _advertisingCampaignRepository = advertisingCampaignRepository;
        }

        public IRetrieveAdvertisingCampaignResponse GetAdvertisingCampaigns(IRetrieveAdvertisingCampaignRequest request)
        {
            RetrieveAdvertisingCampaignResponse response = new RetrieveAdvertisingCampaignResponse
            {
                AdvertisingCampaigns = _advertisingCampaignRepository.GetByUser(request.UserId)
            };
            return response;
        }
    }
}
