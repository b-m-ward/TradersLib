using System;
using System.Collections.Generic;
using System.Text;

namespace TradersLib.Models
{
    public class UserRegistration : BaseClass
    {
        public string Token { get; set; }
    }

    public class UserRegistrationRequest : BaseClass
    {
        public string Username { get; set; } 
    }
}
