using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAdvertising.Common.Objects
{
    public class AdvertisingCampaign
    {
        public DateTime StartDate { get; set; }
        public float Budget { get; set; }
        public string CampaignName { get; set; }
        public List<Advertisement> Advertisements { get; set; }
    }
}
