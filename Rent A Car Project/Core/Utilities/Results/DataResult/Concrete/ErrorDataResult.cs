using Core.Utilities.Results.DataResult.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.DataResult.Concrete
{
    public class ErrorDataResult<T> : DataResult<T> , IDataResult<T>
    {
        public ErrorDataResult(T data,  string message) : base(data, false, message)
        {
        }

        public ErrorDataResult(T data, bool isSuccess) : base(data,false)
        {
        }
    }
}
