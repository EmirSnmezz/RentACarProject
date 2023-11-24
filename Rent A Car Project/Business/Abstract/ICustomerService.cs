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
    public interface ICustomerService 
    {
        IDataResult<List<Customer>> GetAll(Expression<Func<Customer, bool>> filter = null);
        IResult Add(Customer entity);
        IResult Delete(Customer entity);
        IResult Update(Customer entity);
    }
}
