using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellApp
{
    public interface IGameManager
    {
        void AddGame(Game game);
        void RemoveGame(Game game);
        void UpdateGame(Game game);
    }
}
