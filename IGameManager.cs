using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject
{
    interface IGameManager
    {
        void Add(Game game);
        void UpDate(Game game);
        void Delete(Game game);
    }
}
