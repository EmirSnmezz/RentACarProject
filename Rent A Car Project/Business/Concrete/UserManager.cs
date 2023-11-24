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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User entity)
        {
            using (RentACarContext _context = new RentACarContext())
            {
                if(_userDal.GetAll(x => x.Id == entity.Id).Any() )
                {
                    return new ErrorResult(Messages.usersExistErrorMessage);
                }

                _userDal.Add(entity);

                if (_context.Set<User>().Where(x => x.Id == entity.Id).Any())
                {
                    return new SuccessResult(Messages.usersAddedSuccessMessage);
                }
                return new ErrorResult(Messages.usersAddedErrorMessage);
            }
        }

        public IResult Delete(User entity)
        {
            _userDal.Delete(entity);
            using (RentACarContext _context = new RentACarContext())
            {
                if (_context.Set<User>().Where(x => x.Id == entity.Id).Any())
                {
                    return new SuccessResult(Messages.usersDeletedSucessMessage);
                }
            }
            return new ErrorResult(Messages.usersDeletedErrorMessage);
        }

        public IDataResult<List<User>> GetAll(Expression<Func<User, bool>> filter = null)
        {
            if(_userDal.GetAll(filter).Any() == false || _userDal.GetAll().Any() == false )
            {
                return new ErrorDataResult<List<User>>(null,Messages.usersListedErrorMessage);
            }

            if (filter == null)
            {
                return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.usersListedSuccessMessage);
            }

            return new SuccessDataResult<List<User>>(_userDal.GetAll(filter), Messages.usersListedSuccessMessage);
        }

        public IResult Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
