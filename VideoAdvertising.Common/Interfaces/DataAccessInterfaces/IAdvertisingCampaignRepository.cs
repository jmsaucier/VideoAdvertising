using System.Collections.Generic;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.Common.Interfaces.DataAccessInterfaces
{
    public interface IAdvertisingCampaignRepository : IRepository<IAdvertisingCampaign>
    {
        IEnumerable<IAdvertisingCampaign> GetByUser(string userId);
    }
}