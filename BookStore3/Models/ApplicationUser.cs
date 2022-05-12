using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookStore3.Models
{
    public class ApplicationUser : IdentityUser
    {
        public String Address { get; set; }
    }
}
