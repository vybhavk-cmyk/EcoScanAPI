using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcoScanAPI.Models
{
    public class clothingItem
    {
        public string ItemName { get; set; }

        public int CarbonScore { get; set; }

        public int EcoPoints { get; set; }
    }
}