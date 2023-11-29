using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Abstarct
{
    public interface ICarDal : IEntityRepository <Car>
    {
        List<Car> GetByBrandId (int brandId);
        List<Car> GetByColorId (int ColorId);
        List<CarDetailDto> CarDetail();
    }
}
