using System;
using System.Collections.Generic;
using System.Text;

namespace TradersLib.Models
{
    public class GameHealthCheck : BaseClass
    {
        public string Status { get; set; }
        public bool IsHealthy {
            get
            {
                if (this.Status.Contains("currently online and available"))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
