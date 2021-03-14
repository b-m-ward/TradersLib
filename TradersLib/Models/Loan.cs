using System;
using System.Collections.Generic;
using System.Text;

namespace TradersLib.Models
{
    public class Loan
    {
        public int Amount { get; set; }
        public bool CollateralRequired { get; set; }
        public int Rate { get; set; }
        public int TermInDays { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public DateTime Due { get; set; }
    }

    public class LoanResponse : BaseClass
    {
        public Loan[] Loans { get; set; }
    }
}
