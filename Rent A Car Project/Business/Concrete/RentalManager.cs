using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Result.Abstract;
using Core.Utilities.Results.Result.Concrete;
using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal) 
        {
            _rentalDal = rentalDal;
        }

        public IResult Rent(Car car, Customer customer)
        {
            _rentalDal.Add(new Rental { CarId = car.ID , CustomerId = customer.UserId , Id = 3, RentDate = System.DateTime.Now , ReturnDate = System.DateTime.Now});

            return new SuccessResult(Messages.rentACarSuccesful);
        }
    }
}
