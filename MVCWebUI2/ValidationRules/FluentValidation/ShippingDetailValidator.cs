using FluentValidation;
using Market.MVCWebUI2.Models;

namespace Market.MVCWebUI2.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("Ad gerekli!");
            RuleFor(s => s.FirstName).MinimumLength(2);
            RuleFor(s => s.LastName).NotEmpty();
            RuleFor(s => s.Address).NotEmpty();
            RuleFor(s => s.City).NotEmpty().When(s => s.Age < 18);
            RuleFor(s => s.Age).InclusiveBetween(18, 65);
            RuleFor(s => s.Email).NotEmpty();
            //RuleFor(s => s.FirstName).Must(StartWithA);
        }

        /*private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }*/
    }
}
