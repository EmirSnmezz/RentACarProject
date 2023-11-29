using Core.Entity_Framework;
using Core.Utilities.Results.Result.Concrete;
using Data_Access.Abstarct;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.Entity_Framework
{
    public class efRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        RentACarContext _context;
        public efRentalDal(RentACarContext context) : base(context)
        {
            _context = context;
        }
    }
}
