using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculatorApp.Models
{
    public class PremiumResponse
    {
        public decimal MonthlyPremium { get; set; }
        public string Occupation { get; set; }
        public decimal Factor { get; set; }
        public int Age { get; set; }
    }
}
