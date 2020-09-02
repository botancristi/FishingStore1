using OnlineFishingStore.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFishingStore.Interfaces
{
    interface IFishingReelRepository
    {
        IEnumerable GetFishingReels();
        FishingReel GetFishingReelByID(int ID);
        void InsertFishingReel(FishingReel fishingReel);
        void DeleteFishingReel(int ID);
        void UpdateFishingReel(FishingReel fishingReel);
        void Save();


    }
}
