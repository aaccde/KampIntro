using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.Write(campaign.CampaignName+" kampanyası eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.Write(campaign.CampaignName+" kampanyası silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.Write(campaign.CampaignName+" kampanyası güncellendi.");
        }
    }
}
