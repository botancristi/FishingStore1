using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFishingStore.Models
{
    public class FishingReel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
        public string Material { get; set; }
        public string PlaceOfOrigin { get; set; }
        public string GearRatio { get; set; }
        public string BallBearings { get; set; }
        public string Spool { get; set; }
        public int MaxDrag { get; set; }
        public int LineCapacity { get; set; }
        public int Price { get; set; }
    }
}
