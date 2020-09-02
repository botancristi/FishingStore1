using OnlineFishingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFishingStore.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<FishingReel> FishingReels { get; }
        IRepository<FishingRod> FishingRods { get; }
        void Commit();
      
    }
}
