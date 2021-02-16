using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject
{
    class NewEStateUserValidationManager : IUserValidationManager
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
