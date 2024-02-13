using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Autofac.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects
{
    public class ValidationAspect : MethodInterception
    {
        Type _validatorType;
        public ValidationAspect(Type validator)
        {
            if(!typeof(IValidator).IsAssignableFrom(validator))
            {
                throw new Exception("Bu bir doğrulama classı değil");
            }
            _validatorType = validator;
        }

        public override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator) Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where (t => t.GetType() == entityType).ToList();

            foreach( var entity in entities )
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
