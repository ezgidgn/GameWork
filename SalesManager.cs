using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject
{
    class SalesManager : ISalesManager
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.Name+campaign.CampaignName+"ile"+"oyunu aldı."+'\n');
        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.Name+ game.GameName +"oyunu aldı."+'\n');
        }
    }
}
