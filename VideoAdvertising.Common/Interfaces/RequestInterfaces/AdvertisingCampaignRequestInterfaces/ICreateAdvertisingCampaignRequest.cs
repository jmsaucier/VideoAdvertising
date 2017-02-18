using System;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Interfaces.RequestInterfaces.AdvertisingCampaignRequestInterfaces
{
    public interface ICreateAdvertisingCampaignRequest
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        double Budget { get; set; }
        IUser User { get; set; }
        string Name { get; set; }
    }
}