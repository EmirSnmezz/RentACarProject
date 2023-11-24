using Core.Utilities.Results.DataResult.Abstract;
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
    public interface IUserService
    {
        IDataResult<List<User>> GetAll(Expression<Func<User, bool>> filter = null);
        IResult Add(User entity);
        IResult Delete(User entity);
        IResult Update(User entity);
    }
}
