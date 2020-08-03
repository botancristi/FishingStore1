using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFishingStore.Models
{
    public class FishingRod
    {
        public int ID { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
        public string Material { get; set; }
        public string PlaceOfOrigin { get; set; }
        public string Hardness { get; set; }
        public int TopDiameter { get; set; }
        public int Price { get; set; }

    }
}
