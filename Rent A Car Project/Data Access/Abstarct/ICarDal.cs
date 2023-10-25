using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Abstarct
{
    public interface ICarDal
    {
        int GetByID(Car car);
        List<Car> GetAll();
        void Add(Car car);
        Car Update(Car car);
        void Delete(Car car);

    }
}
