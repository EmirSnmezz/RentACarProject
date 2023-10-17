using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{

    // Bu Tip Projelerde Önce Varlıklarımızı Bulmak lazım
    internal class Gamer 
    {
        public int gamerId { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string emailAdress { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

        public List<Game> games { get; set; } 

        public string creditCardNumber { get; set; }

        public string creditCardCvvNo { get; set; }

        public int creditCardRemainder { get; set; }



    }
}
