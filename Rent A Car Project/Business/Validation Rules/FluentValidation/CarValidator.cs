using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator() 
        {
            RuleFor(p => p.Description).MinimumLength(2);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(1000);
            RuleFor(p => p.BrandId).NotNull().WithMessage("Marka Adı Boş Geçilemez knk");
        }
    }
}
