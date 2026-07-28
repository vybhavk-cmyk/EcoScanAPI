namespace EcoScanAPI.Models
{
    public class CalculationResponse
    {
        public List<ClothingItem> Items { get; set; }

        public int TotalCarbonScore { get; set; }

        public int EcoRewardPoints { get; set; }

        public List<string> Offers { get; set; }
    }
}
