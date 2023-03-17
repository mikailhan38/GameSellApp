using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellApp
{
    public class SellManager
    {
        public SellManager(Campaing campaing, Customer customer, Game game)
        {
            double price = game.Price * campaing.Discount / 100;
            
        }
    }
}
