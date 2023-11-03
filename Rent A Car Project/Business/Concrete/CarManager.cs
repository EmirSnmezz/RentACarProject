using Business.Abstract;
using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length <= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç Başarıyla Yüklendi ! ");
            }
            else
            {
                Console.WriteLine ("Araç Yüklenirken Hata ! Araç Adı 2 Karakterden Az ve Günlük Ücreti 0 Tl Olamaz...");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GeByBrandId(int BrandId)
        {
             return _carDal.GetByBranId(BrandId);
        }

        public List<Car> GetAll()
        {
          return _carDal.GetAll();
        }

        public List<Car> GetByColorId(int ColorId)
        {
            return _carDal.GetByColorId(ColorId);
        }
    }
}
