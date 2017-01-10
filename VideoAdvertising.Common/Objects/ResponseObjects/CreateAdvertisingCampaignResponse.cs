using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces;

namespace VideoAdvertising.Common.Objects.ResponseObjects
{
    public class CreateAdvertisingCampaignResponse : ICreateAdvertisingCampaignResponse
    {
        public IAdvertisingCampaign AdvertisingCampaign { get; set; }
    }
}
