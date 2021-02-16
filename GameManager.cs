using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject
{
    class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+"Eklendi."+'\n');
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "Silindi." + '\n');
        }

        public void UpDate(Game game)
        {
            Console.WriteLine(game.GameName + "Güncellendi." + '\n');
        }
    }
}
