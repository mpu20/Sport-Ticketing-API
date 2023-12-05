﻿using Microsoft.AspNetCore.Identity;

namespace SportTicketingAPI.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set;} = null!;
    }
}
