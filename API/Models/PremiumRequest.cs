using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculatorApp.Models
{
    public class PremiumRequest
    {
        [Required] 
        public string Name { get; set; }
        [Required] [Range(0, 150)]
        public int AgeNextBirthday { get; set; }
        [Required] 
                    
        public string DateOfBirth { get; set; } 
        [Required] 
        public string Occupation { get; set; }
        [Required] [Range(0.01, double.MaxValue)] 
        public decimal DeathSumInsured { get; set; }
    }
}
