using Core.Utilities.Results.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Result.Concrete
{
    public class SuccessResult : Result 
    {
        public SuccessResult(string message):base(true , message)
        {

        }

        public SuccessResult(bool isSuccess) : base(true)
        {

        }
    }
}
