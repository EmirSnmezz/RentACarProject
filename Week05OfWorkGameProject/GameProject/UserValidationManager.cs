using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidatonService
    {
        public bool Check(Gamer Gamer)
        {
            if
              ( Gamer.userName == "crazyBoy_sagolera" &&

                Gamer.name == "Emir" &&

                Gamer.surname == "Sönmez" &&

                Gamer.gamerId == 1 )



            {
                return true;
            }

            else { return false; }
        }
    }
}
