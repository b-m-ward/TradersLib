using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TradersLib.Classes;
using TradersLib.Configuration;

namespace TradersLib.Services
{
    public class GameService
    {
        IApplicationConfiguration _config;
        HttpService _http;
        public GameService(IApplicationConfiguration config, HttpService http)
        {
            _config = config;
            _http = http;
        }

        public async Task<bool> IsActive()
        {
            try
            {
                GameHealthCheck output = await _http.Get<GameHealthCheck>("game/status");
                return output.IsHealthy;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
