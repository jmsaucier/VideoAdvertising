using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.ObjectInterfaces;

namespace VideoAdvertising.Common.Objects
{
    public class Advertisement : IAdvertisement
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
    }
}
