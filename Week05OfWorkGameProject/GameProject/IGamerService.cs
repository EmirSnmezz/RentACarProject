using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface  IGamerService
    {
        // Şunu Alışkanlık haline getirmemiz gerekiyor.Operasyon Sınıflarında Bir Interface Oluşturup Operasyon Sınıflarının İmlement Etmelerini Sağlamamız Gerekiyor.
        
        bool Register(Gamer gamer);

        void Update(Gamer gamer);

        void Remove(Gamer gamer);








    }
}
