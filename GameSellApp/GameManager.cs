using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellApp
{
    public class GameManager : IGameManager
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("Oyun Kaydedildi :" + game.GameName);
        }

        public void RemoveGame(Game game)
        {
            Console.WriteLine("Oyun Silindi :" + game.GameName);
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine("Oyun Güncellendi :" + game.GameName);
        }
    }
}
