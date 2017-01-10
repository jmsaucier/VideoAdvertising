using System;
using System.Collections.Generic;

namespace VideoAdvertising.Common.Interfaces.ObjectInterfaces
{
    public interface IAdvertisingCampaign
    {
        string Id { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        double Budget { get; set; }
        string Name { get; set; }
        string UserId { get; set; }
        IEnumerable<string> AdvertisementIds { get; set; }
    }
}