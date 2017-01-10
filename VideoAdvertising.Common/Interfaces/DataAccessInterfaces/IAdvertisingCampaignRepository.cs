using System.Collections.Generic;
using VideoAdvertising.Common.ObjectInterfaces;

namespace VideoAdvertising.Common.DataAccessInterfaces
{
    public interface IAdvertisingCampaignRepository : IRepository<IAdvertisingCampaign>
    {
        IEnumerable<IAdvertisingCampaign> GetByUser(string userId);
    }
}