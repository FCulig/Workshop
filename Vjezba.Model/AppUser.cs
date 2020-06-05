using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vjezba.Model
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string SocialSecurityNumber { get; set; }
    }
}
