using Entites.Entites;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Valiotions
{
    public class ProductValidation:AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x => x.Title).NotEmpty().NotNull().WithMessage("عنوان را وارد کنید");
            RuleFor(x => x.Price).NotEmpty().NotNull().WithMessage("قیمت را وارد کنید");

        }
    }
}
