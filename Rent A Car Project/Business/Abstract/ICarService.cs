﻿using Core.Utilities.Results.DataResult.Abstract;
using Core.Utilities.Results.Result.Abstract;
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
       IDataResult<List<Car>> GetAll(Expression <Func<Car,bool>> filter = null);
        IResult Add(Car car );
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetByColorId(int colorId);
        IDataResult<List<Car>> GetByBrandId(int brandId);
        IDataResult<Car> GetById(int carID);
        IDataResult<List<CarDetailDto>> CarDetail();



    }
}
