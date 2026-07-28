using EcoScanAPI.Models;
using EcoScanAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcoScanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcoScanController : ControllerBase
    {
        [HttpPost("calculate")]
        public ActionResult<CalculationResponse> Calculate(CalculationRequest request)
        {
            CarbonCalculator carbonCalculator = new CarbonCalculator();

            RewardCalculator rewardCalculator = new RewardCalculator();

            OfferService offerService = new OfferService();

            var clothingItems = carbonCalculator.Calculate(request.Items);

            int totalCarbonScore = clothingItems.Sum(x => x.CarbonScore);

            int rewardPoints = rewardCalculator.Calculate(totalCarbonScore);

            var offers = offerService.GetOffers(rewardPoints);

            CalculationResponse response = new CalculationResponse
            {
                Items = clothingItems,
                TotalCarbonScore = totalCarbonScore,
                EcoRewardPoints = rewardPoints,
                Offers = offers
            };

            return Ok(response);
        }
    }
}
