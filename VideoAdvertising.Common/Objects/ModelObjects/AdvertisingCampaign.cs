using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Objects.ModelObjects
{
    public class AdvertisingCampaign : IAdvertisingCampaign
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Budget { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public IEnumerable<string> AdvertisementIds { get; set; }
    }
}
