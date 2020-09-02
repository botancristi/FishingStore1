using OnlineFishingStore.Interfaces;
using OnlineFishingStore.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFishingStore.Repository
{
    public class FishingReelRepository :IFishingReelRepository
    {
        private ApplicationContext context;
        public FishingReelRepository (ApplicationContext context)
        {
            this.context = context;
        }

        public void DeleteFishingReel(int ID)
        {
            throw new NotImplementedException();
        }

        public FishingReel GetFishingReelByID(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetFishingReels()
        {
            throw new NotImplementedException();
        }

        public void InsertFishingReel(FishingReel fishingReel)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateFishingReel(FishingReel fishingReel)
        {
            throw new NotImplementedException();
        }
    }
}
