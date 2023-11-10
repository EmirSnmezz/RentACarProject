using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
       List <Car> GetAll();
        void Add(Car car );
        void Delete(Car car);
        List<Car> GetByColorId(int colorId);
        List<Car> GeByBrandId(int BrandId);
        public List<CarDetailDto> CarDetail();



    }
}
