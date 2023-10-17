using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface IPaymentControlService
    {
        bool PaymentControl(Gamer gamer , Game game); 
       
    }
}
