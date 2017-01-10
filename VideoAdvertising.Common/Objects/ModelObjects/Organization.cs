using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAdvertising.Common.Objects
{
    public class Organization
    {
        public string Name { get; set; }

        public List<AdvertisingCampaign> AdvertisingCampaigns { get; set; }

        public List<User> Users { get; set; }
    }
}