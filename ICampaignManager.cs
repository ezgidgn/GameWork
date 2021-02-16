using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject
{
    interface ICampaignManager
    {
        void Add(Campaign campaign);
        void UpDate(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
