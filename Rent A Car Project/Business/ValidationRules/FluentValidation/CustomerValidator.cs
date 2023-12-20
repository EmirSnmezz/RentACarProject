using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.CompanyName).NotEmpty().WithMessage("Şirket İsmi Boş Geçilemez ! ...");
            RuleFor(p => p.UserId).NotNull().WithMessage("Müşteri Bir Kullanıcıdır. Bu Yüzden Müşteri Ataması Yapmak Zorundasınız ! ...");
        }
    }
}
