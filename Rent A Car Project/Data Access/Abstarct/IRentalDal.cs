using Core.DataAccess;
using Core.Utilities.Results.Result.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Abstarct
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
      
    }
}
