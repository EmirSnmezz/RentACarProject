using Core.Utilities.Results.DataResult.Abstract;
using Core.Utilities.Results.Result.Abstract;
using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null);
        IResult Add(Brand Brand);
        IResult Delete(Brand car);
        IDataResult<Brand> Update(Brand Brand);

    }
}
