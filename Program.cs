using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer();
            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            Gamer gamer2 = new Gamer();

            Game game1 = new Game() { GameId = "1",GameName="kafa topu",GameType="futbol" };
            Game game2 = new Game() {GameId="2", GameName="Pubg",GameType="savaş" };
            Game game3 = new Game() { GameId = "3", GameName = "zombi tsunami", GameType = "eğlencelik" };


            Campaign campaign1 = new Campaign() { CampaignName = "İLK OYUNA ÖZEL KAMPANYA",CampaignCode="abc3", DiscountRate = 45 };
            Campaign campaign2 = new Campaign() { CampaignName = "10.ALIŞERİŞ KAMPANYASI", CampaignCode = "cde5", DiscountRate = 35 };


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.UpDate(campaign1);
            campaignManager.UpDate(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game3, gamer1);
            salesManager.CampaignSales(game1, gamer1, campaign1);

        }
    }
}
