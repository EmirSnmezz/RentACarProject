using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator() 
        {
            RuleFor(p => p.Description).NotEmpty().WithMessage("Araç Bilgisi Boş Geçilemez)");
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.DailyPrice).NotNull().WithMessage("Günlük Kiralık Ücret Boş Geçilemez");
            RuleFor(p => p.ModelYear).NotEmpty().WithMessage("Araç Model Bilgisi Boş Geçilemez");
        }
    }
}
