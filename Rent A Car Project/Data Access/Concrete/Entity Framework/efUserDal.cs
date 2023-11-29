using Core.DataAccess;
using Core.Entity_Framework;
using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.Entity_Framework
{
    public class efUserDal : EfEntityRepositoryBase<User, RentACarContext>, IUserDal
    {

        public efUserDal(RentACarContext context) : base(context)
        {
        }

    }
}
