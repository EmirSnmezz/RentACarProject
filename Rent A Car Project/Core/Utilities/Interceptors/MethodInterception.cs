using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{
    public class MethodInterception : MethodInterceptionBaseAttribute
    {
        bool IsSuccess;
        public virtual void OnBefore (IInvocation invocation) { }
        public virtual void OnAfter (IInvocation invocation) { }
        public virtual void OnSuccess (IInvocation invocation) { }
        public virtual void OnException(IInvocation invocation, Exception ex) { }

        public override void Intercept(IInvocation invocation)
        {
            IsSuccess = true;
            OnBefore (invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception ex) 
            {
                IsSuccess = false;
                OnException (invocation, ex);
            }
            finally 
            {
                OnSuccess(invocation);
            }
            OnAfter(invocation);
        }
    }
}
