using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject
{
    class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("kampanya eklendi:"+campaign.CampaignName);
            Console.WriteLine("indirim oranı :"+campaign.DiscountRate);
            Console.WriteLine("geçerlilik tarihi :"+campaign.ValidityDate);

        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"'nın süresi dolduğundan kampanya silindi."+'\n');
        }

        public void UpDate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"isimli kampanya güncellendi.");
            Console.WriteLine("kampanya kodu:"+campaign.CampaignCode );
        }
    }
}
