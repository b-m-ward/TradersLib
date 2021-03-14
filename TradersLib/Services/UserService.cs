using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TradersLib.Configuration;
using TradersLib.Models;

namespace TradersLib.Services
{
    public class UserService
    {
        IApplicationConfiguration _config;
        HttpService _http;
        public UserService(IApplicationConfiguration config, HttpService http)
        {
            _config = config;
            _http = http;
        }

        /// <summary>
        /// The return token is only generated ONCE and should be stored locally!
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public async Task<UserRegistration> RegisterUsername(string username)
        {
            UserRegistrationRequest registrationRequest = new UserRegistrationRequest()
            {
                Username = username
            };

            var reg = await _http.Post<UserRegistration>($"users/{username}/token", registrationRequest, null);
            return reg;
        }

        /// <summary>
        /// Gets the user info off of the loaded userSettings.json file.
        /// </summary>
        /// <returns></returns>
        public async Task<User> GetUserInfo()
        {
            return (await _http.Get<UserResponse>($"users/{_config.Username}", _config.Token)).User;
        }
    }
}
