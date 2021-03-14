using System;
using System.Collections.Generic;
using System.Text;

namespace TradersLib.Models
{
    public class User : BaseClass
    {
        public int Credits { get; set; }
        public string Username { get; set; }

        public Ship[] Ships { get; set; }
        public Loan[] Loans { get; set; }
    }

    public class UserResponse : BaseClass
    {
        public User User { get; set; }
    }
}
