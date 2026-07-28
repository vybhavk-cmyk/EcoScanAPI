namespace EcoScanAPI.Services
{
    public class OfferService
    {
        public List<string> GetOffers(int points)
        {
            List<string> offers = new List<string>();

            if (points >= 100)
                offers.Add("10% off sustainable clothing");

            if (points >= 200)
                offers.Add("free reusable tote bag");

            if (points >= 300)
                offers.Add("free eco gift pack");
            return offers;
        }
    }
}
