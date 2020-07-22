using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LoginModel.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the LoginUser class
    public class LoginUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }

        public int Age { get; set; }
        public string Mobile { get; set; }
        public int LicenceNo { get; set; }
        public string Address { get; set; }



    }
}
