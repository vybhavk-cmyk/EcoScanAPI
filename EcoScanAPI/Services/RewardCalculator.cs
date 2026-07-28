namespace EcoScanAPI.Services
{
    public class RewardCalculator
    {
        public int Calculate(int totalCarbonScore)
        {
            return totalCarbonScore * 10;
        }
    }
}
