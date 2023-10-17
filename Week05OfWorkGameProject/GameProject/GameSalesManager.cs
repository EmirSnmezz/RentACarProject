using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GameSalesManager: IGameSalesService

    {  
        
        IPaymentControlService paymentControlService;

        public GameSalesManager(IPaymentControlService paymentControlService) 
        {
            this.paymentControlService = paymentControlService;
        }
        public bool Buy (Game game , Gamer gamer)
        {
            if (paymentControlService.PaymentControl(gamer, game) == true)
            {
                gamer.games.Add(game);

                Console.WriteLine("{0} Adlı Oyun Başarıyla Satın Alındı. İyi Oyunlar !" +
                    "\nİşte Sahip Olduğun Tüm Oyunlar : [ {1} ] ", game.gameName, gamer.games.First());

                return true;
            }

            else { return false; }

            

        }
    }
}
