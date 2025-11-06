using Microsoft.AspNetCore.Mvc;
using PremiumCalculatorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculatorApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PremiumController : ControllerBase
    {
        [HttpPost("calculate")]
        public ActionResult<PremiumResponse> Calculate([FromBody] PremiumRequest req)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);


            var age = req.AgeNextBirthday;
            var factor = RatingModelService.GetFactorByOccupation(req.Occupation);
            var sumInsured = req.DeathSumInsured;

            var monthlyPremium = RatingModelService.CalculateMonthlyPremium(sumInsured, factor, age);

            var resp = new PremiumResponse
            {
                MonthlyPremium = Math.Round(monthlyPremium, 2),
                Occupation = req.Occupation,
                Factor = factor,
                Age = age
            };

            return Ok(resp);
        }
    }
}
