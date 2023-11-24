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
    public class ColorManager : IColorService
    {
        IColorDal _color;

        public ColorManager(IColorDal color) 
        { 
            _color = color;
        }

        public IResult Add(Color entity)
        {
            _color.Add(entity);
            return new SuccessResult(Messages.colorAddedSuccessMessage);
        }

        public IResult Delete(Color entity)
        {
            _color.Delete(entity);
            return new SuccessResult(Messages.colorDeletedSuccessMessage);
        }


        public IDataResult<List<Color>> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            if(filter != null)
            {
            return new ErrorDataResult<List<Color>>(_color.GetAll(filter),Messages.colorsListedErrorMessage);
            }

            return new SuccessDataResult<List<Color>>(_color.GetAll().ToList(),Messages.colorsListedSuccessMessage);
           
        }

        public IResult Update(Color entity)
        {
            _color.Update(entity);
            return new SuccessResult(Messages.colorUpdatedSuccessMessage);
        }
    }
}
