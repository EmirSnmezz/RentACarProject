using Core.Entity_Framework;
using Data_Access.Abstarct;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.Entity_Framework
{
    public class efCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal  //EntityRepositoryBase generic sınıfından inherit aldığımız için ICarDal interface'ini implement ettiğimiz zaman                                                                               otomatikman inteface'in gerekliliği olan methodlar aldığımız inherit sayesinde otomatikman classımızın içinde içi                                                                                doldurulmuş bir şekilde base classtan gelmektedir
    {
        RentACarContext _context;
        public efCarDal(RentACarContext context) :base (context)
        {
            _context = context;
        }

        public List<CarDetailDto> CarDetail()
        {
            var result = from c in _context.Cars
                         join b in _context.Brands
                         on c.BrandId equals b.Id
                         join cl in _context.Colors
                         on c.ColorId equals cl.Id
                         select new CarDetailDto { CarName = c.Description, BrandName = b.BrandName, ColorName = cl.ColorName, DailyPrice = c.DailyPrice };

            return result.ToList();
        }
        public List<Car> GetByBrandId(int brandId)
        {
            var getByBrandId = _context.Cars.Where(p => p.BrandId == brandId).ToList();
            return getByBrandId;
        }

        public List<Car> GetByColorId(int ColorId)
        {
            var getByColorId = _context.Cars.Where(p => p.ColorId == ColorId).ToList();
            return getByColorId;
        }

        public Car GetById(int Id)
        {
            var car = _context.Cars.FirstOrDefault(x => x.ID == Id);
            return car;
        }
    }
}
