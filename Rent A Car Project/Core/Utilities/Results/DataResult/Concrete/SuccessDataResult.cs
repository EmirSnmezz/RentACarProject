using Core.Utilities.Results.DataResult.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.DataResult.Concrete
{
    public class SuccessDataResult<T> : DataResult<T> , IDataResult<T>
    {
        public SuccessDataResult(T data ,  string message) : base(data , true , message)
        { 
        }

        public SuccessDataResult(T data , bool isSuccess) : base(data,true)
        {

        }
    }
}
