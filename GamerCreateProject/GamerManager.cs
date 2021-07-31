using System;
using System.Collections.Generic;
using System.Text;

namespace GamerCreateProject
{
    class GamerManager : IGamerSerivce
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
             if(gamer.Name=="Taner"&& gamer.LastName=="Ürün" && gamer.Email=="taner.urun@outlook.com" && gamer.Id==2)
            {
                Console.WriteLine("Kullanıcı eklendi");
            }
             else
            {
                Console.WriteLine("Giriş Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
