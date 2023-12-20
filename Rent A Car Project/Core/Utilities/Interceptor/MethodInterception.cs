using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptor
{
    public class MethodInterception : MethodInterceptionBaseAttribute
    {
        public void OnBefore (IInvocation invocation) { }
        public void OnAfter (IInvocation invocation) { }
        public void OnException(IInvocation invocation) { }
        public void OnSuccess(IInvocation invocation) { }

        public override void Intercept(IInvocation invocation)
        {
            OnBefore (invocation);
            var IsSuccess = true;

            try
            {
                invocation.Proceed();
            }
            catch (Exception ex) 
            {
                IsSuccess = false;
                OnException(invocation);
            }
            finally
            {
               if (IsSuccess) 
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);

        }


    }
}
