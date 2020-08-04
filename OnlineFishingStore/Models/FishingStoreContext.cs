using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFishingStore.Models
{
    public class FishingStoreContext :DbContext
    {
        public DbSet<FishingReel> FishingReels { get; set; }
        public DbSet<FishingRod> FishingRods { get; set; }

        public FishingStoreContext(DbContextOptions<FishingStoreContext> options) : base(options)
        {
        }
    }
}
