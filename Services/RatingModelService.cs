using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculatorApp.Models
{
    public static  class RatingModelService
    {
        public static List<OccupationRatingModel> GetListOccupationRatings()
        {
            List<OccupationRatingModel> occupationRatingModels = new List<OccupationRatingModel>()
            {
                new OccupationRatingModel{ Occupation="Cleaner",Rating="Light Manual"},
                new OccupationRatingModel{Occupation="Doctor",Rating="Professional"},
                new OccupationRatingModel{Occupation="Author",Rating="White Collar"},
                new OccupationRatingModel{Occupation="Farmer",Rating="Heavy Manual"},
                new OccupationRatingModel{Occupation="Mechanic",Rating="Heavy Manual"},
                new OccupationRatingModel{Occupation="Florist",Rating="Light Manual"},
                new OccupationRatingModel{Occupation="Other",Rating="Heavy Manual"}
            };
            return occupationRatingModels;
        }



        // RatingName -> Factor
        public static List<RatingFactor> GetRatingFactors()

        {
            List<RatingFactor> ratingFactors = new List<RatingFactor>() {
                new RatingFactor { Rating = "Professional", Factor = 1.5m },
                new RatingFactor { Rating = "White Collar", Factor = 2.25m },
                new RatingFactor { Rating = "Light Manual", Factor = 11.50m },
                new RatingFactor { Rating = "Heavy Manual", Factor = 31.75m }
        };
            return ratingFactors;
        }


        public static decimal GetFactorByOccupation(string occupation)
        {
            var factor = (from o in GetListOccupationRatings()
                          join r in GetRatingFactors()
                          on o.Rating equals r.Rating
                          where o.Occupation.Equals(occupation, StringComparison.OrdinalIgnoreCase)
                          select r.Factor).FirstOrDefault();

            return factor;
        }

        public static decimal CalculateMonthlyPremium(decimal sumInsured, decimal factor, int age)
        {

           return ((sumInsured * factor * age) / 1000m * 12m);

        }

    }
}
