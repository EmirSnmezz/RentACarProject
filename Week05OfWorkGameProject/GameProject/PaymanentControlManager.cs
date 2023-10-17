using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class PaymanentControlManager : IPaymentControlService 
    {

        public bool PaymentControl (Gamer gamer , Game game) 
        { 
            if(gamer.creditCardRemainder > game.gamePrice || gamer.creditCardRemainder == game.gamePrice)
            {
                gamer.creditCardRemainder -= game.gamePrice;

                Console.WriteLine("Ödeme Alma İşlemi Başarılı ! Kalan Bakiye :" + gamer.creditCardRemainder);

                return true;
            }

            else
            {
                return false;
            }
        
        }

    }
}
