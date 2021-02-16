using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject
{
    public class GamerManager : IGamerManager
    {

        IUserValidationManager _userValidaitonManager;
        public GamerManager (IUserValidationManager userValidationManager)
        {
            _userValidaitonManager = userValidationManager;
        } 

        public void Add(Gamer gamer)
        {
            if (_userValidaitonManager.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.Name+"kayıt edildi.");
            }
            else
            {
                Console.WriteLine("doğrulama başarısız.kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidaitonManager.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.Name + "kayıt silindi..");
            }
            else
            {
                Console.WriteLine("doğrulama başarısız.kayıt başarısız.");
            }
        }

        public void UpDate (Gamer gamer)
        {
            if (_userValidaitonManager.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.Name + "kayıt güncellendi.");
            }
            else
            {
                Console.WriteLine("doğrulama başarısız.kayıt başarısız.");
            }
        }
    }
}
