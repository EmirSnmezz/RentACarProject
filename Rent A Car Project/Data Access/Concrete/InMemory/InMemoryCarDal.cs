using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {ID = 1 ,BranID = 1 , ColorID = 1 , ModelYear = 2023 , DailyPrice = 795000, Description = "Fiat Egea Cross"},
               
                new Car {ID = 2 ,BranID = 2 , ColorID = 3 , ModelYear = 2023 , DailyPrice = 1050000, Description = "Toyota Corolla"},
               
                new Car {ID = 3 ,BranID = 3 , ColorID = 5 , ModelYear = 2023 , DailyPrice = 1795000, Description = "Skoda Superb"},
               
                new Car {ID = 4 ,BranID = 4 , ColorID = 1 , ModelYear = 2023 , DailyPrice = 2995000, Description = "BMW 4 Series 430i"},
               
                new Car {ID = 5 ,BranID = 5 , ColorID = 1 , ModelYear = 2023 , DailyPrice = 3000000, Description = "Audi A5 Coupe"},
               
                new Car {ID = 6 ,BranID = 5 , ColorID = 1 , ModelYear = 2023 , DailyPrice = 7950000, Description = "Audi A8 Long"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car myCar = _cars.SingleOrDefault(c => c.ID == car.ID);
           
            _cars.Remove(myCar);
        }

        public List <Car> GetAll()
        {
            return _cars;
        }

        public int GetByID(Car car)
        {
            Car myCar = _cars.SingleOrDefault(c => c.ID == car.ID);

            return myCar.ID;
        }

        public Car Update(Car car)
        {

            Car myCar = _cars.SingleOrDefault(c=> c.ID == car.ID);
           
            myCar.ID = car.ID;
           
            myCar.BranID = car.BranID;
           
            myCar.ColorID = car.ColorID;
           
            myCar.DailyPrice = car.DailyPrice;
           
            myCar.Description = car.Description;
            
            return myCar;
        }
    }
}
