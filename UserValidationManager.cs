using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject
{
  public  class UserValidationManager : IUserValidationManager
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == "3" && gamer.BirthYear == 1999 && gamer.Name == "Ezgi" && gamer.Surname == "Doğan" && gamer.IdedityNumber == "23456789871") 
            {
                return true;
            }
            else if (gamer.Id == "1" && gamer.BirthYear == 1987 && gamer.Name == "Gökhan" && gamer.Surname == "Doğan" && gamer.IdedityNumber == "12345678912") 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
