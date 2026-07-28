using System.Collections.Generic;
using EcoScanAPI.Models;

namespace EcoScanAPI.Services

{
    public class CarbonCalculator
    {
        public List<ClothingItem> Calculate(List<string> items)
        {
            List<ClothingItem> result = new List<ClothingItem>();

            foreach (string item in items)
            {
                switch (item)
                {
                    case "T-shirt":
                        result.Add(new ClothingItem
                        {
                            Name = "T-shirt",
                            CarbonScore = 5
                        });
                        break;

                    case "Jeans":
                        result.Add(new ClothingItem
                        {
                            Name = "Jeans",
                            CarbonScore = 10
                        });
                        break;

                    case "Jacket":
                        result.Add(new ClothingItem
                        {
                            Name = "Jacket",
                            CarbonScore = 15
                        });
                        break;

                    case "Shoes":
                        result.Add(new ClothingItem
                        {
                            Name = "Shoes",
                            CarbonScore = 8
                        });
                        break;
                }
            }

            return result;
        }
    }
}
