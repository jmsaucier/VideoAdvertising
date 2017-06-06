using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Routing.Constraints;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace VideoAdvertising.Models
{
    public class ChangePasswordViewModel
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class IndexViewModel
    {
        public bool HasPassword
        {
            get { return false; }
        }
    }

    public class SetPasswordViewModel
    {
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }    
    }
}