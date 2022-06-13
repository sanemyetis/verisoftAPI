using Domain.Entity;
using FluentValidation;

namespace verisoftAPI.Validators
{
    public class ProductValidation :AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name can not be empty");
            RuleFor(p => p.Description).NotEmpty().WithMessage("Description can not be empty");
            RuleFor(p => p.Code).NotEmpty().WithMessage("Code can not be empty");
            RuleFor(p => p.Price).NotEmpty().WithMessage("Price can not be empty");
            
        }
    }
}
