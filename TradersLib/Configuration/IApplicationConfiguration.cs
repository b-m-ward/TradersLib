using System;
using System.Collections.Generic;
using System.Text;

namespace TradersLib.Configuration
{
    public interface IApplicationConfiguration
    {
        string UrlRoot { get; }
        string Username { get; }
        string Token { get; }

    }
}
