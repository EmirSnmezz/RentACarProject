using Core.DataAccess;
using Core.Utilities.Results.DataResult.Abstract;
using Core.Utilities.Results.Result.Abstract;
using Data_Access.Abstarct;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll(Expression<Func<Color, bool>> filter = null);
        IResult Add(Color entity);
        IResult Delete(Color entity);
        IResult Update(Color entity);
    
    }
}
