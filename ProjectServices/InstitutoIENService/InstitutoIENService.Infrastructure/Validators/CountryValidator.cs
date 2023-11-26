using FluentValidation;
using InstitutoIENService.Core.DTOs;

namespace InstitutoIENService.Infrastructure.Validators
{
    public class CountryValidator : AbstractValidator<CountryDto>
    {
        public CountryValidator()
        {
            RuleFor(country => country.Name)
                .NotEmpty()
                .Length(0,100);
        }
    }
}
