using System;
using System.Collections.Generic;
using System.Text;

namespace GamerCreateProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.Name=="Taner" && gamer.LastName=="Ürün" && gamer.Id==2 && gamer.Email=="taner.urun@outlook.com")
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
