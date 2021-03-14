using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TradersLib.Configuration;
using TradersLib.Models;

namespace TradersLib.Services
{
    public class LoanService
    {
        IApplicationConfiguration _config;
        HttpService _http;

        public LoanService(IApplicationConfiguration config, HttpService http)
        {
            _config = config;
            _http = http;
        }

        public async Task<LoanResponse> GetAvailableLoans()
        {
            return await _http.Get<LoanResponse>("game/loans", _config.Token);
        }

    }
}
