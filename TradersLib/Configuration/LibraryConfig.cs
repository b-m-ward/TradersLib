using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TradersLib.Configuration
{
    public class LibraryConfig : IApplicationConfiguration
    {
        public string UrlRoot => "https://api.spacetraders.io/";

        public LibraryConfig()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(AppContext.BaseDirectory);
            builder.AddJsonFile("UserSettings.json", optional: false);
            try
            {
                var root = builder.Build();
                Username = root.GetSection("user")["username"];
                Token = root.GetSection("user")["token"];
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public string Username { get; private set; }
        public string Token { get; private set; }
    }
}
