
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
    public class BrandManager : IBrandService
    {
        IBrandDal _BrandDal;
        public BrandManager(IBrandDal brand)
        {
            _BrandDal =  brand;
        }
        public List<Brand> GetAll()
        {
            return _BrandDal.GetAll();
        }
    }
}
