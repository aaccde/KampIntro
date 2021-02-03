using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer() {
                Id = 1,
                BirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            };
            gamerManager.Add(gamer);


            Campaign campaign = new Campaign()
            {
                Id = 1,
                CampaignName = "3 Al 1 Öde",
                CampaingRate=0
            };
            Game game = new Game()
            {
                Id = 1,
                GameName = "Counter Strike",
                GamePrice=50,
                UnitInStock = 55
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            GameSalesManager gameSalesManager = new GameSalesManager(campaign,game);
            gameSalesManager.Sale(game,gamer,null);


        }
    }
}
