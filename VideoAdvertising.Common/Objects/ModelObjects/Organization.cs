using System.Collections.Generic;

namespace VideoAdvertising.Common.Objects.ModelObjects
{
    public class Organization
    {
        public string Name { get; set; }

        public List<AdvertisingCampaign> AdvertisingCampaigns { get; set; }

        public List<User> Users { get; set; }
    }
}