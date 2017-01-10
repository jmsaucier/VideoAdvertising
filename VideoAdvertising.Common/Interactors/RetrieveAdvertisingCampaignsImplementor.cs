﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces;
using VideoAdvertising.Common.ResponseObjects;

namespace VideoAdvertising.Common.Interactors
{
    public class RetrieveAdvertisingCampaignsImplementor : IRetrieveAdvertisingCampaigns
    {
        private readonly IAdvertisingCampaignRepository _advertisingCampaignRepository;

        public RetrieveAdvertisingCampaignsImplementor(IAdvertisingCampaignRepository advertisingCampaignRepository)
        {
            _advertisingCampaignRepository = advertisingCampaignRepository;
        }

        public IRetrieveAdvertisingCampaignsResponse GetAdvertisingCampaigns(IRetrieveAdvertisingCampaignRequest request)
        {
            RetrieveAdvertisingCampaignsResponse response = new RetrieveAdvertisingCampaignsResponse
            {
                AdvertisingCampaigns = _advertisingCampaignRepository.GetByUser(request.UserId)
            };
            return response;
        }
    }
}
