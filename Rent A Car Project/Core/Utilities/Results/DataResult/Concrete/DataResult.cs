using Core.Utilities.Results.DataResult.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.DataResult.Concrete
{
    public class DataResult<T> : Core.Utilities.Results.Result.Concrete.Result, IDataResult<T>
    {
        public DataResult(T data, bool isSuccess, string message) :base(isSuccess, message) 
        { 
            Data = data ;
        }

        public DataResult(T data, bool isSuccess) : base(isSuccess)
        {
            Data = data ;
        } 

        public T Data {get;}

      
    }
}
