using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer = new Gamer()
            {
                gamerId = 1,

                name = "Emir",

                surname = "Sönmez",

                userName = "crazyBoy_sagolera",

                password = "Emir123.",

                creditCardNumber = "3213213213123",

                creditCardCvvNo = "247",

                creditCardRemainder = 1000,

                games = new List<Game>()


            };


            Game game = new Game()
            {
                gameId = 1,
                gameName = "Call Of Duty",
                gameCategory = "war",
                gamePrice = 1000

            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Register(gamer);


            GameSalesManager gameSalesManager = new GameSalesManager(new PaymanentControlManager());
            gameSalesManager.Buy(game, gamer);



            Console.ReadLine();
        }
    }
}
