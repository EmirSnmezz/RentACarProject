using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptor
{
    public class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Proerity { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {
           
        }
    }
}
