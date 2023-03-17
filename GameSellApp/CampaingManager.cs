using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellApp
{
    public class CampaingManager : ICampaingManager
    {
        public void AddCampaing(Campaing campaing)
        {
            Console.WriteLine("Kampanya Eklendi. Kampanya indirim oranı:" + campaing.Discount);
        }

        public void RemoveCampaing(Campaing campaing)
        {
            Console.WriteLine("Kampanya Silindi :" + campaing.CampaingName);
        }

        public void UpdateCampaing(Campaing campaing)
        {
            Console.WriteLine("Kampanya Silindi :" + campaing.CampaingName);
        }
    }
}
