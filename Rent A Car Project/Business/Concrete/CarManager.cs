﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns;
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
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);

            _carDal.Add(car);

            return new SuccessResult(Messages.carAddedSuccessMesage);

            return new ErrorResult(Messages.carAddedErrorMessage);
        }

        public IDataResult<List<CarDetailDto>> CarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.CarDetail().ToList(), Messages.carsListedSuccesMessage);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            if (_carDal.GetAll().Where(p => p.ID == car.ID).Count() == 0)
            {

               

                return new SuccessResult(Messages.carDeletedSuccesMessage);

            }

            return new ErrorResult(Messages.carDeletedErrorMessage);
        }

        public IDataResult<List<Car>> GetByBrandId(int BrandId)
        {
            if (_carDal.GetByBrandId(BrandId).Count > 0)
            {
                return new SuccessDataResult<List<Car>>(_carDal.GetByBrandId(BrandId), Messages.carsListedSuccesMessage);
            }

            return new ErrorDataResult<List<Car>>(_carDal.GetByBrandId(BrandId), Messages.carsListedErrorMessage);

        }

        public IDataResult<List<Car>> GetAll(Expression <Func<Car,bool>> filter=null)
        {
            if(filter == null)
            {
                if (_carDal.GetAll().Count > 0)
                {
                    return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.carsListedSuccesMessage);
                }

                return new ErrorDataResult<List<Car>>(_carDal.GetAll(), Messages.carsListedSuccesMessage);
            }

            if (_carDal.GetAll(filter).Count > 0)
            {
                return new SuccessDataResult<List<Car>>(_carDal.GetAll(filter), Messages.carsListedSuccesMessage);
            }

            return new ErrorDataResult<List<Car>>(_carDal.GetAll(), Messages.carsListedSuccesMessage);
        }

        public IDataResult<List<Car>> GetByColorId(int ColorId)
        {
            if (_carDal.GetByColorId(ColorId).Count > 0)
            {
                return new SuccessDataResult<List<Car>>(_carDal.GetByColorId(ColorId), Messages.carsListedSuccesMessage);
            }

            return new ErrorDataResult<List<Car>>(_carDal.GetByColorId(ColorId), Messages.carsListedErrorMessage);
        }
    }
}
