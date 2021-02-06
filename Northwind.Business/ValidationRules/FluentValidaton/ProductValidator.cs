using FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Business.ValidationRules.FluentValidaton
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
        }
    }
}
