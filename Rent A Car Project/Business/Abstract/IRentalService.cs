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
    public interface IRentalService
    {
        IResult Rent(Car car, Customer customer);
        IDataResult<List<Rental>> GetAll(Expression <Func<Rental, bool>> filter = null);
    }
}
