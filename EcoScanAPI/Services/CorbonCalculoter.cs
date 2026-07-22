using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoScanAPI.Models;

namespace EcoScanAPI.Services
{
    public class CarbonCalculator
    {
        public clothingItem GetItem(string clothingName)
        {
            switch (clothingName.ToLower())
            {
                case "t-shirt":
                case "tshirt":
                case "shirt":

                    return new clothingItem
                    {
                        ItemName = "T-shirt",
                        CarbonScore = 5
                    };

                case "jeans":

                    return new clothingItem
                    {
                        ItemName = "Jeans",
                        CarbonScore = 10
                    };

                case "jacket":

                    return new clothingItem
                    {
                        ItemName = "Jacket",
                        CarbonScore = 15
                    };

                case "shoes":

                    return new clothingItem
                    {
                        ItemName = "Shoes",
                        CarbonScore = 8
                    };

                default:

                    return new clothingItem
                    {
                        ItemName = clothingName,
                        CarbonScore = 0
                    };
            }
        }
    }
}