
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.DataResult.Abstract;
using Core.Utilities.Results.DataResult.Concrete;
using Core.Utilities.Results.Result.Abstract;
using Core.Utilities.Results.Result.Concrete;
using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brand)
        {
            _brandDal =  brand;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
           if(_brandDal.GetAll(p => p.Id == brand.Id).Any())
            {
                return new SuccessResult(Messages.brandAddedSuccessMessage);
            }

            return new ErrorResult(Messages.brandAddedErrorMessage);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            if(! _brandDal.GetAll(p=> p.Id == brand.Id).Any())
            {
                return new SuccessResult(Messages.brandDeletedSuccessMessage);
            }

            return new ErrorResult(Messages.brandDeletedErrorMessage);
        }

        public IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            if(filter == null)
            {
               if(_brandDal.GetAll().Count() > 0)
                {
                    return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.brandsListedSuccessMessage);
                }
                return new ErrorDataResult<List<Brand>>(null, Messages.brandsListedErrorMessage);
            }

            if(_brandDal.GetAll(filter).Count() > 0)
            {
                return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(filter), Messages.brandsListedSuccessMessage);
            }

            return new ErrorDataResult<List<Brand>>(null, Messages.brandsListedErrorMessage);
        }

        public IDataResult<Brand> Update(Brand brand)
        {
            return null;
        }
    }
}
