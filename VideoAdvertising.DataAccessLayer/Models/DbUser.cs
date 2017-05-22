using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;

namespace VideoAdvertising.DataAccessLayer.Models
{
    public class DbUser : IUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
    }
}
