using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerService

        // Bir Manager Sınıfının İçerisinde başka bir manager sınıfını kullanacaksan asla onu newleme !!!!!
    {
        IUserValidatonService userValidationManager; // bunu Anlamadım. 5.gün sonu kayıt ve ona ait ödevleri bi tekrar et dependency injection'ı tekrar et


        public GamerManager( IUserValidatonService userValidationService)
        {

            userValidationManager = userValidationService;  // Burada Dependency ınjection'ın constructor injection'ını yaptık

        }
        public bool Register(Gamer Gamer)
        {
            if (userValidationManager.Check(Gamer) == true)
            {
                Console.WriteLine(" {0} Kullanıcı Adıyla Üyelik Kaydınız Gerçekleşti ! ", Gamer.userName);
                return true;
            }
            else
            {
                throw new Exception("Kimlik Bilgileri Doğrulanamadı.Tekrar Üye Olmayı Deneyiniz...");
            }

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");

        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.userName + "Kullanıcı Başarıyla Veritabanından Silindi");
        }


    }
}

