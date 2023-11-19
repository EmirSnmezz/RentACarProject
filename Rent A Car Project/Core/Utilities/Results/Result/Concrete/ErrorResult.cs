using Core.Utilities.Results.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Result.Concrete
{
    public class ErrorResult : Result 
    {
        public ErrorResult(string message) : base(false , message)
        {

        }

        public ErrorResult(bool isSuccess) : base(false)
        {

        }
    }
}
