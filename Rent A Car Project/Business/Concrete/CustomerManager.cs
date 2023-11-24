using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.DataResult.Abstract;
using Core.Utilities.Results.DataResult.Concrete;
using Core.Utilities.Results.Result.Abstract;
using Core.Utilities.Results.Result.Concrete;
using Data_Access.Abstarct;
using Data_Access.Concrete.Entity_Framework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer entity)
        {
            _customerDal.Add(entity);
            using (RentACarContext _context = new RentACarContext())
            {
                if (_context.Set<Customer>().Where(x => x.UserId == entity.UserId).Count() == 1)
                {
                    return new SuccessResult(Messages.customersAddedSuccessMessage);
                }
            }
            return new ErrorResult(Messages.customersAddedErrorMessage);
        }

        public IResult Delete(Customer entity)
        {
            _customerDal.Delete(entity);
            using (RentACarContext _context = new RentACarContext())
            {
                if (_context.Set<Customer>().Where(x => x.UserId == entity.UserId).Count() == 0)
                {
                    return new SuccessResult(Messages.customersDeletedSuccessMessage);
                }
            }
            return new ErrorResult(Messages.customersDeletedErrorMessage);
        }

        public IDataResult<List<Customer>> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            if (filter == null)
            {
                return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.customersListedSuccessMessage);
            }
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(filter), Messages.customersListedSuccessMessage);
        }

        public IResult Update(Customer entity)
        {
            _customerDal.Update(entity);
            return new SuccessResult(Messages.colorUpdatedSuccessMessage);
        }
    }
}
