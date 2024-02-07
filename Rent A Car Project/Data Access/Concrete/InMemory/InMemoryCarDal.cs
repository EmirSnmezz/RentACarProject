using Core.DataAccess;
using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car {ID = 1 ,BrandId = 1 , ColorId = 1 , ModelYear = 2023 , DailyPrice = 795000, Description = "Fiat Egea Cross"},
               
                new Car {ID = 2 ,BrandId = 2 , ColorId = 3 , ModelYear = 2023 , DailyPrice = 1050000, Description = "Toyota Corolla"},
               
                new Car {ID = 3 ,BrandId = 3 , ColorId = 5 , ModelYear = 2023 , DailyPrice = 1795000, Description = "Skoda Superb"},
               
                new Car {ID = 4 ,BrandId = 4 , ColorId = 1 , ModelYear = 2023 , DailyPrice = 2995000, Description = "BMW 4 Series 430i"},
               
                new Car {ID = 5 ,BrandId = 5 , ColorId = 1 , ModelYear = 2023 , DailyPrice = 3000000, Description = "Audi A5 Coupe"},
               
                new Car {ID = 6 ,BrandId = 5 , ColorId = 1 , ModelYear = 2023 , DailyPrice = 7950000, Description = "Audi A8 Long"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public List<CarDetailDto> CarDetail()
        {
            throw new NotImplementedException();
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

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBranId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByColorId(int ColorId)
        {
            throw new NotImplementedException();
        }

        public int GetByID(Car car)
        {
            Car myCar = _cars.SingleOrDefault(c => c.ID == car.ID);

            return myCar.ID;
        }

        public Car GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Car Update(Car car)
        {

            Car myCar = _cars.SingleOrDefault(c=> c.ID == car.ID);
           
            myCar.ID = car.ID;
           
            myCar.BrandId = car.BrandId;
           
            myCar.ColorId = car.ColorId;
           
            myCar.DailyPrice = car.DailyPrice;
           
            myCar.Description = car.Description;
            
            return myCar;
        }

        void IEntityRepository<Car>.Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
